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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Euro");
            chart1.Series.Add("Dolar");
            for(int i=0;i<6;i++)
            {
                chart1.Series["Euro"].Points.AddXY(Form1.date[i,1],Form1.date[i,2]);
            }
            for (int i = 6; i < 12; i++)
            {
                chart1.Series["Dolar"].Points.AddXY(Form1.date[i, 1], Form1.date[i, 2]);
            }
            chart1.Series["Euro"].IsValueShownAsLabel = true;
            chart1.Series["Dolar"].IsValueShownAsLabel = true;



        }
    }
}
