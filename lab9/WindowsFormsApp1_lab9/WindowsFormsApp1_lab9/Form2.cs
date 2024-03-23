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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\flori.accdb");

        private void btnRevenire_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql1 = "select cod_cl from clienti";
            OleDbDataAdapter da1 = new OleDbDataAdapter(sql1, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "clienti");
            int n1 = ds1.Tables["clienti"].Rows.Count;
            for (int i = 0; i < n1; i++)
                cbo_client.Items.Add(ds1.Tables["clienti"].Rows[i][0].ToString());
            // se selecteaza primul element
            cbo_client.Text = ds1.Tables["clienti"].Rows[0][0].ToString();
        }

        private void cbo_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = "select vanzari.cod_cl, vanzari.buc*flori.pret_u as total_achizitie from flori, vanzari where  vanzari.cod_fl=flori.cod_fl  and vanzari.cod_cl= " + cbo_client.Text;
            OleDbDataAdapter da2 = new OleDbDataAdapter(sql2, con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "client");
            dataGridView1.Visible = true;
            dataGridView1.DataSource = ds2.Tables["client"];
        }
    }
}
