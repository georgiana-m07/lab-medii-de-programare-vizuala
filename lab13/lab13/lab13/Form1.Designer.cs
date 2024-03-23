
namespace lab13
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
            this.btnAfisareMesaj = new System.Windows.Forms.Button();
            this.btnF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfisareMesaj
            // 
            this.btnAfisareMesaj.Location = new System.Drawing.Point(63, 51);
            this.btnAfisareMesaj.Name = "btnAfisareMesaj";
            this.btnAfisareMesaj.Size = new System.Drawing.Size(150, 50);
            this.btnAfisareMesaj.TabIndex = 0;
            this.btnAfisareMesaj.Text = "Afisare mesaj";
            this.btnAfisareMesaj.UseVisualStyleBackColor = true;
            this.btnAfisareMesaj.Click += new System.EventHandler(this.btnAfisareMesaj_Click);
            // 
            // btnF2
            // 
            this.btnF2.Location = new System.Drawing.Point(63, 120);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(150, 50);
            this.btnF2.TabIndex = 1;
            this.btnF2.Text = "Form2";
            this.btnF2.UseVisualStyleBackColor = true;
            this.btnF2.Click += new System.EventHandler(this.btnF2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 205);
            this.Controls.Add(this.btnF2);
            this.Controls.Add(this.btnAfisareMesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfisareMesaj;
        private System.Windows.Forms.Button btnF2;
    }
}

