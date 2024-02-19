namespace Радченко
{
    partial class Stydents
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radchenko_Ychot_rabotDataSet = new Радченко.Radchenko_Ychot_rabotDataSet();
            this.stydentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stydentiTableAdapter = new Радченко.Radchenko_Ychot_rabotDataSetTableAdapters.StydentiTableAdapter();
            this.kodstudentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gryppaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapostypleniyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radchenko_Ychot_rabotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stydentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodstudentaDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.gryppaDataGridViewTextBoxColumn,
            this.datapostypleniyaDataGridViewTextBoxColumn,
            this.kyrsDataGridViewTextBoxColumn,
            this.specialnostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stydentiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 495);
            this.dataGridView1.TabIndex = 2;
            // 
            // radchenko_Ychot_rabotDataSet
            // 
            this.radchenko_Ychot_rabotDataSet.DataSetName = "Radchenko_Ychot_rabotDataSet";
            this.radchenko_Ychot_rabotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stydentiBindingSource
            // 
            this.stydentiBindingSource.DataMember = "Stydenti";
            this.stydentiBindingSource.DataSource = this.radchenko_Ychot_rabotDataSet;
            // 
            // stydentiTableAdapter
            // 
            this.stydentiTableAdapter.ClearBeforeFill = true;
            // 
            // kodstudentaDataGridViewTextBoxColumn
            // 
            this.kodstudentaDataGridViewTextBoxColumn.DataPropertyName = "Kod_studenta";
            this.kodstudentaDataGridViewTextBoxColumn.HeaderText = "Kod_studenta";
            this.kodstudentaDataGridViewTextBoxColumn.Name = "kodstudentaDataGridViewTextBoxColumn";
            this.kodstudentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "Birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "Birth";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            // 
            // gryppaDataGridViewTextBoxColumn
            // 
            this.gryppaDataGridViewTextBoxColumn.DataPropertyName = "Gryppa";
            this.gryppaDataGridViewTextBoxColumn.HeaderText = "Gryppa";
            this.gryppaDataGridViewTextBoxColumn.Name = "gryppaDataGridViewTextBoxColumn";
            // 
            // datapostypleniyaDataGridViewTextBoxColumn
            // 
            this.datapostypleniyaDataGridViewTextBoxColumn.DataPropertyName = "Data_postypleniya";
            this.datapostypleniyaDataGridViewTextBoxColumn.HeaderText = "Data_postypleniya";
            this.datapostypleniyaDataGridViewTextBoxColumn.Name = "datapostypleniyaDataGridViewTextBoxColumn";
            // 
            // kyrsDataGridViewTextBoxColumn
            // 
            this.kyrsDataGridViewTextBoxColumn.DataPropertyName = "Kyrs";
            this.kyrsDataGridViewTextBoxColumn.HeaderText = "Kyrs";
            this.kyrsDataGridViewTextBoxColumn.Name = "kyrsDataGridViewTextBoxColumn";
            // 
            // specialnostDataGridViewTextBoxColumn
            // 
            this.specialnostDataGridViewTextBoxColumn.DataPropertyName = "Specialnost";
            this.specialnostDataGridViewTextBoxColumn.HeaderText = "Specialnost";
            this.specialnostDataGridViewTextBoxColumn.Name = "specialnostDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(327, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Stydents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stydents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stydents";
            this.Load += new System.EventHandler(this.Stydents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radchenko_Ychot_rabotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stydentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Radchenko_Ychot_rabotDataSet radchenko_Ychot_rabotDataSet;
        private System.Windows.Forms.BindingSource stydentiBindingSource;
        private Radchenko_Ychot_rabotDataSetTableAdapters.StydentiTableAdapter stydentiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodstudentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gryppaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapostypleniyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}