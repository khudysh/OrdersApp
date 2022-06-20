using System;
using System.Windows.Forms;


namespace Shop
{
    public partial class FormMain : Form
    {
        DB db = new DB();
        FormSuccess formSuccess = new FormSuccess();
        FormCanceled formCanceled = new FormCanceled();
        FormAboutPogram formAboutProgram = new FormAboutPogram();
        FormClients formClients = new FormClients();

        public FormMain()
        {
            InitializeComponent();
        }

        private void successReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSuccess.ShowDialog();
        }

        private void canceledReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCanceled.ShowDialog();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string word = search.Text;
            dataGridView1.DataSource = db.Search(word);
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAboutProgram.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.AddOrder(dataGridView1.Rows[dataGridView1.Rows.Count - 2]);
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formClients.ShowDialog();
        }

        private void generateReport_Click(object sender, EventArgs e)
        {

            DateTime first_date_orders = DateTime.ParseExact(dateBefore.Value.ToShortDateString(), "dd.MM.yyyy", null);
            DateTime second_date_orders = DateTime.ParseExact(dateAfter.Value.ToShortDateString(), "dd.MM.yyyy", null);

            int id = (int)cbClient.SelectedValue;

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Отчёт о заказах";

            for (int i = 2; i < dataGridView1.Columns.Count - 1; i++)
            {
                worksheet.Cells[1, i - 1] = dataGridView1.Columns[i - 1].HeaderText;
            }

            int stroka = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if ((DateTime)dataGridView1.Rows[i].Cells[4].Value >= (first_date_orders) &&
                    (DateTime)dataGridView1.Rows[i].Cells[4].Value <= (second_date_orders) &&
                    (int)dataGridView1.Rows[i].Cells[6].Value == id)
                {
                    for (int j = 1; j < dataGridView1.Columns.Count - 2; j++)
                    {
                        worksheet.Cells[stroka + 2, j] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                    stroka++;
                }
            }

            workbook.SaveAs("f:\\Report_all.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

        }

        private void checkStatus_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                TimeSpan diff = DateTime.Today - (DateTime)dataGridView1.Rows[i].Cells[4].Value;
                if (diff.Days > 10)
                {
                    dataGridView1.Rows[i].Cells[5].Value = "аннулирован";
                    db.UpdateStatusOrder(dataGridView1.Rows[i]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GetAllTable();
            cbClient.DisplayMember = "surname";
            cbClient.ValueMember = "id";
            cbClient.DataSource = db.GetAllClients();
        }
    }
}
