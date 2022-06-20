using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class FormSuccess : Form
    {
        DB db = new DB();

        public FormSuccess()
        {
            InitializeComponent();
        }

        private void FormSuccess_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GetSuccess();
            dateSuccess.ValueMember = "date";
            dateSuccess.DataSource = db.GetSuccessDates();
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            DateTime date_orders = (DateTime)dateSuccess.SelectedValue;
            Console.WriteLine(date_orders);
 
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Отчёт о исполненных заказах";

            for (int i = 2; i < dataGridView1.Columns.Count -1; i++)
            {
                worksheet.Cells[1, i-1] = dataGridView1.Columns[i - 1].HeaderText;
            }

            int stroka = 0;
            Console.WriteLine(dataGridView1.Rows.Count);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.Equals(date_orders))
                {

                    for (int j = 1; j < dataGridView1.Columns.Count -2; j++)
                    {
                        Console.WriteLine(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        worksheet.Cells[stroka + 2, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                    }
                    stroka++;
                }
            }

            workbook.SaveAs("f:\\Report_success.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
