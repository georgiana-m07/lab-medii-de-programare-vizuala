
namespace WindowsFormsApp1_lab6
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optListView = new System.Windows.Forms.RadioButton();
            this.optDataGridView = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRevenire
            // 
            this.btnRevenire.Location = new System.Drawing.Point(47, 342);
            this.btnRevenire.Name = "btnRevenire";
            this.btnRevenire.Size = new System.Drawing.Size(154, 60);
            this.btnRevenire.TabIndex = 0;
            this.btnRevenire.Text = "Revenire";
            this.btnRevenire.UseVisualStyleBackColor = true;
            this.btnRevenire.Click += new System.EventHandler(this.btnRevenire_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(311, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(397, 291);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(783, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 290);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optDataGridView);
            this.groupBox1.Controls.Add(this.optListView);
            this.groupBox1.Location = new System.Drawing.Point(47, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optiuni";
            // 
            // optListView
            // 
            this.optListView.AutoSize = true;
            this.optListView.Location = new System.Drawing.Point(16, 28);
            this.optListView.Name = "optListView";
            this.optListView.Size = new System.Drawing.Size(64, 17);
            this.optListView.TabIndex = 0;
            this.optListView.TabStop = true;
            this.optListView.Text = "ListView";
            this.optListView.UseVisualStyleBackColor = true;
            this.optListView.CheckedChanged += new System.EventHandler(this.optListView_CheckedChanged);
            // 
            // optDataGridView
            // 
            this.optDataGridView.AutoSize = true;
            this.optDataGridView.Location = new System.Drawing.Point(16, 63);
            this.optDataGridView.Name = "optDataGridView";
            this.optDataGridView.Size = new System.Drawing.Size(90, 17);
            this.optDataGridView.TabIndex = 1;
            this.optDataGridView.TabStop = true;
            this.optDataGridView.Text = "DataGridView";
            this.optDataGridView.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRevenire);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRevenire;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optDataGridView;
        private System.Windows.Forms.RadioButton optListView;
    }
}