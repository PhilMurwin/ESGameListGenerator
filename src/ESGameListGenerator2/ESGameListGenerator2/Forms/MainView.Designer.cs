namespace ESGameListGenerator2.Forms
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlROMFolder = new System.Windows.Forms.Panel();
            this.cboRomExt = new System.Windows.Forms.ComboBox();
            this.lblRomExtension = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtRomFolder = new System.Windows.Forms.TextBox();
            this.lblRomFolder = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.pnlImageOptions = new System.Windows.Forms.Panel();
            this.txtImgSubfolder = new System.Windows.Forms.TextBox();
            this.lblImgSubfolder = new System.Windows.Forms.Label();
            this.chkImgUseSubfolder = new System.Windows.Forms.CheckBox();
            this.chkImageField = new System.Windows.Forms.CheckBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.pnlGenXML = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.txtXmlPreview = new System.Windows.Forms.TextBox();
            this.btnGenPreview = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.pnlROMFolder.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlImageOptions.SuspendLayout();
            this.pnlGenXML.SuspendLayout();
            this.pnlPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // pnlROMFolder
            // 
            this.pnlROMFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlROMFolder.Controls.Add(this.cboRomExt);
            this.pnlROMFolder.Controls.Add(this.lblRomExtension);
            this.pnlROMFolder.Controls.Add(this.btnBrowse);
            this.pnlROMFolder.Controls.Add(this.txtRomFolder);
            this.pnlROMFolder.Controls.Add(this.lblRomFolder);
            this.pnlROMFolder.Location = new System.Drawing.Point(1, 25);
            this.pnlROMFolder.Name = "pnlROMFolder";
            this.pnlROMFolder.Size = new System.Drawing.Size(427, 83);
            this.pnlROMFolder.TabIndex = 1;
            // 
            // cboRomExt
            // 
            this.cboRomExt.FormattingEnabled = true;
            this.cboRomExt.Location = new System.Drawing.Point(100, 50);
            this.cboRomExt.Name = "cboRomExt";
            this.cboRomExt.Size = new System.Drawing.Size(98, 23);
            this.cboRomExt.TabIndex = 4;
            // 
            // lblRomExtension
            // 
            this.lblRomExtension.AutoSize = true;
            this.lblRomExtension.Location = new System.Drawing.Point(11, 54);
            this.lblRomExtension.Name = "lblRomExtension";
            this.lblRomExtension.Size = new System.Drawing.Size(86, 15);
            this.lblRomExtension.TabIndex = 3;
            this.lblRomExtension.Text = "Rom Extension";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(325, 22);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtRomFolder
            // 
            this.txtRomFolder.Location = new System.Drawing.Point(14, 24);
            this.txtRomFolder.Name = "txtRomFolder";
            this.txtRomFolder.Size = new System.Drawing.Size(305, 23);
            this.txtRomFolder.TabIndex = 1;
            // 
            // lblRomFolder
            // 
            this.lblRomFolder.AutoSize = true;
            this.lblRomFolder.Location = new System.Drawing.Point(11, 6);
            this.lblRomFolder.Name = "lblRomFolder";
            this.lblRomFolder.Size = new System.Drawing.Size(82, 15);
            this.lblRomFolder.TabIndex = 0;
            this.lblRomFolder.Text = "1. ROM Folder";
            // 
            // pnlOptions
            // 
            this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptions.Controls.Add(this.pnlImageOptions);
            this.pnlOptions.Controls.Add(this.lblOptions);
            this.pnlOptions.Location = new System.Drawing.Point(1, 116);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(427, 79);
            this.pnlOptions.TabIndex = 2;
            // 
            // pnlImageOptions
            // 
            this.pnlImageOptions.Controls.Add(this.txtImgSubfolder);
            this.pnlImageOptions.Controls.Add(this.lblImgSubfolder);
            this.pnlImageOptions.Controls.Add(this.chkImgUseSubfolder);
            this.pnlImageOptions.Controls.Add(this.chkImageField);
            this.pnlImageOptions.Location = new System.Drawing.Point(13, 28);
            this.pnlImageOptions.Name = "pnlImageOptions";
            this.pnlImageOptions.Size = new System.Drawing.Size(406, 35);
            this.pnlImageOptions.TabIndex = 1;
            // 
            // txtImgSubfolder
            // 
            this.txtImgSubfolder.Enabled = false;
            this.txtImgSubfolder.Location = new System.Drawing.Point(292, 5);
            this.txtImgSubfolder.Name = "txtImgSubfolder";
            this.txtImgSubfolder.Size = new System.Drawing.Size(94, 23);
            this.txtImgSubfolder.TabIndex = 3;
            this.txtImgSubfolder.Text = "boxart";
            // 
            // lblImgSubfolder
            // 
            this.lblImgSubfolder.AutoSize = true;
            this.lblImgSubfolder.Enabled = false;
            this.lblImgSubfolder.Location = new System.Drawing.Point(234, 9);
            this.lblImgSubfolder.Name = "lblImgSubfolder";
            this.lblImgSubfolder.Size = new System.Drawing.Size(58, 15);
            this.lblImgSubfolder.TabIndex = 2;
            this.lblImgSubfolder.Text = "Subfolder";
            // 
            // chkImgUseSubfolder
            // 
            this.chkImgUseSubfolder.AutoSize = true;
            this.chkImgUseSubfolder.Enabled = false;
            this.chkImgUseSubfolder.Location = new System.Drawing.Point(114, 7);
            this.chkImgUseSubfolder.Name = "chkImgUseSubfolder";
            this.chkImgUseSubfolder.Size = new System.Drawing.Size(104, 19);
            this.chkImgUseSubfolder.TabIndex = 1;
            this.chkImgUseSubfolder.Text = "Use Subfolder?";
            this.chkImgUseSubfolder.UseVisualStyleBackColor = true;
            this.chkImgUseSubfolder.CheckedChanged += new System.EventHandler(this.chkImgUseSubfolder_CheckedChanged);
            // 
            // chkImageField
            // 
            this.chkImageField.AutoSize = true;
            this.chkImageField.Location = new System.Drawing.Point(7, 7);
            this.chkImageField.Name = "chkImageField";
            this.chkImageField.Size = new System.Drawing.Size(85, 19);
            this.chkImageField.TabIndex = 0;
            this.chkImageField.Text = "Image field";
            this.chkImageField.UseVisualStyleBackColor = true;
            this.chkImageField.CheckedChanged += new System.EventHandler(this.chkImageField_CheckedChanged);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(10, 12);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(95, 15);
            this.lblOptions.TabIndex = 0;
            this.lblOptions.Text = "2. Select Options";
            // 
            // pnlGenXML
            // 
            this.pnlGenXML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGenXML.Controls.Add(this.btnGenerate);
            this.pnlGenXML.Controls.Add(this.lblNote);
            this.pnlGenXML.Controls.Add(this.lblBegin);
            this.pnlGenXML.Location = new System.Drawing.Point(434, 25);
            this.pnlGenXML.Name = "pnlGenXML";
            this.pnlGenXML.Size = new System.Drawing.Size(171, 127);
            this.pnlGenXML.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(18, 72);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(136, 38);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate gamelist.xml";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(18, 26);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(136, 42);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "If everything looks okay, click below to begin!";
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(4, 4);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(49, 15);
            this.lblBegin.TabIndex = 0;
            this.lblBegin.Text = "4. Begin";
            // 
            // pnlPreview
            // 
            this.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPreview.Controls.Add(this.txtXmlPreview);
            this.pnlPreview.Controls.Add(this.btnGenPreview);
            this.pnlPreview.Controls.Add(this.lblPreview);
            this.pnlPreview.Location = new System.Drawing.Point(1, 201);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(604, 177);
            this.pnlPreview.TabIndex = 0;
            // 
            // txtXmlPreview
            // 
            this.txtXmlPreview.Location = new System.Drawing.Point(3, 35);
            this.txtXmlPreview.Multiline = true;
            this.txtXmlPreview.Name = "txtXmlPreview";
            this.txtXmlPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXmlPreview.Size = new System.Drawing.Size(598, 139);
            this.txtXmlPreview.TabIndex = 2;
            // 
            // btnGenPreview
            // 
            this.btnGenPreview.Location = new System.Drawing.Point(67, 4);
            this.btnGenPreview.Name = "btnGenPreview";
            this.btnGenPreview.Size = new System.Drawing.Size(109, 23);
            this.btnGenPreview.TabIndex = 1;
            this.btnGenPreview.Text = "Generate Preview";
            this.btnGenPreview.UseVisualStyleBackColor = true;
            this.btnGenPreview.Click += new System.EventHandler(this.btnGenPreview_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(4, 4);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(60, 15);
            this.lblPreview.TabIndex = 0;
            this.lblPreview.Text = "3. Preview";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 384);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.pnlGenXML);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlROMFolder);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "ES Gamelist Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlROMFolder.ResumeLayout(false);
            this.pnlROMFolder.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlImageOptions.ResumeLayout(false);
            this.pnlImageOptions.PerformLayout();
            this.pnlGenXML.ResumeLayout(false);
            this.pnlGenXML.PerformLayout();
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel pnlROMFolder;
        private ComboBox cboRomExt;
        private Label lblRomExtension;
        private Button btnBrowse;
        private TextBox txtRomFolder;
        private Label lblRomFolder;
        private Panel pnlOptions;
        private Panel pnlImageOptions;
        private TextBox txtImgSubfolder;
        private Label lblImgSubfolder;
        private CheckBox chkImgUseSubfolder;
        private CheckBox chkImageField;
        private Label lblOptions;
        private Panel pnlGenXML;
        private Button btnGenerate;
        private Label lblNote;
        private Label lblBegin;
        private Panel pnlPreview;
        private TextBox txtXmlPreview;
        private Button btnGenPreview;
        private Label lblPreview;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}