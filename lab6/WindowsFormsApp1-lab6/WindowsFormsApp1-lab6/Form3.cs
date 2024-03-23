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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRevenire_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            chart1.DataSource = Form1.date;
            chart1.Series.Clear();
            chart1.Series.Add("Import");
            chart1.Series.Add("Export");
            for (int i = 0; i < 11; i++)
            {
                chart1.Series["Import"].Points.AddXY(Convert.ToInt32(Form1.date[i, 0]), Convert.ToDouble(Form1.date[i, 1]));
                chart1.Series["Export"].Points.AddXY(Convert.ToInt32(Form1.date[i, 0]), Convert.ToDouble(Form1.date[i, 2]));
            }
            chart1.Titles.Add("Evolutie comparativa import-export intre anii 2012-2022");
            chart1.Series["Import"].IsValueShownAsLabel = true;
            chart1.Series["Export"].IsValueShownAsLabel = true;
        }
    }
}
