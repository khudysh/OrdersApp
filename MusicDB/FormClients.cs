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
    public partial class FormClients : Form
    {

        DB db = new DB();
        public FormClients()
        {
            InitializeComponent();
        }

        private void FormSuccess_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GetAllClients();
        }

    }
}
