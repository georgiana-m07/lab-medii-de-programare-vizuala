
namespace lab14_bilet_ex
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produseDataSet1 = new lab14_bilet_ex.produseDataSet1();
            this.produseTableAdapter = new lab14_bilet_ex.produseDataSet1TableAdapters.produseTableAdapter();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btnVector = new System.Windows.Forms.Button();
            this.btnValmedie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codprodDataGridViewTextBoxColumn,
            this.denprodDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.cantDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // codprodDataGridViewTextBoxColumn
            // 
            this.codprodDataGridViewTextBoxColumn.DataPropertyName = "cod_prod";
            this.codprodDataGridViewTextBoxColumn.HeaderText = "cod_prod";
            this.codprodDataGridViewTextBoxColumn.Name = "codprodDataGridViewTextBoxColumn";
            // 
            // denprodDataGridViewTextBoxColumn
            // 
            this.denprodDataGridViewTextBoxColumn.DataPropertyName = "den_prod";
            this.denprodDataGridViewTextBoxColumn.HeaderText = "den_prod";
            this.denprodDataGridViewTextBoxColumn.Name = "denprodDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // cantDataGridViewTextBoxColumn
            // 
            this.cantDataGridViewTextBoxColumn.DataPropertyName = "cant";
            this.cantDataGridViewTextBoxColumn.HeaderText = "cant";
            this.cantDataGridViewTextBoxColumn.Name = "cantDataGridViewTextBoxColumn";
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "produse";
            this.produseBindingSource.DataSource = this.produseDataSet1;
            // 
            // produseDataSet1
            // 
            this.produseDataSet1.DataSetName = "produseDataSet1";
            this.produseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Location = new System.Drawing.Point(12, 246);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(142, 51);
            this.btnInregistrare.TabIndex = 1;
            this.btnInregistrare.Text = "Inregistrare produs nou";
            this.btnInregistrare.UseVisualStyleBackColor = true;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // btnVector
            // 
            this.btnVector.Location = new System.Drawing.Point(218, 246);
            this.btnVector.Name = "btnVector";
            this.btnVector.Size = new System.Drawing.Size(142, 51);
            this.btnVector.TabIndex = 2;
            this.btnVector.Text = "Pret in vector";
            this.btnVector.UseVisualStyleBackColor = true;
            this.btnVector.Click += new System.EventHandler(this.btnVector_Click);
            // 
            // btnValmedie
            // 
            this.btnValmedie.Location = new System.Drawing.Point(419, 246);
            this.btnValmedie.Name = "btnValmedie";
            this.btnValmedie.Size = new System.Drawing.Size(142, 51);
            this.btnValmedie.TabIndex = 3;
            this.btnValmedie.Text = "Valoare medie";
            this.btnValmedie.UseVisualStyleBackColor = true;
            this.btnValmedie.Click += new System.EventHandler(this.btnValmedie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValmedie);
            this.Controls.Add(this.btnVector);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private produseDataSet1 produseDataSet1;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private produseDataSet1TableAdapters.produseTableAdapter produseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Button btnVector;
        private System.Windows.Forms.Button btnValmedie;
        private System.Windows.Forms.Label label1;
    }
}

