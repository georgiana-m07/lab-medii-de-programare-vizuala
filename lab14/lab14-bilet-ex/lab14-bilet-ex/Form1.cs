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

namespace lab14_bilet_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\produse.accdb");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'produseDataSet1.produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.produseDataSet1.produse);
            con.Open();
            string sql1 = "select * from produse ";
            OleDbDataAdapter da1 = new OleDbDataAdapter(sql1, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "produse");
            dataGridView1.Visible = true;
            dataGridView1.DataSource = ds1.Tables["produse"];
        }

        void produs_nou(double cod_prod, string den_prod, double pret, double cant)
        {
            OleDbCommand comanda1 = new OleDbCommand();
            comanda1.Connection = con;
            comanda1.CommandType = CommandType.Text;
            comanda1.CommandText = "INSERT INTO produse (cod_prod,den_prod,pret,cant) " + "values (" + cod_prod + ",'" + den_prod + "'," + pret + "," + cant + ")";
            comanda1.ExecuteNonQuery();
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            double cod_prod = 106;
            string den_prod = "fff";
            double pret = 8456;
            double cant = 56;
            produs_nou(cod_prod, den_prod, pret, cant);
            MessageBox.Show("A fost adaugat un nou produs!");
        }

        int[] vector = new int[10];
        private void btnVector_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Count;
            for (int i = 0; i < n - 1; n++)
                vector[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
          //  for (int i = 0; i < n - 1; n++)
               // MessageBox.Show(vector[i] + "\n");
        }

        private void btnValmedie_Click(object sender, EventArgs e)
        {
            double medie = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                medie += vector[i];
            }
            medie /= dataGridView1.Rows.Count - 1;
            label1.Text = medie + " ; ";
        }
    }
}
