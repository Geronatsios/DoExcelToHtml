namespace DoExcelToHtml
{
    partial class ufMain
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
            if(disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ufMain));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ntextOutFile = new System.Windows.Forms.TextBox();
			this.btnDoHTML = new DevExpress.XtraEditors.SimpleButton();
			this.nExcelFile = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDialog = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
			this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
			this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
			this.htmlBrowser = new System.Windows.Forms.WebBrowser();
			this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
			this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.xtraTabPage1.SuspendLayout();
			this.xtraTabPage2.SuspendLayout();
			this.xtraTabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ntextOutFile);
			this.groupBox1.Controls.Add(this.btnDoHTML);
			this.groupBox1.Controls.Add(this.nExcelFile);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnDialog);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1183, 108);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Επιλογή Διαδρομής";
			// 
			// ntextOutFile
			// 
			this.ntextOutFile.BackColor = System.Drawing.SystemColors.Info;
			this.ntextOutFile.Location = new System.Drawing.Point(223, 72);
			this.ntextOutFile.Name = "ntextOutFile";
			this.ntextOutFile.ReadOnly = true;
			this.ntextOutFile.Size = new System.Drawing.Size(267, 20);
			this.ntextOutFile.TabIndex = 6;
			// 
			// btnDoHTML
			// 
			this.btnDoHTML.Location = new System.Drawing.Point(96, 72);
			this.btnDoHTML.Name = "btnDoHTML";
			this.btnDoHTML.Size = new System.Drawing.Size(121, 22);
			this.btnDoHTML.TabIndex = 5;
			this.btnDoHTML.Text = "Μετατροπή σε HTML";
			this.btnDoHTML.Click += new System.EventHandler(this.btnDoHTML_Click);
			// 
			// nExcelFile
			// 
			this.nExcelFile.FormattingEnabled = true;
			this.nExcelFile.Items.AddRange(new object[] {
            "xls",
            "xlsx"});
			this.nExcelFile.Location = new System.Drawing.Point(96, 45);
			this.nExcelFile.Name = "nExcelFile";
			this.nExcelFile.Size = new System.Drawing.Size(121, 21);
			this.nExcelFile.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Είδος Αρχείου :";
			// 
			// btnDialog
			// 
			this.btnDialog.Location = new System.Drawing.Point(495, 17);
			this.btnDialog.Name = "btnDialog";
			this.btnDialog.Size = new System.Drawing.Size(83, 23);
			this.btnDialog.TabIndex = 2;
			this.btnDialog.Text = "Αρχείο";
			this.btnDialog.UseVisualStyleBackColor = true;
			this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Αρχείο :";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(96, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(394, 20);
			this.textBox1.TabIndex = 0;
			// 
			// xtraTabControl1
			// 
			this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtraTabControl1.Location = new System.Drawing.Point(0, 108);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
			this.xtraTabControl1.Size = new System.Drawing.Size(1183, 559);
			this.xtraTabControl1.TabIndex = 4;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
			// 
			// xtraTabPage1
			// 
			this.xtraTabPage1.Controls.Add(this.spreadsheetControl1);
			this.xtraTabPage1.Name = "xtraTabPage1";
			this.xtraTabPage1.Size = new System.Drawing.Size(1177, 531);
			this.xtraTabPage1.Text = "Excel";
			// 
			// spreadsheetControl1
			// 
			this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spreadsheetControl1.Location = new System.Drawing.Point(0, 0);
			this.spreadsheetControl1.Name = "spreadsheetControl1";
			this.spreadsheetControl1.Options.Import.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Csv.Encoding")));
			this.spreadsheetControl1.Options.Import.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Txt.Encoding")));
			this.spreadsheetControl1.Size = new System.Drawing.Size(1177, 531);
			this.spreadsheetControl1.TabIndex = 4;
			this.spreadsheetControl1.Text = "spreadsheetControl1";
			// 
			// xtraTabPage2
			// 
			this.xtraTabPage2.Controls.Add(this.htmlBrowser);
			this.xtraTabPage2.Name = "xtraTabPage2";
			this.xtraTabPage2.Size = new System.Drawing.Size(1177, 531);
			this.xtraTabPage2.Text = "HTML";
			// 
			// htmlBrowser
			// 
			this.htmlBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htmlBrowser.Location = new System.Drawing.Point(0, 0);
			this.htmlBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.htmlBrowser.Name = "htmlBrowser";
			this.htmlBrowser.Size = new System.Drawing.Size(1177, 531);
			this.htmlBrowser.TabIndex = 0;
			// 
			// xtraTabPage3
			// 
			this.xtraTabPage3.Controls.Add(this.memoEdit1);
			this.xtraTabPage3.Name = "xtraTabPage3";
			this.xtraTabPage3.Size = new System.Drawing.Size(1177, 531);
			this.xtraTabPage3.Text = "JSON";
			// 
			// memoEdit1
			// 
			this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.memoEdit1.Location = new System.Drawing.Point(0, 0);
			this.memoEdit1.Name = "memoEdit1";
			this.memoEdit1.Size = new System.Drawing.Size(1177, 531);
			this.memoEdit1.TabIndex = 0;
			// 
			// ufMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1183, 667);
			this.Controls.Add(this.xtraTabControl1);
			this.Controls.Add(this.groupBox1);
			this.Name = "ufMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ExcelToHtml";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			this.xtraTabPage1.ResumeLayout(false);
			this.xtraTabPage2.ResumeLayout(false);
			this.xtraTabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox nExcelFile;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
		private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
		private System.Windows.Forms.WebBrowser htmlBrowser;
		private DevExpress.XtraEditors.SimpleButton btnDoHTML;
		private System.Windows.Forms.TextBox ntextOutFile;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
		private DevExpress.XtraEditors.MemoEdit memoEdit1;
	}
}

