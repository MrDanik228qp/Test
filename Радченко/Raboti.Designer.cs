namespace Радченко
{
    partial class Raboti
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
            this.ychotrabotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ychot_rabotTableAdapter = new Радченко.Radchenko_Ychot_rabotDataSetTableAdapters.Ychot_rabotTableAdapter();
            this.rabotiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kODStidentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kODSotrudnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidrabotiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sroksdachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radchenko_Ychot_rabotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychotrabotBindingSource)).BeginInit();
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
            this.rabotiDataGridViewTextBoxColumn,
            this.kyrsDataGridViewTextBoxColumn,
            this.specialnostDataGridViewTextBoxColumn,
            this.predmetDataGridViewTextBoxColumn,
            this.kODStidentaDataGridViewTextBoxColumn,
            this.kODSotrudnikaDataGridViewTextBoxColumn,
            this.ocenkaDataGridViewTextBoxColumn,
            this.vidrabotiDataGridViewTextBoxColumn,
            this.sroksdachiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ychotrabotBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 496);
            this.dataGridView1.TabIndex = 2;
            // 
            // radchenko_Ychot_rabotDataSet
            // 
            this.radchenko_Ychot_rabotDataSet.DataSetName = "Radchenko_Ychot_rabotDataSet";
            this.radchenko_Ychot_rabotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ychotrabotBindingSource
            // 
            this.ychotrabotBindingSource.DataMember = "Ychot_rabot";
            this.ychotrabotBindingSource.DataSource = this.radchenko_Ychot_rabotDataSet;
            // 
            // ychot_rabotTableAdapter
            // 
            this.ychot_rabotTableAdapter.ClearBeforeFill = true;
            // 
            // rabotiDataGridViewTextBoxColumn
            // 
            this.rabotiDataGridViewTextBoxColumn.DataPropertyName = "№_Raboti";
            this.rabotiDataGridViewTextBoxColumn.HeaderText = "№_Raboti";
            this.rabotiDataGridViewTextBoxColumn.Name = "rabotiDataGridViewTextBoxColumn";
            this.rabotiDataGridViewTextBoxColumn.ReadOnly = true;
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
            // predmetDataGridViewTextBoxColumn
            // 
            this.predmetDataGridViewTextBoxColumn.DataPropertyName = "Predmet";
            this.predmetDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            // 
            // kODStidentaDataGridViewTextBoxColumn
            // 
            this.kODStidentaDataGridViewTextBoxColumn.DataPropertyName = "KOD_Stidenta";
            this.kODStidentaDataGridViewTextBoxColumn.HeaderText = "KOD_Stidenta";
            this.kODStidentaDataGridViewTextBoxColumn.Name = "kODStidentaDataGridViewTextBoxColumn";
            // 
            // kODSotrudnikaDataGridViewTextBoxColumn
            // 
            this.kODSotrudnikaDataGridViewTextBoxColumn.DataPropertyName = "KOD_Sotrudnika";
            this.kODSotrudnikaDataGridViewTextBoxColumn.HeaderText = "KOD_Sotrudnika";
            this.kODSotrudnikaDataGridViewTextBoxColumn.Name = "kODSotrudnikaDataGridViewTextBoxColumn";
            // 
            // ocenkaDataGridViewTextBoxColumn
            // 
            this.ocenkaDataGridViewTextBoxColumn.DataPropertyName = "Ocenka";
            this.ocenkaDataGridViewTextBoxColumn.HeaderText = "Ocenka";
            this.ocenkaDataGridViewTextBoxColumn.Name = "ocenkaDataGridViewTextBoxColumn";
            // 
            // vidrabotiDataGridViewTextBoxColumn
            // 
            this.vidrabotiDataGridViewTextBoxColumn.DataPropertyName = "Vid_raboti";
            this.vidrabotiDataGridViewTextBoxColumn.HeaderText = "Vid_raboti";
            this.vidrabotiDataGridViewTextBoxColumn.Name = "vidrabotiDataGridViewTextBoxColumn";
            // 
            // sroksdachiDataGridViewTextBoxColumn
            // 
            this.sroksdachiDataGridViewTextBoxColumn.DataPropertyName = "Srok_sdachi";
            this.sroksdachiDataGridViewTextBoxColumn.HeaderText = "Srok_sdachi";
            this.sroksdachiDataGridViewTextBoxColumn.Name = "sroksdachiDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(309, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Raboti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Raboti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raboti";
            this.Load += new System.EventHandler(this.Raboti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radchenko_Ychot_rabotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychotrabotBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Radchenko_Ychot_rabotDataSet radchenko_Ychot_rabotDataSet;
        private System.Windows.Forms.BindingSource ychotrabotBindingSource;
        private Radchenko_Ychot_rabotDataSetTableAdapters.Ychot_rabotTableAdapter ychot_rabotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabotiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODStidentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODSotrudnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidrabotiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sroksdachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}