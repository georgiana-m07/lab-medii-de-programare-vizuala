
namespace lab01_ex2
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
            this.lblMijloc = new System.Windows.Forms.Label();
            this.lblDNU = new System.Windows.Forms.Label();
            this.lblValIntrare = new System.Windows.Forms.Label();
            this.lblValAmortizare = new System.Windows.Forms.Label();
            this.txtDenMijlocFix = new System.Windows.Forms.TextBox();
            this.txtDNU = new System.Windows.Forms.TextBox();
            this.txtValIntrare = new System.Windows.Forms.TextBox();
            this.txtValAmortizare = new System.Windows.Forms.TextBox();
            this.btncalcul = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.lstRezultate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblMijloc
            // 
            this.lblMijloc.AutoSize = true;
            this.lblMijloc.Location = new System.Drawing.Point(52, 40);
            this.lblMijloc.Name = "lblMijloc";
            this.lblMijloc.Size = new System.Drawing.Size(140, 20);
            this.lblMijloc.TabIndex = 0;
            this.lblMijloc.Text = "Denumire mijloc fix";
            // 
            // lblDNU
            // 
            this.lblDNU.AutoSize = true;
            this.lblDNU.Location = new System.Drawing.Point(49, 72);
            this.lblDNU.Name = "lblDNU";
            this.lblDNU.Size = new System.Drawing.Size(199, 20);
            this.lblDNU.TabIndex = 1;
            this.lblDNU.Text = "Durata normala de utilizare";
            // 
            // lblValIntrare
            // 
            this.lblValIntrare.AutoSize = true;
            this.lblValIntrare.Location = new System.Drawing.Point(52, 106);
            this.lblValIntrare.Name = "lblValIntrare";
            this.lblValIntrare.Size = new System.Drawing.Size(135, 20);
            this.lblValIntrare.TabIndex = 2;
            this.lblValIntrare.Text = "Valoare de intrare";
            // 
            // lblValAmortizare
            // 
            this.lblValAmortizare.AutoSize = true;
            this.lblValAmortizare.Location = new System.Drawing.Point(52, 144);
            this.lblValAmortizare.Name = "lblValAmortizare";
            this.lblValAmortizare.Size = new System.Drawing.Size(191, 20);
            this.lblValAmortizare.TabIndex = 3;
            this.lblValAmortizare.Text = "Valoare amortizare lunara";
            // 
            // txtDenMijlocFix
            // 
            this.txtDenMijlocFix.Location = new System.Drawing.Point(277, 40);
            this.txtDenMijlocFix.Name = "txtDenMijlocFix";
            this.txtDenMijlocFix.Size = new System.Drawing.Size(100, 26);
            this.txtDenMijlocFix.TabIndex = 4;
            // 
            // txtDNU
            // 
            this.txtDNU.Location = new System.Drawing.Point(277, 72);
            this.txtDNU.Name = "txtDNU";
            this.txtDNU.Size = new System.Drawing.Size(100, 26);
            this.txtDNU.TabIndex = 5;
            // 
            // txtValIntrare
            // 
            this.txtValIntrare.Location = new System.Drawing.Point(277, 106);
            this.txtValIntrare.Name = "txtValIntrare";
            this.txtValIntrare.Size = new System.Drawing.Size(100, 26);
            this.txtValIntrare.TabIndex = 6;
            // 
            // txtValAmortizare
            // 
            this.txtValAmortizare.Location = new System.Drawing.Point(277, 141);
            this.txtValAmortizare.Name = "txtValAmortizare";
            this.txtValAmortizare.Size = new System.Drawing.Size(100, 26);
            this.txtValAmortizare.TabIndex = 7;
            // 
            // btncalcul
            // 
            this.btncalcul.Location = new System.Drawing.Point(421, 61);
            this.btncalcul.Name = "btncalcul";
            this.btncalcul.Size = new System.Drawing.Size(75, 42);
            this.btncalcul.TabIndex = 8;
            this.btncalcul.Text = "Calcul";
            this.btncalcul.UseVisualStyleBackColor = true;
            this.btncalcul.Click += new System.EventHandler(this.btncalcul_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(421, 131);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 47);
            this.btnAdaugare.TabIndex = 9;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // lstRezultate
            // 
            this.lstRezultate.FormattingEnabled = true;
            this.lstRezultate.ItemHeight = 20;
            this.lstRezultate.Location = new System.Drawing.Point(56, 234);
            this.lstRezultate.Name = "lstRezultate";
            this.lstRezultate.Size = new System.Drawing.Size(596, 184);
            this.lstRezultate.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstRezultate);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.btncalcul);
            this.Controls.Add(this.txtValAmortizare);
            this.Controls.Add(this.txtValIntrare);
            this.Controls.Add(this.txtDNU);
            this.Controls.Add(this.txtDenMijlocFix);
            this.Controls.Add(this.lblValAmortizare);
            this.Controls.Add(this.lblValIntrare);
            this.Controls.Add(this.lblDNU);
            this.Controls.Add(this.lblMijloc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMijloc;
        private System.Windows.Forms.Label lblDNU;
        private System.Windows.Forms.Label lblValIntrare;
        private System.Windows.Forms.Label lblValAmortizare;
        private System.Windows.Forms.TextBox txtDenMijlocFix;
        private System.Windows.Forms.TextBox txtDNU;
        private System.Windows.Forms.TextBox txtValIntrare;
        private System.Windows.Forms.TextBox txtValAmortizare;
        private System.Windows.Forms.Button btncalcul;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.ListBox lstRezultate;
    }
}

