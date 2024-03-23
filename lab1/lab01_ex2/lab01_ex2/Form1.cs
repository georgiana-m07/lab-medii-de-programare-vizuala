using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ascundere controale
            lblValAmortizare.Visible = false;
            txtValAmortizare.Visible = false;
            btnAdaugare.Visible = false;
            lstRezultate.Visible = false;
            //Dezactiveaza proprietatea de editare a textboxului
            txtValAmortizare.Enabled = false;


        }

        private void btncalcul_Click(object sender, EventArgs e)
        {
            //declarare variabile
            double vi, durata, amortizare;
            //atribuit variabilelor valori din textbox 
            vi = Convert.ToDouble(txtValIntrare.Text);
            durata = Convert.ToDouble(txtDNU.Text);
            //calcul amortizare
            amortizare = Math.Round(vi / (durata*12),2);
            //afisare amortizarea in textbox, conversie din double in string 
            txtValAmortizare.Text = amortizare.ToString();
            //afisare controale in forma
            lblValAmortizare.Visible = true;
            txtValAmortizare.Visible = true;
            btnAdaugare.Visible = true;
            lstRezultate.Visible = true;



        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            //declarat si intializat variabila element
            string element = txtDenMijlocFix.Text + " " + txtValIntrare.Text + " " + txtDNU.Text + " " + txtValAmortizare.Text;
            //Am adaugat continutul variabilei element in listbox
            lstRezultate.Items.Add(element);
            
            //Golit continutul textboxuriloe
            txtDenMijlocFix.Text = "";
            txtDNU.Clear();
            txtValIntrare.Clear();
            //Ascundere controale
            txtValAmortizare.Visible = false;
            lblValAmortizare.Visible = false;
            btnAdaugare.Visible = false;

            
        }
    }
}
