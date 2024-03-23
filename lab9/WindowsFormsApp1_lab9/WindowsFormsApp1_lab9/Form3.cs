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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void btnInserare_Click(object sender, EventArgs e)
        {
            string sql1 = "SELECT MAX(cod_fl) from flori";
            OleDbDataAdapter da1 = new OleDbDataAdapter(sql1, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "ID-MAX");
            int max = Convert.ToInt32(ds1.Tables["ID-MAX"].Rows[0][0]);

            int id_nou = max + 1;
            string nume_fl = txt_nume.Text;
            double pret = Convert.ToDouble(txt_pret.Text);

            OleDbCommand comanda1 = new OleDbCommand();
            comanda1.Connection = con;
            comanda1.CommandType = CommandType.Text;
            comanda1.CommandText = "INSERT INTO flori (cod_fl,nume_fl,pret_u) " + "values (" + id_nou + "," + "'" + nume_fl + "'" + "," + pret + ")";
            comanda1.ExecuteNonQuery();
            
        }
    }
}
