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

        private void optLei_CheckedChanged(object sender, EventArgs e)
        {
            cboRata.Items.Clear();
            cboRata.Items.Add("5");
            cboRata.Items.Add("10");
            cboRata.Items.Add("100");
        }

        private void optEuro_CheckedChanged(object sender, EventArgs e)
        {
            cboRata.Items.Clear();
            cboRata.Items.Add("3");
            cboRata.Items.Add("4");
            cboRata.Items.Add("5");
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            double suma = Convert.ToDouble(txtSuma.Text);
            int perioada = Convert.ToInt32(numPerioada.Value);
            double rata = Convert.ToDouble(cboRata.SelectedItem)/1200;
            double valimprumut, valdobanda, anuitate, amortisment, valramasa;
            if(optAnuitati.Checked)
            {
                anuitate = Math.Round(suma*rata/(1-Math.Pow(1+rata,-perioada)), 1);
                valimprumut = suma;
                for(int i=1;i<=perioada;i++)
                {
                    valdobanda = valimprumut * rata;
                    amortisment = anuitate - valdobanda;
                    valramasa = valimprumut - amortisment;
                    listBox1.Items.Add("pentru luna " + i + " rata este " + anuitate+" valoarea ramasa este "+valramasa);
                    valimprumut = valramasa;
                }
            }
            else
            {
                amortisment = Math.Round(suma  /perioada, 1);
                valimprumut = suma;
                int i = 1;
                while(i<=perioada)
                {
                    valdobanda = valimprumut * rata;
                    anuitate = amortisment + valdobanda;
                    valramasa = valimprumut - amortisment;
                    listBox1.Items.Add("pentru luna " + i + " rata este " + anuitate + " valoarea ramasa este " + valramasa);
                    valimprumut = valramasa;
                    i++;
                }
            }
        }

        private void btninchidere_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            optLei.Checked = true;
            optAnuitati.Checked = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            optLei.Checked = true;
            optAnuitati.Checked = true;
            listBox1.Items.Clear();
            txtSuma.Text = "";
            numPerioada.Value = 1;
            cboRata.SelectedIndex = -1;
        }
    }
}
