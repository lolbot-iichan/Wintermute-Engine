namespace DeadCode.WME.StringTableMgr
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.TxtProjectFile = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnBrowseProject = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtStringTable = new System.Windows.Forms.TextBox();
			this.BtnBrowseTable = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.ProgScan = new System.Windows.Forms.ProgressBar();
			this.LblProgress = new System.Windows.Forms.Label();
			this.TxtLog = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.BtnScan = new System.Windows.Forms.Button();
			this.BtnManage = new System.Windows.Forms.Button();
			this.BtnSave = new System.Windows.Forms.Button();
			this.CheckBackup = new System.Windows.Forms.CheckBox();
			this.LinkAbout = new System.Windows.Forms.LinkLabel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TxtProjectFile
			// 
			this.TxtProjectFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TxtProjectFile.Location = new System.Drawing.Point(15, 25);
			this.TxtProjectFile.Name = "TxtProjectFile";
			this.TxtProjectFile.Size = new System.Drawing.Size(312, 20);
			this.TxtProjectFile.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Project file:";
			// 
			// BtnBrowseProject
			// 
			this.BtnBrowseProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnBrowseProject.Location = new System.Drawing.Point(333, 23);
			this.BtnBrowseProject.Name = "BtnBrowseProject";
			this.BtnBrowseProject.Size = new System.Drawing.Size(25, 23);
			this.BtnBrowseProject.TabIndex = 3;
			this.BtnBrowseProject.Text = "...";
			this.BtnBrowseProject.UseVisualStyleBackColor = true;
			this.BtnBrowseProject.Click += new System.EventHandler(this.OnBrowseProject);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "String t&able:";
			// 
			// TxtStringTable
			// 
			this.TxtStringTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TxtStringTable.Location = new System.Drawing.Point(15, 64);
			this.TxtStringTable.Name = "TxtStringTable";
			this.TxtStringTable.Size = new System.Drawing.Size(312, 20);
			this.TxtStringTable.TabIndex = 5;
			// 
			// BtnBrowseTable
			// 
			this.BtnBrowseTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnBrowseTable.Location = new System.Drawing.Point(333, 62);
			this.BtnBrowseTable.Name = "BtnBrowseTable";
			this.BtnBrowseTable.Size = new System.Drawing.Size(25, 23);
			this.BtnBrowseTable.TabIndex = 6;
			this.BtnBrowseTable.Text = "...";
			this.BtnBrowseTable.UseVisualStyleBackColor = true;
			this.BtnBrowseTable.Click += new System.EventHandler(this.OnBrowseTable);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(15, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(343, 2);
			this.label3.TabIndex = 8;
			// 
			// ProgScan
			// 
			this.ProgScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ProgScan.Location = new System.Drawing.Point(15, 151);
			this.ProgScan.Name = "ProgScan";
			this.ProgScan.Size = new System.Drawing.Size(343, 23);
			this.ProgScan.TabIndex = 10;
			// 
			// LblProgress
			// 
			this.LblProgress.AutoSize = true;
			this.LblProgress.Location = new System.Drawing.Point(12, 177);
			this.LblProgress.Name = "LblProgress";
			this.LblProgress.Size = new System.Drawing.Size(0, 13);
			this.LblProgress.TabIndex = 11;
			// 
			// TxtLog
			// 
			this.TxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TxtLog.Location = new System.Drawing.Point(12, 193);
			this.TxtLog.MaxLength = 0;
			this.TxtLog.Multiline = true;
			this.TxtLog.Name = "TxtLog";
			this.TxtLog.ReadOnly = true;
			this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TxtLog.Size = new System.Drawing.Size(346, 151);
			this.TxtLog.TabIndex = 12;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.BtnScan, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.BtnManage, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.BtnSave, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 116);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 29);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// BtnScan
			// 
			this.BtnScan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnScan.Location = new System.Drawing.Point(0, 3);
			this.BtnScan.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.BtnScan.Name = "BtnScan";
			this.BtnScan.Size = new System.Drawing.Size(111, 23);
			this.BtnScan.TabIndex = 0;
			this.BtnScan.Text = "S&can project";
			this.BtnScan.UseVisualStyleBackColor = true;
			this.BtnScan.Click += new System.EventHandler(this.OnScanProject);
			// 
			// BtnManage
			// 
			this.BtnManage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnManage.Location = new System.Drawing.Point(117, 3);
			this.BtnManage.Name = "BtnManage";
			this.BtnManage.Size = new System.Drawing.Size(108, 23);
			this.BtnManage.TabIndex = 1;
			this.BtnManage.Text = "&Manage strings";
			this.BtnManage.UseVisualStyleBackColor = true;
			this.BtnManage.Click += new System.EventHandler(this.OnManageStrings);
			// 
			// BtnSave
			// 
			this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnSave.Location = new System.Drawing.Point(231, 3);
			this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(112, 23);
			this.BtnSave.TabIndex = 2;
			this.BtnSave.Text = "&Save changes";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.OnSaveChanges);
			// 
			// CheckBackup
			// 
			this.CheckBackup.AutoSize = true;
			this.CheckBackup.Location = new System.Drawing.Point(15, 90);
			this.CheckBackup.Name = "CheckBackup";
			this.CheckBackup.Size = new System.Drawing.Size(101, 17);
			this.CheckBackup.TabIndex = 7;
			this.CheckBackup.Text = "&Backup old files";
			this.CheckBackup.UseVisualStyleBackColor = true;
			// 
			// LinkAbout
			// 
			this.LinkAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LinkAbout.AutoSize = true;
			this.LinkAbout.Location = new System.Drawing.Point(314, 7);
			this.LinkAbout.Name = "LinkAbout";
			this.LinkAbout.Size = new System.Drawing.Size(44, 13);
			this.LinkAbout.TabIndex = 1;
			this.LinkAbout.TabStop = true;
			this.LinkAbout.Text = "About...";
			this.LinkAbout.Click += new System.EventHandler(this.OnAbout);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 356);
			this.Controls.Add(this.LinkAbout);
			this.Controls.Add(this.CheckBackup);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.TxtLog);
			this.Controls.Add(this.LblProgress);
			this.Controls.Add(this.ProgScan);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.BtnBrowseTable);
			this.Controls.Add(this.TxtStringTable);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BtnBrowseProject);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtProjectFile);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WME String Table Manager";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			this.Load += new System.EventHandler(this.OnLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtProjectFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnBrowseProject;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtStringTable;
		private System.Windows.Forms.Button BtnBrowseTable;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ProgressBar ProgScan;
		private System.Windows.Forms.Label LblProgress;
		private System.Windows.Forms.TextBox TxtLog;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button BtnScan;
		private System.Windows.Forms.Button BtnManage;
		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.CheckBox CheckBackup;
		private System.Windows.Forms.LinkLabel LinkAbout;


	}
}