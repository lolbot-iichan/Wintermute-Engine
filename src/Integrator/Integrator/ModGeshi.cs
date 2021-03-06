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
	public partial class ModGeshi : IntegratorModule
	{
		//////////////////////////////////////////////////////////////////////////
		public ModGeshi()
		{
			InitializeComponent();
		}

		//////////////////////////////////////////////////////////////////////////
		private void OnDownloadLink(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.geshi.org/");
		}

		//////////////////////////////////////////////////////////////////////////
		private void OnBrowseDir(object sender, EventArgs e)
		{
			FolderBrowserDialog Dlg = new FolderBrowserDialog();
			Dlg.Description = "Select output directory.";
			if (Directory.Exists(TxtOutputDir.Text)) Dlg.SelectedPath = TxtOutputDir.Text;

			if (Dlg.ShowDialog() == DialogResult.OK)
			{
				TxtOutputDir.Text = Dlg.SelectedPath;
			}
		}

		//////////////////////////////////////////////////////////////////////////
		override public void SaveSettings(SettingsNode RootNode)
		{
			RootNode.SetValue("GeshiOutputDir", TxtOutputDir.Text);
		}

		//////////////////////////////////////////////////////////////////////////
		override public void LoadSettings(SettingsNode RootNode)
		{
			TxtOutputDir.Text = RootNode.GetString("GeshiOutputDir");
		}

		//////////////////////////////////////////////////////////////////////////
		private void OnGenerate(object sender, EventArgs e)
		{
			if (!Directory.Exists(TxtOutputDir.Text))
			{
				MessageBox.Show("Please specify a valid output directory.", ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			try
			{
				string Filename = Path.Combine(TxtOutputDir.Text, "script.php");

				using (StreamWriter sw = new StreamWriter(Filename, false, Encoding.Default))
				{
					sw.WriteLine("<?php");
					sw.WriteLine("/*************************************************************************************");
 					sw.WriteLine("* script.php");
 					sw.WriteLine("* --------------");
 					sw.WriteLine("* WME Script language file for GeSHi.");
 					sw.WriteLine("* Generated by WME Integrator ");
 					sw.WriteLine("************************************************************************************/");
					sw.WriteLine("");
					sw.WriteLine("$language_data = array (");
  					sw.WriteLine("  'LANG_NAME' => 'WME Script',");
					sw.WriteLine("  'COMMENT_SINGLE' => array(1 => '//'),");
					sw.WriteLine("  'COMMENT_MULTI' => array('/*' => '*/'),");
					sw.WriteLine("  'CASE_KEYWORDS' => GESHI_CAPS_NO_CHANGE,");
					sw.WriteLine("  'QUOTEMARKS' => array('\"'),");
					sw.WriteLine("  'ESCAPE_CHAR' => '~',");
					sw.WriteLine("  'KEYWORDS' => array(");
					sw.WriteLine("    1 => array(");

					WordHolder wh;

					// keywords
					wh = new WordHolder();
					foreach (string Keyword in ScriptTokenizer.Keywords)
					{
						wh.AddWord(Keyword);
					}
					sw.WriteLine("    " + wh.GetWords());

  					sw.WriteLine("      ),");
					sw.WriteLine("    2 => array(");

					// read XML docs
					ScriptInfo Info = new ScriptInfo();
					Info.ReadXml(WmeUtils.XmlDocsPath);

					// methods
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
					sw.WriteLine("    " + wh.GetWords());

					sw.WriteLine("      ),");
					sw.WriteLine("    3 => array(");


					// attributes
					wh = new WordHolder();
					foreach (ScriptObject Obj in Info.Objects)
					{
						foreach (ScriptAttribute Attr in Obj.Attributes)
						{
							if (Attr.Name.StartsWith("[")) continue;
							wh.AddWord(Attr.Name);
						}
					}
					sw.WriteLine("    " + wh.GetWords());

					sw.WriteLine("      ),");
					sw.WriteLine("    4 => array(");
					sw.WriteLine("      '#region', '#endregion', '#include'");
					sw.WriteLine("      )");
					sw.WriteLine("    ),");
					sw.WriteLine("  'SYMBOLS' => array(");
					sw.WriteLine("    '(', ')', '[', ']', '{', '}', '!', '@', '%', '&', '*', '|', '/', '<', '>'");
					sw.WriteLine("    ),");
					sw.WriteLine("  'CASE_SENSITIVE' => array(");
					sw.WriteLine("    GESHI_COMMENTS => false,");
					sw.WriteLine("    1 => true,");
					sw.WriteLine("    2 => true,");
					sw.WriteLine("    3 => true,");
					sw.WriteLine("    4 => true");
					sw.WriteLine("    ),");
					sw.WriteLine("  'STYLES' => array(");
					sw.WriteLine("    'KEYWORDS' => array(");
					sw.WriteLine("      1 => 'color: #0000FF;',");
					sw.WriteLine("      2 => 'color: #800000;',");
					sw.WriteLine("      3 => 'color: #2B91AF;',");
					sw.WriteLine("      4 => 'color: #800080;'");
					sw.WriteLine("      ),");
					sw.WriteLine("    'COMMENTS' => array(");
					sw.WriteLine("      1 => 'color: #007F00; font-style: italic;',");
					sw.WriteLine("      'MULTI' => 'color: #007F00; font-style: italic;'");
					sw.WriteLine("      ),");
					sw.WriteLine("    'ESCAPE_CHAR' => array(");
					sw.WriteLine("      0 => 'color: #000000; font-weight: bold;'");
					sw.WriteLine("      ),");
					sw.WriteLine("    'BRACKETS' => array(");
					sw.WriteLine("      0 => 'color: #000000;'");
					sw.WriteLine("      ),");
					sw.WriteLine("    'STRINGS' => array(");
					sw.WriteLine("      0 => 'color: #808080;'");
					sw.WriteLine("      ),");
					sw.WriteLine("    'NUMBERS' => array(");
					sw.WriteLine("      0 => 'color: #CC0000;'");
					sw.WriteLine("      ),");
					sw.WriteLine("    'METHODS' => array(");
					sw.WriteLine("      1 => 'color: #404040;'");
					sw.WriteLine("      ),");
					sw.WriteLine("    'SYMBOLS' => array(");
					sw.WriteLine("      0 => 'color: #66cc66;'");
					sw.WriteLine("      ),");
					sw.WriteLine("    'REGEXPS' => array(),");
					sw.WriteLine("    'SCRIPT' => array()");
					sw.WriteLine("    ),");
					sw.WriteLine("  'URLS' => array(");
					sw.WriteLine("		1 => '',");
					sw.WriteLine("		2 => 'http://www.google.com/search?q={FNAME}+site:docs.dead-code.org/wme/generated&hl=en&lr=&as_qdr=all&filter=0',");
					sw.WriteLine("		3 => 'http://www.google.com/search?q={FNAME}+site:docs.dead-code.org/wme/generated&hl=en&lr=&as_qdr=all&filter=0',");
					sw.WriteLine("		4 => ''");
					sw.WriteLine("  	),");
					sw.WriteLine("  'OOLANG' => true,");
					sw.WriteLine("  'OBJECT_SPLITTERS' => array(");
					sw.WriteLine("  	1 => '.'");
					sw.WriteLine("	),");
					sw.WriteLine("  'REGEXPS' => array(),");
					sw.WriteLine("  'STRICT_MODE_APPLIES' => GESHI_NEVER,");
					sw.WriteLine("  'SCRIPT_DELIMITERS' => array(),");
					sw.WriteLine("  'HIGHLIGHT_STRICT_BLOCK' => array()");
					sw.WriteLine(");");
					sw.WriteLine("");
					sw.WriteLine("?>");
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
				int Counter = 0;
				string Ret = "";
				Words.Sort();
				for (int i = Words.Count - 1; i >= 0; i--)
				{
					if (Counter >= 10)
					{
						Ret = Ret + "\n    ";
						Counter = 0;
					}

					Ret += "'" + Words[i] + "'";
					if (i > 0) Ret += ", ";

					Counter++;
				}
				return Ret;
			}
		};

	}
}
