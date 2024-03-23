
namespace WindowsFormsApp2
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
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnr = new System.Windows.Forms.TextBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerare
            // 
            this.btnGenerare.Location = new System.Drawing.Point(513, 55);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(106, 49);
            this.btnGenerare.TabIndex = 0;
            this.btnGenerare.Text = "generare";
            this.btnGenerare.UseVisualStyleBackColor = true;
            this.btnGenerare.Click += new System.EventHandler(this.btnGenerare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(513, 122);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(106, 49);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "nr elemente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "valoare element";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // txtnr
            // 
            this.txtnr.Location = new System.Drawing.Point(183, 55);
            this.txtnr.Name = "txtnr";
            this.txtnr.Size = new System.Drawing.Size(100, 22);
            this.txtnr.TabIndex = 5;
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(183, 129);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(100, 22);
            this.txtVal.TabIndex = 6;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(513, 197);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(106, 49);
            this.btnAfisare.TabIndex = 7;
            this.btnAfisare.Text = "afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(513, 264);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(106, 49);
            this.min.TabIndex = 8;
            this.min.Text = "min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(513, 338);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(106, 49);
            this.btnMax.TabIndex = 9;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.min);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.txtnr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.btnGenerare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnr;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label label4;
    }
}

