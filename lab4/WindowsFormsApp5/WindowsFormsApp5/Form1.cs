using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] a;
        private void btnGenerare_Click(object sender, EventArgs e)
        {
            a = new int[Convert.ToInt32(txtLinii.Text), Convert.ToInt32(txtColoane.Text)];
            Random r = new Random();
            label3.Text = "";
            for(int i =0; i< Convert.ToInt32(txtLinii.Text);i++)
            {
                for(int j=0;j< Convert.ToInt32(txtColoane.Text);j++)
                {
                    a[i, j] = r.Next(0, 10);
                    label3.Text += a[i, j] + " ";
                }
                label3.Text += "\n";
            }
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            string o = cboOpt.Text;
            int l = Convert.ToInt32(txtLinii.Text);
            int c = Convert.ToInt32(txtColoane.Text);
            switch(o)
            {
                case "suma elemetelor":
                    int s = 0;
                    for (int i=0;i<l;i++)
                    { for (int j=0;j<c;j++)
                        {
                            s+= a[i, j];
                        }
                    }
                    MessageBox.Show("Suma elementelor este " + s);
                    break;

                case "minimul pe linie":
                    string min = "";
                    for (int i = 0; i < l; i++)
                    {
                        int m = a[i, 0];
                        for (int j = 0; j < c; j++)
                        {
                            if (m > a[i, j])
                                m = a[i, j];
                        }
                        min += "Minimul liniei " + (i + 1) + " este " + m+"\n";
                    }
                    MessageBox.Show(min);
                    break;


                case "maximul pe coloana":
                    string max = "";
                    for (int i = 0; i < c; i++)
                    {
                        int m = a[0, i];
                        for (int j = 0; j < l; j++)
                        {
                            if (m < a[j, i])
                                m = a[j, i];
                        }
                        max += "Maximul coloanei " + (i + 1) + " este " + m + "\n";
                    }
                    MessageBox.Show(max);
                    break;
                case "suma elementelor de pe diagonala principala":
                    if (l == c)
                    {
                        int suma = 0;
                        for (int i = 0; i < c; i++)
                            suma += a[i, i];
                        MessageBox.Show("suma elemetelor de pe diagonala principala este " + suma);
                    }
                    else
                        MessageBox.Show("Matricea nu este patratica");

                    break;
                case "suma elementelor aflate deaspra diagonalei principale":
                    int sd = 0;
                    for (int i = 0; i < l; i++)
                    {
                        for (int j =i+1; j < c; j++)
                        {
                            sd += a[i, j];
                        }
                    }
                    MessageBox.Show("Suma elementelor este " + sd);
                    break;
                   
                default:
                    MessageBox.Show("Alegeti o optiune");
                    break;
            }
        }
    }
}
