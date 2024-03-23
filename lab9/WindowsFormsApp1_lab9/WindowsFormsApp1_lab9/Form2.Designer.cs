
namespace WindowsFormsApp1_lab9
{
    partial class Form2
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
            this.lblClient = new System.Windows.Forms.Label();
            this.cbo_client = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRevenire
            // 
            this.btnRevenire.Location = new System.Drawing.Point(430, 25);
            this.btnRevenire.Name = "btnRevenire";
            this.btnRevenire.Size = new System.Drawing.Size(140, 39);
            this.btnRevenire.TabIndex = 0;
            this.btnRevenire.Text = "Revenire";
            this.btnRevenire.UseVisualStyleBackColor = true;
            this.btnRevenire.Click += new System.EventHandler(this.btnRevenire_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(39, 38);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(112, 13);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Alegeti codul clientului";
            // 
            // cbo_client
            // 
            this.cbo_client.FormattingEnabled = true;
            this.cbo_client.Location = new System.Drawing.Point(180, 35);
            this.cbo_client.Name = "cbo_client";
            this.cbo_client.Size = new System.Drawing.Size(121, 21);
            this.cbo_client.TabIndex = 2;
            this.cbo_client.SelectedIndexChanged += new System.EventHandler(this.cbo_client_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(259, 157);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 346);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbo_client);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnRevenire);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRevenire;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cbo_client;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}