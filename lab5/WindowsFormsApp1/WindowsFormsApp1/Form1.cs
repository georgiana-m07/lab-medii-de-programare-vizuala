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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string[,] date = new string[12, 3] {
            { "Euro", "1", "4.75" }, { "Euro", "2", "4.80" }, { "Euro", "3", "4.80" }, { "Euro", "4", "4.85" }, { "Euro", "5", "4.92" }, { "Euro", "6", "4.90" },
            { "Dolar", "1", "4.00" },{ "Dolar", "2", "4.15" },{ "Dolar", "3", "4.05" },{ "Dolar", "4", "4.75" },{ "Dolar", "5", "4.10" },{ "Dolar", "6", "4.20" }};

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
