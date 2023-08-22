using OfficeOpenXml;
using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace InteropTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void PbX_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
             string ruta = dialogo.FileName;
             String dato = TxtNota.Text;          
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var workbook = package.Workbook;
                var worksheet = workbook.Worksheets.Add("Sheet1");               
                 worksheet.Cells["A1"].Value = dato;              
                string excelFilePath =ruta+".xlsx";
                package.SaveAs(new System.IO.FileInfo(excelFilePath));
                Process.Start(excelFilePath);
            }
            MessageBox.Show("Exportado a Excel");
        }

        private void PbW_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if(dialogo.ShowDialog() != DialogResult.OK){
                return; //finaliza el metodo
                        }
            String ruta = dialogo.FileName;
            var WordApp = new Word.Application();
            WordApp.Documents.Add();
            String dato = TxtNota.Text;
            WordApp.Selection.TypeText(dato);
            WordApp.ActiveDocument.SaveAs2(ruta);
            WordApp.Visible = true;
            MessageBox.Show("Exportado a Word");
        }
        
    }
}
