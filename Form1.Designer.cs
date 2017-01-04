using System;

namespace Paraesthesia.SNInfo
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtToken = new System.Windows.Forms.TextBox();
			this.lblToken = new System.Windows.Forms.Label();
			this.txtVersion = new System.Windows.Forms.TextBox();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblCulture = new System.Windows.Forms.Label();
			this.txtCulture = new System.Windows.Forms.TextBox();
			this.lblFullName = new System.Windows.Forms.Label();
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.lblLocation = new System.Windows.Forms.Label();
			this.txtLocation = new System.Windows.Forms.TextBox();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.pnlBasic = new System.Windows.Forms.Panel();
			this.cpyLocation = new Paraesthesia.SNInfo.CopyButton();
			this.cpyFullName = new Paraesthesia.SNInfo.CopyButton();
			this.pnlExpanded = new System.Windows.Forms.Panel();
			this.cpyBindingRedirect = new Paraesthesia.SNInfo.CopyButton();
			this.txtBindingRedirect = new System.Windows.Forms.TextBox();
			this.lblBindingRedirect = new System.Windows.Forms.Label();
			this.cpyPublicKey = new Paraesthesia.SNInfo.CopyButton();
			this.lblPublicKey = new System.Windows.Forms.Label();
			this.txtPublicKey = new System.Windows.Forms.TextBox();
			this.cpyVersion = new Paraesthesia.SNInfo.CopyButton();
			this.cpyCulture = new Paraesthesia.SNInfo.CopyButton();
			this.cpyToken = new Paraesthesia.SNInfo.CopyButton();
			this.cpyName = new Paraesthesia.SNInfo.CopyButton();
			this.btnExpand = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuFileOpen = new System.Windows.Forms.MenuItem();
			this.mnuFileDiv1 = new System.Windows.Forms.MenuItem();
			this.mnuFileExit = new System.Windows.Forms.MenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pnlBasic.SuspendLayout();
			this.pnlExpanded.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtToken
			// 
			this.txtToken.Location = new System.Drawing.Point(8, 136);
			this.txtToken.Name = "txtToken";
			this.txtToken.ReadOnly = true;
			this.txtToken.Size = new System.Drawing.Size(272, 20);
			this.txtToken.TabIndex = 0;
			// 
			// lblToken
			// 
			this.lblToken.Location = new System.Drawing.Point(8, 120);
			this.lblToken.Name = "lblToken";
			this.lblToken.Size = new System.Drawing.Size(100, 16);
			this.lblToken.TabIndex = 1;
			this.lblToken.Text = "Public Key Token";
			// 
			// txtVersion
			// 
			this.txtVersion.Location = new System.Drawing.Point(8, 56);
			this.txtVersion.Name = "txtVersion";
			this.txtVersion.ReadOnly = true;
			this.txtVersion.Size = new System.Drawing.Size(272, 20);
			this.txtVersion.TabIndex = 2;
			// 
			// lblVersion
			// 
			this.lblVersion.Location = new System.Drawing.Point(8, 40);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(100, 16);
			this.lblVersion.TabIndex = 3;
			this.lblVersion.Text = "Version";
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(8, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(100, 16);
			this.lblName.TabIndex = 7;
			this.lblName.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(8, 16);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(272, 20);
			this.txtName.TabIndex = 6;
			// 
			// lblCulture
			// 
			this.lblCulture.Location = new System.Drawing.Point(8, 80);
			this.lblCulture.Name = "lblCulture";
			this.lblCulture.Size = new System.Drawing.Size(100, 16);
			this.lblCulture.TabIndex = 9;
			this.lblCulture.Text = "Culture";
			// 
			// txtCulture
			// 
			this.txtCulture.Location = new System.Drawing.Point(8, 96);
			this.txtCulture.Name = "txtCulture";
			this.txtCulture.ReadOnly = true;
			this.txtCulture.Size = new System.Drawing.Size(272, 20);
			this.txtCulture.TabIndex = 8;
			// 
			// lblFullName
			// 
			this.lblFullName.Location = new System.Drawing.Point(8, 8);
			this.lblFullName.Name = "lblFullName";
			this.lblFullName.Size = new System.Drawing.Size(100, 16);
			this.lblFullName.TabIndex = 11;
			this.lblFullName.Text = "Full Name";
			// 
			// txtFullName
			// 
			this.txtFullName.Location = new System.Drawing.Point(8, 24);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.ReadOnly = true;
			this.txtFullName.Size = new System.Drawing.Size(272, 20);
			this.txtFullName.TabIndex = 10;
			// 
			// lblLocation
			// 
			this.lblLocation.Location = new System.Drawing.Point(8, 48);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(100, 16);
			this.lblLocation.TabIndex = 5;
			this.lblLocation.Text = "Location";
			// 
			// txtLocation
			// 
			this.txtLocation.Location = new System.Drawing.Point(8, 64);
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.ReadOnly = true;
			this.txtLocation.Size = new System.Drawing.Size(272, 20);
			this.txtLocation.TabIndex = 4;
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 88);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(338, 22);
			this.statusBar1.SizingGrip = false;
			this.statusBar1.TabIndex = 12;
			this.statusBar1.Text = "Drag a .NET assembly onto the form.";
			// 
			// pnlBasic
			// 
			this.pnlBasic.Controls.Add(this.cpyLocation);
			this.pnlBasic.Controls.Add(this.cpyFullName);
			this.pnlBasic.Controls.Add(this.txtLocation);
			this.pnlBasic.Controls.Add(this.lblFullName);
			this.pnlBasic.Controls.Add(this.lblLocation);
			this.pnlBasic.Controls.Add(this.txtFullName);
			this.pnlBasic.Location = new System.Drawing.Point(0, 0);
			this.pnlBasic.Name = "pnlBasic";
			this.pnlBasic.Size = new System.Drawing.Size(312, 88);
			this.pnlBasic.TabIndex = 13;
			// 
			// cpyLocation
			// 
			this.cpyLocation.Enabled = false;
			this.cpyLocation.Image = ((System.Drawing.Image)(resources.GetObject("cpyLocation.Image")));
			this.cpyLocation.Location = new System.Drawing.Point(280, 61);
			this.cpyLocation.Name = "cpyLocation";
			this.cpyLocation.Size = new System.Drawing.Size(24, 24);
			this.cpyLocation.TabIndex = 17;
			this.cpyLocation.Tag = "Location";
			this.cpyLocation.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// cpyFullName
			// 
			this.cpyFullName.Enabled = false;
			this.cpyFullName.Image = ((System.Drawing.Image)(resources.GetObject("cpyFullName.Image")));
			this.cpyFullName.Location = new System.Drawing.Point(280, 21);
			this.cpyFullName.Name = "cpyFullName";
			this.cpyFullName.Size = new System.Drawing.Size(24, 24);
			this.cpyFullName.TabIndex = 16;
			this.cpyFullName.Tag = "FullName";
			this.cpyFullName.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// pnlExpanded
			// 
			this.pnlExpanded.Controls.Add(this.cpyBindingRedirect);
			this.pnlExpanded.Controls.Add(this.txtBindingRedirect);
			this.pnlExpanded.Controls.Add(this.lblBindingRedirect);
			this.pnlExpanded.Controls.Add(this.cpyPublicKey);
			this.pnlExpanded.Controls.Add(this.lblPublicKey);
			this.pnlExpanded.Controls.Add(this.txtPublicKey);
			this.pnlExpanded.Controls.Add(this.cpyVersion);
			this.pnlExpanded.Controls.Add(this.cpyCulture);
			this.pnlExpanded.Controls.Add(this.cpyToken);
			this.pnlExpanded.Controls.Add(this.lblToken);
			this.pnlExpanded.Controls.Add(this.txtVersion);
			this.pnlExpanded.Controls.Add(this.lblVersion);
			this.pnlExpanded.Controls.Add(this.lblName);
			this.pnlExpanded.Controls.Add(this.txtName);
			this.pnlExpanded.Controls.Add(this.lblCulture);
			this.pnlExpanded.Controls.Add(this.txtCulture);
			this.pnlExpanded.Controls.Add(this.cpyName);
			this.pnlExpanded.Controls.Add(this.txtToken);
			this.pnlExpanded.Location = new System.Drawing.Point(0, 88);
			this.pnlExpanded.Name = "pnlExpanded";
			this.pnlExpanded.Size = new System.Drawing.Size(312, 365);
			this.pnlExpanded.TabIndex = 14;
			this.pnlExpanded.Visible = false;
			// 
			// cpyBindingRedirect
			// 
			this.cpyBindingRedirect.Enabled = false;
			this.cpyBindingRedirect.Image = ((System.Drawing.Image)(resources.GetObject("cpyBindingRedirect.Image")));
			this.cpyBindingRedirect.Location = new System.Drawing.Point(280, 278);
			this.cpyBindingRedirect.Name = "cpyBindingRedirect";
			this.cpyBindingRedirect.Size = new System.Drawing.Size(24, 24);
			this.cpyBindingRedirect.TabIndex = 21;
			this.cpyBindingRedirect.Tag = "BindingRedirect";
			this.cpyBindingRedirect.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// txtBindingRedirect
			// 
			this.txtBindingRedirect.Location = new System.Drawing.Point(8, 278);
			this.txtBindingRedirect.Multiline = true;
			this.txtBindingRedirect.Name = "txtBindingRedirect";
			this.txtBindingRedirect.ReadOnly = true;
			this.txtBindingRedirect.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBindingRedirect.Size = new System.Drawing.Size(272, 80);
			this.txtBindingRedirect.TabIndex = 20;
			this.txtBindingRedirect.WordWrap = false;
			// 
			// lblBindingRedirect
			// 
			this.lblBindingRedirect.Location = new System.Drawing.Point(8, 259);
			this.lblBindingRedirect.Name = "lblBindingRedirect";
			this.lblBindingRedirect.Size = new System.Drawing.Size(100, 16);
			this.lblBindingRedirect.TabIndex = 19;
			this.lblBindingRedirect.Text = "Binding Redirect";
			// 
			// cpyPublicKey
			// 
			this.cpyPublicKey.Enabled = false;
			this.cpyPublicKey.Image = ((System.Drawing.Image)(resources.GetObject("cpyPublicKey.Image")));
			this.cpyPublicKey.Location = new System.Drawing.Point(280, 176);
			this.cpyPublicKey.Name = "cpyPublicKey";
			this.cpyPublicKey.Size = new System.Drawing.Size(24, 24);
			this.cpyPublicKey.TabIndex = 18;
			this.cpyPublicKey.Tag = "PublicKey";
			this.cpyPublicKey.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// lblPublicKey
			// 
			this.lblPublicKey.Location = new System.Drawing.Point(8, 160);
			this.lblPublicKey.Name = "lblPublicKey";
			this.lblPublicKey.Size = new System.Drawing.Size(100, 16);
			this.lblPublicKey.TabIndex = 17;
			this.lblPublicKey.Text = "Public Key";
			// 
			// txtPublicKey
			// 
			this.txtPublicKey.Location = new System.Drawing.Point(8, 176);
			this.txtPublicKey.Multiline = true;
			this.txtPublicKey.Name = "txtPublicKey";
			this.txtPublicKey.ReadOnly = true;
			this.txtPublicKey.Size = new System.Drawing.Size(272, 80);
			this.txtPublicKey.TabIndex = 16;
			// 
			// cpyVersion
			// 
			this.cpyVersion.Enabled = false;
			this.cpyVersion.Image = ((System.Drawing.Image)(resources.GetObject("cpyVersion.Image")));
			this.cpyVersion.Location = new System.Drawing.Point(280, 53);
			this.cpyVersion.Name = "cpyVersion";
			this.cpyVersion.Size = new System.Drawing.Size(24, 24);
			this.cpyVersion.TabIndex = 13;
			this.cpyVersion.Tag = "Version";
			this.cpyVersion.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// cpyCulture
			// 
			this.cpyCulture.Enabled = false;
			this.cpyCulture.Image = ((System.Drawing.Image)(resources.GetObject("cpyCulture.Image")));
			this.cpyCulture.Location = new System.Drawing.Point(280, 93);
			this.cpyCulture.Name = "cpyCulture";
			this.cpyCulture.Size = new System.Drawing.Size(24, 24);
			this.cpyCulture.TabIndex = 15;
			this.cpyCulture.Tag = "Culture";
			this.cpyCulture.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// cpyToken
			// 
			this.cpyToken.Enabled = false;
			this.cpyToken.Image = ((System.Drawing.Image)(resources.GetObject("cpyToken.Image")));
			this.cpyToken.Location = new System.Drawing.Point(280, 133);
			this.cpyToken.Name = "cpyToken";
			this.cpyToken.Size = new System.Drawing.Size(24, 24);
			this.cpyToken.TabIndex = 14;
			this.cpyToken.Tag = "Token";
			this.cpyToken.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// cpyName
			// 
			this.cpyName.Enabled = false;
			this.cpyName.Image = ((System.Drawing.Image)(resources.GetObject("cpyName.Image")));
			this.cpyName.Location = new System.Drawing.Point(280, 13);
			this.cpyName.Name = "cpyName";
			this.cpyName.Size = new System.Drawing.Size(24, 24);
			this.cpyName.TabIndex = 12;
			this.cpyName.Tag = "Name";
			this.cpyName.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// btnExpand
			// 
			this.btnExpand.Location = new System.Drawing.Point(314, 61);
			this.btnExpand.Name = "btnExpand";
			this.btnExpand.Size = new System.Drawing.Size(24, 24);
			this.btnExpand.TabIndex = 15;
			this.btnExpand.Text = "+";
			this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileOpen,
            this.mnuFileDiv1,
            this.mnuFileExit});
			this.mnuFile.Text = "&File";
			// 
			// mnuFileOpen
			// 
			this.mnuFileOpen.Index = 0;
			this.mnuFileOpen.Text = "&Open...";
			this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
			// 
			// mnuFileDiv1
			// 
			this.mnuFileDiv1.Index = 1;
			this.mnuFileDiv1.Text = "-";
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Index = 2;
			this.mnuFileExit.Text = "E&xit";
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(338, 110);
			this.Controls.Add(this.btnExpand);
			this.Controls.Add(this.pnlExpanded);
			this.Controls.Add(this.pnlBasic);
			this.Controls.Add(this.statusBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Strong Name Info";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.pnlBasic.ResumeLayout(false);
			this.pnlBasic.PerformLayout();
			this.pnlExpanded.ResumeLayout(false);
			this.pnlExpanded.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtVersion;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblCulture;
		private System.Windows.Forms.TextBox txtCulture;
		private System.Windows.Forms.Label lblFullName;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblLocation;
		private System.Windows.Forms.TextBox txtLocation;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.Panel pnlBasic;
		private Paraesthesia.SNInfo.CopyButton cpyName;
		private Paraesthesia.SNInfo.CopyButton cpyVersion;
		private Paraesthesia.SNInfo.CopyButton cpyToken;
		private Paraesthesia.SNInfo.CopyButton cpyCulture;
		private Paraesthesia.SNInfo.CopyButton cpyFullName;
		private Paraesthesia.SNInfo.CopyButton cpyLocation;
		private System.Windows.Forms.TextBox txtToken;
		private System.Windows.Forms.Label lblToken;
		private System.Windows.Forms.Label lblPublicKey;
		private Paraesthesia.SNInfo.CopyButton cpyPublicKey;
		private System.Windows.Forms.Button btnExpand;
		private System.Windows.Forms.TextBox txtPublicKey;
		private System.Windows.Forms.Panel pnlExpanded;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuFileOpen;
		private System.Windows.Forms.MenuItem mnuFileDiv1;
		private System.Windows.Forms.MenuItem mnuFileExit;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private Paraesthesia.SNInfo.CopyButton cpyBindingRedirect;
		private System.Windows.Forms.TextBox txtBindingRedirect;
		private System.Windows.Forms.Label lblBindingRedirect;
	}
}