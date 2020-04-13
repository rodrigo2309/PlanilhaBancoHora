using System;
using System.Windows.Forms;
using ClosedXML.Excel;


namespace PlanilhaBancoHora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {

            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Planilha 1");

            //testestsets

            //Titulo relatorio
            ws.Cell("A1").Value = "Entrada";
            ws.Cell("B1").Value = "SAIDA";
            ws.Cell("C1").Value = "DATA";
            //var range = ws.Range("A1:C1");
            //range.Merge().Style.Font.SetBold().Font.FontSize = 20;

            //Corpo relatorio
            var linha = 4;

            var pQtdDias = System.DateTime.DaysInMonth(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month) ;
            Random pMin = new Random();
            int pLinha = 2;

            for(int i = 0;i < pQtdDias; i++)
            {
                if (((new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, i + 1)).ToString("ddd") == "sáb") ||
                        ((new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, i + 1)).ToString("ddd") == "dom"))
                {
                    ws.Cell("A" + pLinha).Value = "";
                    ws.Cell("B" + pLinha).Value = "";
                    ws.Cell("C" + pLinha).Value = string.Format(Convert.ToString(i + 1), "00") + "/" + dateTimePicker1.Value.Month;
                }
                else
                { 
                    ws.Cell("A" + pLinha).Value = "08:" + pMin.Next(int.Parse(MskIntSegEnt1.Text),int.Parse(MskIntSegEnt2.Text));
                    ws.Cell("B" + pLinha).Value = "17:" + pMin.Next(int.Parse(MskIntSegSai1.Text), int.Parse(MskIntSegSai2.Text));
                    ws.Cell("C" + pLinha).Value = string.Format(Convert.ToString(i + 1), "00") + "/" + dateTimePicker1.Value.Month;
                }

                pLinha++;
            }

            //formata campo data
            ws.Range("A2:A40").Style.DateFormat.Format = "hh:mm";
            ws.Range("B2:B40").Style.DateFormat.Format = "hh:mm";

            //ajusta coluna
            ws.Columns("2-40").AdjustToContents();
            
            

            //Salvar arquivo em disco
            wb.SaveAs(@"C:\Users\drigo\Desktop\testes\teste.xlsx");

            //Liberar Objetos
            //ws.Dispose();
            wb.Dispose();

            MessageBox.Show("Feito");
            
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
