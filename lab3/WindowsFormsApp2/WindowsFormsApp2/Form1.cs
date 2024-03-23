using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void min_Click(object sender, EventArgs e)
        {
            double min = a[0];
            for (int i =1;i<Convert.ToInt32(txtnr.Text);i++)
            {
                if (min > a[i])
                    min = a[i];
            }
            label4.Text = "minimul este " + min;
        }
        double[] a;
        private void btnGenerare_Click(object sender, EventArgs e)
        {
            a = new double[Convert.ToInt32(txtnr.Text)];
        }
        int i = 0;

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            if (i < Convert.ToInt32(txtnr.Text))
            {
                a[i] = Convert.ToDouble(txtVal.Text);
                i++;
                txtVal.Clear();
                txtVal.Focus();
            }
            else
                MessageBox.Show("Toate pozitile din array au o valoare");
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            for( int d=0;d<Convert.ToInt32(txtnr.Text);d++)
            {
                label3.Text += a[d] + "; ";
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            double min = a[0];
            for (int i = 1; i < Convert.ToInt32(txtnr.Text); i++)
            {
                if (min < a[i])
                    min = a[i];
            }
            label4.Text = "maximul este " + min;
        }
    }
}
