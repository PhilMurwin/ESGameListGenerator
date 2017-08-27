namespace ESGameListGenerator2
{
    partial class frmGameListGen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlROMFolder = new System.Windows.Forms.Panel();
            this.lblRomExtension = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtRomFolder = new System.Windows.Forms.TextBox();
            this.lblRomFolder = new System.Windows.Forms.Label();
            this.pnlImageOptions = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblImgSubfolder = new System.Windows.Forms.Label();
            this.txtImgExt = new System.Windows.Forms.TextBox();
            this.lblImgExt = new System.Windows.Forms.Label();
            this.chkImagefield = new System.Windows.Forms.CheckBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lblOptions = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtXmlPreview = new System.Windows.Forms.TextBox();
            this.btnGenPreview = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboRomExt = new System.Windows.Forms.ComboBox();
            this.pnlROMFolder.SuspendLayout();
            this.pnlImageOptions.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlROMFolder
            // 
            this.pnlROMFolder.Controls.Add(this.cboRomExt);
            this.pnlROMFolder.Controls.Add(this.lblRomExtension);
            this.pnlROMFolder.Controls.Add(this.btnBrowse);
            this.pnlROMFolder.Controls.Add(this.txtRomFolder);
            this.pnlROMFolder.Controls.Add(this.lblRomFolder);
            this.pnlROMFolder.Location = new System.Drawing.Point(1, 3);
            this.pnlROMFolder.Name = "pnlROMFolder";
            this.pnlROMFolder.Size = new System.Drawing.Size(427, 83);
            this.pnlROMFolder.TabIndex = 0;
            // 
            // lblRomExtension
            // 
            this.lblRomExtension.AutoSize = true;
            this.lblRomExtension.Location = new System.Drawing.Point(11, 54);
            this.lblRomExtension.Name = "lblRomExtension";
            this.lblRomExtension.Size = new System.Drawing.Size(78, 13);
            this.lblRomExtension.TabIndex = 3;
            this.lblRomExtension.Text = "Rom Extension";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(325, 22);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtRomFolder
            // 
            this.txtRomFolder.Location = new System.Drawing.Point(14, 24);
            this.txtRomFolder.Name = "txtRomFolder";
            this.txtRomFolder.Size = new System.Drawing.Size(305, 20);
            this.txtRomFolder.TabIndex = 1;
            // 
            // lblRomFolder
            // 
            this.lblRomFolder.AutoSize = true;
            this.lblRomFolder.Location = new System.Drawing.Point(11, 6);
            this.lblRomFolder.Name = "lblRomFolder";
            this.lblRomFolder.Size = new System.Drawing.Size(76, 13);
            this.lblRomFolder.TabIndex = 0;
            this.lblRomFolder.Text = "1. ROM Folder";
            // 
            // pnlImageOptions
            // 
            this.pnlImageOptions.Controls.Add(this.textBox3);
            this.pnlImageOptions.Controls.Add(this.lblImgSubfolder);
            this.pnlImageOptions.Controls.Add(this.txtImgExt);
            this.pnlImageOptions.Controls.Add(this.lblImgExt);
            this.pnlImageOptions.Controls.Add(this.chkImagefield);
            this.pnlImageOptions.Location = new System.Drawing.Point(13, 28);
            this.pnlImageOptions.Name = "pnlImageOptions";
            this.pnlImageOptions.Size = new System.Drawing.Size(406, 30);
            this.pnlImageOptions.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "boxart";
            // 
            // lblImgSubfolder
            // 
            this.lblImgSubfolder.AutoSize = true;
            this.lblImgSubfolder.Location = new System.Drawing.Point(234, 8);
            this.lblImgSubfolder.Name = "lblImgSubfolder";
            this.lblImgSubfolder.Size = new System.Drawing.Size(52, 13);
            this.lblImgSubfolder.TabIndex = 3;
            this.lblImgSubfolder.Text = "Subfolder";
            // 
            // txtImgExt
            // 
            this.txtImgExt.Location = new System.Drawing.Point(162, 5);
            this.txtImgExt.Name = "txtImgExt";
            this.txtImgExt.Size = new System.Drawing.Size(51, 20);
            this.txtImgExt.TabIndex = 2;
            this.txtImgExt.Text = ".png";
            // 
            // lblImgExt
            // 
            this.lblImgExt.AutoSize = true;
            this.lblImgExt.Location = new System.Drawing.Point(103, 8);
            this.lblImgExt.Name = "lblImgExt";
            this.lblImgExt.Size = new System.Drawing.Size(53, 13);
            this.lblImgExt.TabIndex = 1;
            this.lblImgExt.Text = "Extension";
            // 
            // chkImagefield
            // 
            this.chkImagefield.AutoSize = true;
            this.chkImagefield.Location = new System.Drawing.Point(7, 7);
            this.chkImagefield.Name = "chkImagefield";
            this.chkImagefield.Size = new System.Drawing.Size(77, 17);
            this.chkImagefield.TabIndex = 0;
            this.chkImagefield.Text = "Image field";
            this.chkImagefield.UseVisualStyleBackColor = true;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.lblOptions);
            this.pnlOptions.Controls.Add(this.pnlImageOptions);
            this.pnlOptions.Location = new System.Drawing.Point(1, 92);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(427, 79);
            this.pnlOptions.TabIndex = 2;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(10, 12);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(88, 13);
            this.lblOptions.TabIndex = 0;
            this.lblOptions.Text = "2. Select Options";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtXmlPreview);
            this.panel1.Controls.Add(this.btnGenPreview);
            this.panel1.Controls.Add(this.lblPreview);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 127);
            this.panel1.TabIndex = 3;
            // 
            // txtXmlPreview
            // 
            this.txtXmlPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXmlPreview.Location = new System.Drawing.Point(3, 35);
            this.txtXmlPreview.Multiline = true;
            this.txtXmlPreview.Name = "txtXmlPreview";
            this.txtXmlPreview.ReadOnly = true;
            this.txtXmlPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXmlPreview.Size = new System.Drawing.Size(243, 89);
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
            this.lblPreview.Size = new System.Drawing.Size(57, 13);
            this.lblPreview.TabIndex = 0;
            this.lblPreview.Text = "3. Preview";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.lblNote);
            this.panel2.Controls.Add(this.lblBegin);
            this.panel2.Location = new System.Drawing.Point(256, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 127);
            this.panel2.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(18, 62);
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
            this.lblBegin.Size = new System.Drawing.Size(46, 13);
            this.lblBegin.TabIndex = 0;
            this.lblBegin.Text = "4. Begin";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(1, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 134);
            this.panel3.TabIndex = 5;
            // 
            // cboRomExt
            // 
            this.cboRomExt.FormattingEnabled = true;
            this.cboRomExt.Location = new System.Drawing.Point(95, 50);
            this.cboRomExt.Name = "cboRomExt";
            this.cboRomExt.Size = new System.Drawing.Size(98, 21);
            this.cboRomExt.TabIndex = 4;
            // 
            // frmGameListGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 316);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlROMFolder);
            this.Name = "frmGameListGen";
            this.ShowIcon = false;
            this.Text = "ES Gamelist Generator";
            this.pnlROMFolder.ResumeLayout(false);
            this.pnlROMFolder.PerformLayout();
            this.pnlImageOptions.ResumeLayout(false);
            this.pnlImageOptions.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlROMFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtRomFolder;
        private System.Windows.Forms.Label lblRomFolder;
        private System.Windows.Forms.Panel pnlImageOptions;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblImgSubfolder;
        private System.Windows.Forms.TextBox txtImgExt;
        private System.Windows.Forms.Label lblImgExt;
        private System.Windows.Forms.CheckBox chkImagefield;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtXmlPreview;
        private System.Windows.Forms.Button btnGenPreview;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblRomExtension;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboRomExt;
    }
}

