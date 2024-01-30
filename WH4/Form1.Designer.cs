namespace WH4
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
            this.grbmain = new System.Windows.Forms.GroupBox();
            this.lblOption = new System.Windows.Forms.Label();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grbAddFile = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.lblTape = new System.Windows.Forms.Label();
            this.cmbtape = new System.Windows.Forms.ComboBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.grbByType = new System.Windows.Forms.GroupBox();
            this.lblSeiectTypeToLok = new System.Windows.Forms.Label();
            this.cmbTypeToSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbmain.SuspendLayout();
            this.grbAddFile.SuspendLayout();
            this.grbByType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbmain
            // 
            this.grbmain.Controls.Add(this.btnSelect);
            this.grbmain.Controls.Add(this.cmbOption);
            this.grbmain.Controls.Add(this.lblOption);
            this.grbmain.Location = new System.Drawing.Point(35, 11);
            this.grbmain.Name = "grbmain";
            this.grbmain.Size = new System.Drawing.Size(729, 115);
            this.grbmain.TabIndex = 0;
            this.grbmain.TabStop = false;
            this.grbmain.Text = "main terminal";
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Location = new System.Drawing.Point(23, 45);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(128, 20);
            this.lblOption.TabIndex = 0;
            this.lblOption.Text = "Select an option:";
            this.lblOption.Click += new System.EventHandler(this.lblOption_Click);
            // 
            // cmbOption
            // 
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Items.AddRange(new object[] {
            "add default file to queue",
            "add a file to queue",
            "remove file from queue",
            "print all files in queue",
            "search all files by type",
            "print the biggest file in queue"});
            this.cmbOption.Location = new System.Drawing.Point(172, 42);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(250, 28);
            this.cmbOption.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(479, 31);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 49);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // grbAddFile
            // 
            this.grbAddFile.Controls.Add(this.btnCreateFile);
            this.grbAddFile.Controls.Add(this.cmbtape);
            this.grbAddFile.Controls.Add(this.lblTape);
            this.grbAddFile.Controls.Add(this.txbData);
            this.grbAddFile.Controls.Add(this.lblData);
            this.grbAddFile.Controls.Add(this.txbName);
            this.grbAddFile.Controls.Add(this.lblname);
            this.grbAddFile.Location = new System.Drawing.Point(35, 132);
            this.grbAddFile.Name = "grbAddFile";
            this.grbAddFile.Size = new System.Drawing.Size(729, 200);
            this.grbAddFile.TabIndex = 1;
            this.grbAddFile.TabStop = false;
            this.grbAddFile.Text = "add a file to queue";
            this.grbAddFile.Visible = false;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(16, 44);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(147, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter the file name:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(172, 44);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(250, 26);
            this.txbName.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(20, 92);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(92, 20);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Enter data: ";
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(172, 92);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(250, 26);
            this.txbData.TabIndex = 3;
            // 
            // lblTape
            // 
            this.lblTape.AutoSize = true;
            this.lblTape.Location = new System.Drawing.Point(24, 140);
            this.lblTape.Name = "lblTape";
            this.lblTape.Size = new System.Drawing.Size(94, 20);
            this.lblTape.TabIndex = 4;
            this.lblTape.Text = "Select tape:";
            // 
            // cmbtape
            // 
            this.cmbtape.FormattingEnabled = true;
            this.cmbtape.Items.AddRange(new object[] {
            "TXT",
            "DOC",
            "DOCX",
            "PDF",
            "PPTX"});
            this.cmbtape.Location = new System.Drawing.Point(172, 140);
            this.cmbtape.Name = "cmbtape";
            this.cmbtape.Size = new System.Drawing.Size(141, 28);
            this.cmbtape.TabIndex = 5;
            this.cmbtape.SelectedIndexChanged += new System.EventHandler(this.cmbtape_SelectedIndexChanged);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(542, 111);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(137, 49);
            this.btnCreateFile.TabIndex = 6;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // grbByType
            // 
            this.grbByType.Controls.Add(this.btnSearch);
            this.grbByType.Controls.Add(this.cmbTypeToSearch);
            this.grbByType.Controls.Add(this.lblSeiectTypeToLok);
            this.grbByType.Location = new System.Drawing.Point(35, 132);
            this.grbByType.Name = "grbByType";
            this.grbByType.Size = new System.Drawing.Size(729, 147);
            this.grbByType.TabIndex = 2;
            this.grbByType.TabStop = false;
            this.grbByType.Text = "search all files by type";
            this.grbByType.Visible = false;
            // 
            // lblSeiectTypeToLok
            // 
            this.lblSeiectTypeToLok.AutoSize = true;
            this.lblSeiectTypeToLok.Location = new System.Drawing.Point(33, 69);
            this.lblSeiectTypeToLok.Name = "lblSeiectTypeToLok";
            this.lblSeiectTypeToLok.Size = new System.Drawing.Size(119, 20);
            this.lblSeiectTypeToLok.TabIndex = 0;
            this.lblSeiectTypeToLok.Text = "Select the type:";
            // 
            // cmbTypeToSearch
            // 
            this.cmbTypeToSearch.FormattingEnabled = true;
            this.cmbTypeToSearch.Items.AddRange(new object[] {
            "TXT",
            "DOC",
            "DOCX",
            "PDF",
            "PPTX"});
            this.cmbTypeToSearch.Location = new System.Drawing.Point(178, 66);
            this.cmbTypeToSearch.Name = "cmbTypeToSearch";
            this.cmbTypeToSearch.Size = new System.Drawing.Size(156, 28);
            this.cmbTypeToSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(428, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbByType);
            this.Controls.Add(this.grbAddFile);
            this.Controls.Add(this.grbmain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbmain.ResumeLayout(false);
            this.grbmain.PerformLayout();
            this.grbAddFile.ResumeLayout(false);
            this.grbAddFile.PerformLayout();
            this.grbByType.ResumeLayout(false);
            this.grbByType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbmain;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox grbAddFile;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.ComboBox cmbtape;
        private System.Windows.Forms.Label lblTape;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox grbByType;
        private System.Windows.Forms.ComboBox cmbTypeToSearch;
        private System.Windows.Forms.Label lblSeiectTypeToLok;
        private System.Windows.Forms.Button btnSearch;
    }
}

