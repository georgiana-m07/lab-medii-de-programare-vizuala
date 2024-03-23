
namespace WindowsFormsApp5
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
            this.btnGenerare = new System.Windows.Forms.Button();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLinii = new System.Windows.Forms.TextBox();
            this.txtColoane = new System.Windows.Forms.TextBox();
            this.cboOpt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerare
            // 
            this.btnGenerare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerare.Location = new System.Drawing.Point(93, 185);
            this.btnGenerare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(205, 47);
            this.btnGenerare.TabIndex = 0;
            this.btnGenerare.Text = "Generare";
            this.btnGenerare.UseVisualStyleBackColor = true;
            this.btnGenerare.Click += new System.EventHandler(this.btnGenerare_Click);
            // 
            // btnCalcul
            // 
            this.btnCalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcul.Location = new System.Drawing.Point(93, 315);
            this.btnCalcul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(205, 47);
            this.btnCalcul.TabIndex = 1;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nr linii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nr coloane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // txtLinii
            // 
            this.txtLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinii.Location = new System.Drawing.Point(194, 33);
            this.txtLinii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLinii.Name = "txtLinii";
            this.txtLinii.Size = new System.Drawing.Size(104, 31);
            this.txtLinii.TabIndex = 5;
            // 
            // txtColoane
            // 
            this.txtColoane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColoane.Location = new System.Drawing.Point(194, 89);
            this.txtColoane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColoane.Name = "txtColoane";
            this.txtColoane.Size = new System.Drawing.Size(104, 31);
            this.txtColoane.TabIndex = 6;
            // 
            // cboOpt
            // 
            this.cboOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOpt.FormattingEnabled = true;
            this.cboOpt.Items.AddRange(new object[] {
            "suma elemetelor",
            "minimul pe linie",
            "maximul pe coloana",
            "suma elementelor de pe diagonala principala",
            "suma elementelor aflate deaspra diagonalei principale"});
            this.cboOpt.Location = new System.Drawing.Point(93, 264);
            this.cboOpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboOpt.Name = "cboOpt";
            this.cboOpt.Size = new System.Drawing.Size(206, 33);
            this.cboOpt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 459);
            this.Controls.Add(this.cboOpt);
            this.Controls.Add(this.txtColoane);
            this.Controls.Add(this.txtLinii);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.btnGenerare);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerare;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLinii;
        private System.Windows.Forms.TextBox txtColoane;
        private System.Windows.Forms.ComboBox cboOpt;
    }
}

