using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DeadCode.WME.Global;
using DeadCode.WME.ScriptParser;
using DeadCode.WME.DocMaker;

namespace Integrator
{
	public partial class ModSciTE : IntegratorModule
	{
		//////////////////////////////////////////////////////////////////////////
		public ModSciTE()
		{
			InitializeComponent();
		}

		//////////////////////////////////////////////////////////////////////////
		private void OnDownloadLink(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.scintilla.org/");
		}

		//////////////////////////////////////////////////////////////////////////
		private void OnAssociate(object sender, EventArgs e)
		{
			string Exe;
			Exe = Path.Combine(WmeUtils.ToolsPath, "scite\\scite.exe");
			if (!File.Exists(Exe))
			{
				MessageBox.Show("The 'SciTE.exe' file was not found in the specified location. Please reinstall WME.", ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			MakeAssocitations(Exe);
		}

		string FileHeader = "# this file is automatically generated by WME Integrator\n# do not modify; your changes will be overwritten\n";

		//////////////////////////////////////////////////////////////////////////
		private void OnIntegrate(object sender, EventArgs e)
		{
			string ScitePath = Path.Combine(WmeUtils.ToolsPath, "scite");
			if (!Directory.Exists(ScitePath)) Directory.CreateDirectory(ScitePath);

			string[] Extensions = ParentForm.GetExtensions();
			string Extensions2 = "";
			foreach (string Ext in Extensions)
			{
				if (Extensions2 != "") Extensions2 += ";";
				Extensions2 += "*." + Ext;
			}

			// generate syntax file
			try
			{
				// read XML docs
				ScriptInfo Info = new ScriptInfo();
				Info.ReadXml(WmeUtils.XmlDocsPath);

				string KwdFile = Path.Combine(ScitePath, "wme_kwd.properties");

				using (StreamWriter sw = new StreamWriter(KwdFile, false, Encoding.Default))
				{
					sw.WriteLine(FileHeader);

					sw.WriteLine("file.patterns.script=" + Extensions2);
					sw.WriteLine("filter.script=WME Scripts|$(file.patterns.script)|");
					sw.WriteLine();

					WordHolder wh;

					// keywords
					sw.WriteLine("keywords.$(file.patterns.script)=\\");
					wh = new WordHolder();
					foreach (string Keyword in ScriptTokenizer.Keywords)
					{
						wh.AddWord(Keyword);
					}
					sw.WriteLine(wh.GetWords());


					// methods
					sw.WriteLine("keywords2.$(file.patterns.script)=\\");
					wh = new WordHolder();
					foreach (ScriptObject Obj in Info.Objects)
					{
						foreach (ScriptMethod Method in Obj.Methods)
						{
							foreach (string Header in Method.Headers)
							{
								int Brace = Header.IndexOf("(");
								if (Brace >= 0)
								{
									wh.AddWord(Header.Substring(0, Brace).Trim());
								}
							}
						}
					}
					sw.WriteLine(wh.GetWords());

					// attributes
					sw.WriteLine("keywords4.$(file.patterns.script)=\\");
					wh = new WordHolder();
					foreach (ScriptObject Obj in Info.Objects)
					{
						foreach (ScriptAttribute Attr in Obj.Attributes)
						{
							if (Attr.Name.StartsWith("[")) continue;
							wh.AddWord(Attr.Name);
						}
					}
					sw.WriteLine(wh.GetWords());
				}

				// tools
				string ToolsFile = Path.Combine(ScitePath, "wme_tools.properties");

				using (StreamWriter sw = new StreamWriter(ToolsFile, false, Encoding.Default))
				{
					sw.WriteLine(FileHeader);

					sw.WriteLine("command.compile.$(file.patterns.script)=\"" + WmeUtils.CompilerPath + "\" -script \"$(FilePath)\" -format scite");
					sw.WriteLine("command.help.$(file.patterns.script)=reference!" + Path.Combine(WmeUtils.ToolsPath, "wme.chm"));
					sw.WriteLine("command.help.subsystem.$(file.patterns.script)=4");
					sw.WriteLine("api.$(file.patterns.script)=" + Path.Combine(WmeUtils.ToolsPath, "SciTE\\wme.api"));
				}

				// api
				string ApiFile = Path.Combine(ScitePath, "wme.api");

				using (StreamWriter sw = new StreamWriter(ApiFile, false, Encoding.Default))
				{
					WordHolder wh;

					wh = new WordHolder();
					foreach (ScriptObject Obj in Info.Objects)
					{
						foreach (ScriptMethod Method in Obj.Methods)
						{
							foreach (string Header in Method.Headers)
							{
								wh.AddWord(Header + Method.Desc);
							}
						}
					}
					foreach (ScriptObject Obj in Info.Objects)
					{
						foreach (ScriptAttribute Attr in Obj.Attributes)
						{
							if (Attr.Name.StartsWith("[")) continue;
							wh.AddWord(Attr.Name);
						}
					}

					sw.WriteLine(wh.GetWordsApi());
				}

			}
			catch
			{
			}

		}

		//////////////////////////////////////////////////////////////////////////
		private class WordHolder
		{
			List<string> Words = new List<string>();

			//////////////////////////////////////////////////////////////////////////
			public void AddWord(string Word)
			{
				if (Word == null || Word == string.Empty) return;
				if (!Words.Contains(Word)) Words.Add(Word);
			}

			//////////////////////////////////////////////////////////////////////////
			public string GetWords()
			{
				string Ret = "";
				Words.Sort();
				int Counter = 0;
				foreach (string Word in Words)
				{
					if (Counter >= 10)
					{
						Ret = Ret + " \\\n";
						Counter = 0;
					}
					else if (Counter > 0) Ret = Ret + " ";
					Ret = Ret + Word;

					Counter++;
				}
				return Ret;
			}

			//////////////////////////////////////////////////////////////////////////
			public string GetWordsApi()
			{
				string Ret = "";
				Words.Sort();
				foreach(string Word in Words)
				{
					Ret += Word + "\n";
				}
				return Ret;
			}

		};

	
	}
}