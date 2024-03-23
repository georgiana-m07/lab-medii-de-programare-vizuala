using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            double[] m = new double[2];
            double[] s = new double[2];
            int[] c = new int[2];

            for( int i=0; i<12;i++)
            {
                if(Form1.date[i,0]=="Euro")
                {
                    s[0] += Convert.ToDouble(Form1.date[i, 2]);
                    c[0]++;
                }
                else
                {
                    s[1] += Convert.ToDouble(Form1.date[i, 2]);
                    c[1]++;
                }
            }
            for( int i =0; i<2;i++)
            {
                m[i] = s[i] / c[i];
            }

            m[1] = s[1] / c[1];
            dataGridView1.Columns.Add("Moneda", "Moneda");
            dataGridView1.Columns.Add("Luna", "Luna");
            dataGridView1.Columns.Add("Curs", "Curs");
            dataGridView1.Columns.Add("Medie", "Medie");
            for ( int i=0;i<12;i++)
            {
                if (Form1.date[i, 0] == "Euro")
                dataGridView1.Rows.Add(new object[] { Form1.date[i, 0], Form1.date[i, 1], Form1.date[i, 2],m[0]});
                else
                dataGridView1.Rows.Add(new object []{ Form1.date[i, 0], Form1.date[i, 1], Form1.date[i, 2], m[1]});
            }
        }
    }
}
