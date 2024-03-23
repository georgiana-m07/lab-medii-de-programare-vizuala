using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1_lab9
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\flori.accdb");

        private void Form4_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql1 = "select * from flori ";
            OleDbDataAdapter da1 = new OleDbDataAdapter(sql1, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "flori");
            dataGridView1.Visible = true;
            dataGridView1.DataSource = ds1.Tables["flori"];
        }

        private void btnRevenire_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
