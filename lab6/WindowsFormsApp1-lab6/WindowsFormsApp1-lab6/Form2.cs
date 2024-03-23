using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_lab6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRevenire_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.Visible = false;
            dataGridView1.Visible = false;
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Anul: ", 100);
            listView1.Columns.Add("Importul: ", 100);
            listView1.Columns.Add("Exportul: ", 100);
            optListView.Checked = true;

            for (int i = 0; i < 11; i++)
                listView1.Items.Add(new ListViewItem(new[] { Convert.ToString(Form1.date[i, 0]), Convert.ToString(Form1.date[i, 1]), Convert.ToString(Form1.date[i, 2]) }));

            dataGridView1.Columns.Add("Ani: ", "Ani: ");
            dataGridView1.Columns.Add("Import: ", "Import: ");
            dataGridView1.Columns.Add("Export: ", "Export: ");

            for (int i = 0; i < 11; i++)
            {
               
               dataGridView1.Rows.Add(new Object[] { Form1.date[i, 0], Form1.date[i, 1], Form1.date[i, 2]});                
            }

            //valoare max import
            double valm1;
            valm1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value);
            for (int i = 0; i < 11; i++)
                if (valm1 < Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value))
                    valm1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);

            //colorare valoare max import
            for (int i = 0; i < 11; i++)
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value) == valm1)
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.Chocolate;

            //valoare max export
            double valm2;
            valm2 = Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value);
            for (int i = 0; i < 11; i++)
                if (valm2 < Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value))
                    valm2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);


            // marcare max import in dataGridView - background verde inchis
            for (int i = 0; i < 11; i++)
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) == valm2)
                    dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Aquamarine;
        }

        private void optListView_CheckedChanged(object sender, EventArgs e)
        {
            if(optListView.Checked)
            {
                listView1.Show();
                dataGridView1.Hide();
            }
            else
            {
                dataGridView1.Show();
                listView1.Hide();
            }
        }
    }
}
