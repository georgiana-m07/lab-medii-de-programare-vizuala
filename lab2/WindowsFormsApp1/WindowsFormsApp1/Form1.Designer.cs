
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optEuro = new System.Windows.Forms.RadioButton();
            this.optLei = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optAmortisment = new System.Windows.Forms.RadioButton();
            this.optAnuitati = new System.Windows.Forms.RadioButton();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btninchidere = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numPerioada = new System.Windows.Forms.NumericUpDown();
            this.cboRata = new System.Windows.Forms.ComboBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPerioada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma imprumutata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "perioada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "rata dobanzii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "luni";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optEuro);
            this.groupBox1.Controls.Add(this.optLei);
            this.groupBox1.Location = new System.Drawing.Point(463, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "moneda";
            // 
            // optEuro
            // 
            this.optEuro.AutoSize = true;
            this.optEuro.Location = new System.Drawing.Point(17, 49);
            this.optEuro.Name = "optEuro";
            this.optEuro.Size = new System.Drawing.Size(59, 21);
            this.optEuro.TabIndex = 1;
            this.optEuro.TabStop = true;
            this.optEuro.Text = "Euro";
            this.optEuro.UseVisualStyleBackColor = true;
            this.optEuro.CheckedChanged += new System.EventHandler(this.optEuro_CheckedChanged);
            // 
            // optLei
            // 
            this.optLei.AutoSize = true;
            this.optLei.Location = new System.Drawing.Point(17, 22);
            this.optLei.Name = "optLei";
            this.optLei.Size = new System.Drawing.Size(43, 21);
            this.optLei.TabIndex = 0;
            this.optLei.TabStop = true;
            this.optLei.Text = "lei";
            this.optLei.UseVisualStyleBackColor = true;
            this.optLei.CheckedChanged += new System.EventHandler(this.optLei_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optAmortisment);
            this.groupBox2.Controls.Add(this.optAnuitati);
            this.groupBox2.Location = new System.Drawing.Point(721, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "metoda de rambursare";
            // 
            // optAmortisment
            // 
            this.optAmortisment.AutoSize = true;
            this.optAmortisment.Location = new System.Drawing.Point(17, 49);
            this.optAmortisment.Name = "optAmortisment";
            this.optAmortisment.Size = new System.Drawing.Size(181, 21);
            this.optAmortisment.TabIndex = 1;
            this.optAmortisment.TabStop = true;
            this.optAmortisment.Text = "Amortismente constante";
            this.optAmortisment.UseVisualStyleBackColor = true;
            // 
            // optAnuitati
            // 
            this.optAnuitati.AutoSize = true;
            this.optAnuitati.Location = new System.Drawing.Point(17, 22);
            this.optAnuitati.Name = "optAnuitati";
            this.optAnuitati.Size = new System.Drawing.Size(141, 21);
            this.optAnuitati.TabIndex = 0;
            this.optAnuitati.TabStop = true;
            this.optAnuitati.Text = "anuitati constante";
            this.optAnuitati.UseVisualStyleBackColor = true;
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(986, 40);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(102, 41);
            this.btnCalcul.TabIndex = 6;
            this.btnCalcul.Text = "calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(986, 86);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 41);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btninchidere
            // 
            this.btninchidere.Location = new System.Drawing.Point(986, 132);
            this.btninchidere.Name = "btninchidere";
            this.btninchidere.Size = new System.Drawing.Size(102, 41);
            this.btninchidere.TabIndex = 8;
            this.btninchidere.Text = "inchidere";
            this.btninchidere.UseVisualStyleBackColor = true;
            this.btninchidere.Click += new System.EventHandler(this.btninchidere_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(57, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(864, 212);
            this.listBox1.TabIndex = 9;
            // 
            // numPerioada
            // 
            this.numPerioada.Location = new System.Drawing.Point(211, 90);
            this.numPerioada.Name = "numPerioada";
            this.numPerioada.Size = new System.Drawing.Size(120, 22);
            this.numPerioada.TabIndex = 10;
            // 
            // cboRata
            // 
            this.cboRata.FormattingEnabled = true;
            this.cboRata.Location = new System.Drawing.Point(211, 129);
            this.cboRata.Name = "cboRata";
            this.cboRata.Size = new System.Drawing.Size(121, 24);
            this.cboRata.TabIndex = 11;
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(211, 47);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 22);
            this.txtSuma.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 450);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.cboRata);
            this.Controls.Add(this.numPerioada);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btninchidere);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPerioada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optEuro;
        private System.Windows.Forms.RadioButton optLei;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optAmortisment;
        private System.Windows.Forms.RadioButton optAnuitati;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btninchidere;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numPerioada;
        private System.Windows.Forms.ComboBox cboRata;
        private System.Windows.Forms.TextBox txtSuma;
    }
}

