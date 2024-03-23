
namespace WindowsFormsApp1_lab9
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
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnInserare = new System.Windows.Forms.Button();
            this.btnVizualizare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(71, 50);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(206, 54);
            this.btnCautare.TabIndex = 0;
            this.btnCautare.Text = "Cautare";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // btnInserare
            // 
            this.btnInserare.Location = new System.Drawing.Point(71, 146);
            this.btnInserare.Name = "btnInserare";
            this.btnInserare.Size = new System.Drawing.Size(206, 54);
            this.btnInserare.TabIndex = 1;
            this.btnInserare.Text = "Inserare";
            this.btnInserare.UseVisualStyleBackColor = true;
            this.btnInserare.Click += new System.EventHandler(this.btnInserare_Click);
            // 
            // btnVizualizare
            // 
            this.btnVizualizare.Location = new System.Drawing.Point(71, 241);
            this.btnVizualizare.Name = "btnVizualizare";
            this.btnVizualizare.Size = new System.Drawing.Size(206, 54);
            this.btnVizualizare.TabIndex = 2;
            this.btnVizualizare.Text = "Vizualizare";
            this.btnVizualizare.UseVisualStyleBackColor = true;
            this.btnVizualizare.Click += new System.EventHandler(this.btnVizualizare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 385);
            this.Controls.Add(this.btnVizualizare);
            this.Controls.Add(this.btnInserare);
            this.Controls.Add(this.btnCautare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Button btnInserare;
        private System.Windows.Forms.Button btnVizualizare;
    }
}

