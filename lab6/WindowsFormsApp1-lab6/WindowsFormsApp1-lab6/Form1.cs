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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInchidere_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAfisListView_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void btnAfisGrafic_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        public static string[,] date = new string[11, 3] { { "2012", "15", "10" }, { "2013", "25", "20" }, { "2014", "18", "22" }, { "2015", "23", "17" }, { "2016", "30", "25" }, { "2017", "28", "20" }, { "2018", "12", "8" }, { "2019", "14", "10" }, { "2020", "10", "7" }, { "2021", "15", "16" }, { "2022", "16", "16" }};
        
    }
}
