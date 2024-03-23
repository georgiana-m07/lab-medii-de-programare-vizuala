
namespace WindowsFormsApp1_lab6
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
            this.btnAfisListView = new System.Windows.Forms.Button();
            this.btnAfisGrafic = new System.Windows.Forms.Button();
            this.btnInchidere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfisListView
            // 
            this.btnAfisListView.Location = new System.Drawing.Point(54, 39);
            this.btnAfisListView.Name = "btnAfisListView";
            this.btnAfisListView.Size = new System.Drawing.Size(118, 59);
            this.btnAfisListView.TabIndex = 0;
            this.btnAfisListView.Text = "Afisare ListView";
            this.btnAfisListView.UseVisualStyleBackColor = true;
            this.btnAfisListView.Click += new System.EventHandler(this.btnAfisListView_Click);
            // 
            // btnAfisGrafic
            // 
            this.btnAfisGrafic.Location = new System.Drawing.Point(247, 39);
            this.btnAfisGrafic.Name = "btnAfisGrafic";
            this.btnAfisGrafic.Size = new System.Drawing.Size(125, 59);
            this.btnAfisGrafic.TabIndex = 1;
            this.btnAfisGrafic.Text = "Afisare grafic";
            this.btnAfisGrafic.UseVisualStyleBackColor = true;
            this.btnAfisGrafic.Click += new System.EventHandler(this.btnAfisGrafic_Click);
            // 
            // btnInchidere
            // 
            this.btnInchidere.Location = new System.Drawing.Point(663, 379);
            this.btnInchidere.Name = "btnInchidere";
            this.btnInchidere.Size = new System.Drawing.Size(125, 59);
            this.btnInchidere.TabIndex = 2;
            this.btnInchidere.Text = "Inchidere";
            this.btnInchidere.UseVisualStyleBackColor = true;
            this.btnInchidere.Click += new System.EventHandler(this.btnInchidere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInchidere);
            this.Controls.Add(this.btnAfisGrafic);
            this.Controls.Add(this.btnAfisListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfisListView;
        private System.Windows.Forms.Button btnAfisGrafic;
        private System.Windows.Forms.Button btnInchidere;
    }
}

