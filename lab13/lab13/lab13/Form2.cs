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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Din seminarul 4, doar ca editam matricea sa nu fie cu random ci cu datele puse de noi
        double[,] matrice = new double[6, 3] { {56, 91, 5 }, {73, 9, 68 }, {43, 73, 1 }, { 12, 63, 89}, {7, 78, 99 }, {34, 8, 16 } };
        double[] suma = new double[6];
        double[] produs = new double[3] { 1,1,1};
        
        private void Form2_Load(object sender, EventArgs e) 
        {
            lblAfisare.Text = "";
            //suma
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma[i] += matrice[i,j];
                }
                lblAfisare.Text += $"Suma pe linie este: {suma[i]}\n";
            }

            //produs
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    produs[j] *= matrice[i, j];
                }
                lblAfisare.Text += $"Produsul pe coloana este: {produs[j]}\n";
            }
        }
    }
}
