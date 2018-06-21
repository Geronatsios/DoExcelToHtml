using System;
using System.Windows.Forms;
using System.IO;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.Export;
using System.Text;

namespace DoExcelToHtml
{
    public partial class ufMain : Form{
        string nFile, tFile,pdfFile;
        OpenFileDialog dialog;
        public ufMain(){
            InitializeComponent();
            dialog = new OpenFileDialog();
            dialog.InitialDirectory = "c:\\";
            dialog.Filter = "xls files (*.xls)|*.xlsx|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;

            nFile = "";
            tFile = "";
            pdfFile = "";
			nExcelFile.SelectedIndex = 0;
        }

        private void excelToHtml(string nFromFile){
			string outPutFile = "";
			Stream myStream ;
			SaveFileDialog Dl = new SaveFileDialog();
			Dl.InitialDirectory = "c:\\";
			Dl.Filter = "html files(*.html)|*.htm|All files(*.*)|*.*";
			Dl.FilterIndex = 2;
			Dl.RestoreDirectory = true;
			if (Dl.ShowDialog() == DialogResult.OK) {
				outPutFile = Dl.FileName;
				
				// Create an object containing HTML export options.
				HtmlDocumentExporterOptions options = new HtmlDocumentExporterOptions();
				// Set HTML-specific export options.
				options.CssPropertiesExportType = DevExpress.XtraSpreadsheet.Export.Html.CssPropertiesExportType.Style;
				options.Encoding = Encoding.UTF8;
				// Specify the part of the document to be exported to HTML.
				Worksheet worksheet = spreadsheetControl1.ActiveWorksheet;
				options.SheetIndex = worksheet.Index;
				options.Range = "B11:O28";

				// Export a document to an HTML file with the specified options.
				spreadsheetControl1.ExportToHtml(outPutFile+".html", options);
				string fname = outPutFile + ".html";
				// Export the entire worksheet to a stream as HTML.
				ntextOutFile.Text = fname;
				myStream = new FileStream(Path.GetFullPath(outPutFile)+"_testFile_"+ Path.GetFileName(outPutFile) + ".html", FileMode.Create);
				spreadsheetControl1.ExportToHtml(myStream, worksheet.Index);
				myStream.Close();
				ReadingHtmlFile(fname);
				xtraTabControl1.SelectedTabPageIndex = 1;
			}
		}
		private void ReadingHtmlFile(string inFile) {
			htmlBrowser.Url = new Uri(inFile);
		}
		private void btnDoHTML_Click(object sender, EventArgs e) {
			excelToHtml(nFile);
		}

		private void btnDialog_Click(object sender, EventArgs e){
            if(dialog.ShowDialog() == DialogResult.OK){
                nFile = dialog.FileName;
                textBox1.Text = nFile;
				ntextOutFile.Text = "";
				tFile = Path.GetDirectoryName(nFile);
				using (FileStream stream = new FileStream(nFile, FileMode.Open)) {
					if (nExcelFile.SelectedIndex == 0)
						spreadsheetControl1.LoadDocument(stream, DocumentFormat.Xls);
					else
						spreadsheetControl1.LoadDocument(stream, DocumentFormat.Xlsx);
				}
			}
        }

		private void excelToJson(string inFile) {

		}

        private void excelToPdf(string nFromFile, string nToFile){
        }
    }
}
