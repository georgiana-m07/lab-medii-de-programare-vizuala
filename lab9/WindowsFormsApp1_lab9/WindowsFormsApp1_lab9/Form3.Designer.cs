
namespace WindowsFormsApp1_lab9
{
    partial class Form3
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
            this.btnRevenire = new System.Windows.Forms.Button();
            this.lblNumefloare = new System.Windows.Forms.Label();
            this.lblPretU = new System.Windows.Forms.Label();
            this.txt_nume = new System.Windows.Forms.TextBox();
            this.txt_pret = new System.Windows.Forms.TextBox();
            this.btnInserare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRevenire
            // 
            this.btnRevenire.Location = new System.Drawing.Point(373, 287);
            this.btnRevenire.Name = "btnRevenire";
            this.btnRevenire.Size = new System.Drawing.Size(162, 47);
            this.btnRevenire.TabIndex = 0;
            this.btnRevenire.Text = "Revenire";
            this.btnRevenire.UseVisualStyleBackColor = true;
            this.btnRevenire.Click += new System.EventHandler(this.btnRevenire_Click);
            // 
            // lblNumefloare
            // 
            this.lblNumefloare.AutoSize = true;
            this.lblNumefloare.Location = new System.Drawing.Point(42, 46);
            this.lblNumefloare.Name = "lblNumefloare";
            this.lblNumefloare.Size = new System.Drawing.Size(115, 13);
            this.lblNumefloare.TabIndex = 1;
            this.lblNumefloare.Text = "Introduceti numele florii";
            // 
            // lblPretU
            // 
            this.lblPretU.AutoSize = true;
            this.lblPretU.Location = new System.Drawing.Point(42, 108);
            this.lblPretU.Name = "lblPretU";
            this.lblPretU.Size = new System.Drawing.Size(114, 13);
            this.lblPretU.TabIndex = 2;
            this.lblPretU.Text = "introduceti pretul unitar";
            // 
            // txt_nume
            // 
            this.txt_nume.Location = new System.Drawing.Point(192, 43);
            this.txt_nume.Name = "txt_nume";
            this.txt_nume.Size = new System.Drawing.Size(150, 20);
            this.txt_nume.TabIndex = 4;
            // 
            // txt_pret
            // 
            this.txt_pret.Location = new System.Drawing.Point(192, 105);
            this.txt_pret.Name = "txt_pret";
            this.txt_pret.Size = new System.Drawing.Size(150, 20);
            this.txt_pret.TabIndex = 5;
            // 
            // btnInserare
            // 
            this.btnInserare.Location = new System.Drawing.Point(45, 165);
            this.btnInserare.Name = "btnInserare";
            this.btnInserare.Size = new System.Drawing.Size(162, 47);
            this.btnInserare.TabIndex = 6;
            this.btnInserare.Text = "Inserare";
            this.btnInserare.UseVisualStyleBackColor = true;
            this.btnInserare.Click += new System.EventHandler(this.btnInserare_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 346);
            this.Controls.Add(this.btnInserare);
            this.Controls.Add(this.txt_pret);
            this.Controls.Add(this.txt_nume);
            this.Controls.Add(this.lblPretU);
            this.Controls.Add(this.lblNumefloare);
            this.Controls.Add(this.btnRevenire);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRevenire;
        private System.Windows.Forms.Label lblNumefloare;
        private System.Windows.Forms.Label lblPretU;
        private System.Windows.Forms.TextBox txt_nume;
        private System.Windows.Forms.TextBox txt_pret;
        private System.Windows.Forms.Button btnInserare;
    }
}