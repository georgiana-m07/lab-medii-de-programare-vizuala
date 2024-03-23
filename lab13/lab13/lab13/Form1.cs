using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[,] vector = new double[3, 4] { { -6, 4, 87, 0 }, { 71, 2, -15, -63}, {0, 56, -12, -90 } };
        int n = 0;
        int p = 0;
        int z = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    if (vector[i, j] < 0)
                    {
                        n++;
                    }
                    else if (vector[i, j] > 0)
                    {
                        p++;
                    }
                    else
                        z++;
        }

        private void btnAfisareMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Numarul de numere negative este {n}, numarul celor pozitive este de {p}, iar numarul zerourilor este de {z}.");
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
    }
}
