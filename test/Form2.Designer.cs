namespace test
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOut1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOut2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vOut3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRef1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vRef2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbtestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new test.Database1DataSet1();
            this.dbtestTableAdapter = new test.Database1DataSet1TableAdapters.dbtestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(818, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.humidityDataGridViewTextBoxColumn,
            this.v1DataGridViewTextBoxColumn,
            this.v2DataGridViewTextBoxColumn,
            this.v3DataGridViewTextBoxColumn,
            this.v4DataGridViewTextBoxColumn,
            this.v5DataGridViewTextBoxColumn,
            this.v6DataGridViewTextBoxColumn,
            this.v7DataGridViewTextBoxColumn,
            this.v8DataGridViewTextBoxColumn,
            this.v9DataGridViewTextBoxColumn,
            this.vOut1DataGridViewTextBoxColumn,
            this.vOut2DataGridViewTextBoxColumn,
            this.vOut3DataGridViewTextBoxColumn,
            this.vRef1DataGridViewTextBoxColumn,
            this.vRef2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dbtestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 396);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "Humidity";
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            // 
            // v1DataGridViewTextBoxColumn
            // 
            this.v1DataGridViewTextBoxColumn.DataPropertyName = "V1";
            this.v1DataGridViewTextBoxColumn.HeaderText = "V1";
            this.v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            // 
            // v2DataGridViewTextBoxColumn
            // 
            this.v2DataGridViewTextBoxColumn.DataPropertyName = "V2";
            this.v2DataGridViewTextBoxColumn.HeaderText = "V2";
            this.v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
            // 
            // v3DataGridViewTextBoxColumn
            // 
            this.v3DataGridViewTextBoxColumn.DataPropertyName = "V3";
            this.v3DataGridViewTextBoxColumn.HeaderText = "V3";
            this.v3DataGridViewTextBoxColumn.Name = "v3DataGridViewTextBoxColumn";
            // 
            // v4DataGridViewTextBoxColumn
            // 
            this.v4DataGridViewTextBoxColumn.DataPropertyName = "V4";
            this.v4DataGridViewTextBoxColumn.HeaderText = "V4";
            this.v4DataGridViewTextBoxColumn.Name = "v4DataGridViewTextBoxColumn";
            // 
            // v5DataGridViewTextBoxColumn
            // 
            this.v5DataGridViewTextBoxColumn.DataPropertyName = "V5";
            this.v5DataGridViewTextBoxColumn.HeaderText = "V5";
            this.v5DataGridViewTextBoxColumn.Name = "v5DataGridViewTextBoxColumn";
            // 
            // v6DataGridViewTextBoxColumn
            // 
            this.v6DataGridViewTextBoxColumn.DataPropertyName = "V6";
            this.v6DataGridViewTextBoxColumn.HeaderText = "V6";
            this.v6DataGridViewTextBoxColumn.Name = "v6DataGridViewTextBoxColumn";
            // 
            // v7DataGridViewTextBoxColumn
            // 
            this.v7DataGridViewTextBoxColumn.DataPropertyName = "V7";
            this.v7DataGridViewTextBoxColumn.HeaderText = "V7";
            this.v7DataGridViewTextBoxColumn.Name = "v7DataGridViewTextBoxColumn";
            // 
            // v8DataGridViewTextBoxColumn
            // 
            this.v8DataGridViewTextBoxColumn.DataPropertyName = "V8";
            this.v8DataGridViewTextBoxColumn.HeaderText = "V8";
            this.v8DataGridViewTextBoxColumn.Name = "v8DataGridViewTextBoxColumn";
            // 
            // v9DataGridViewTextBoxColumn
            // 
            this.v9DataGridViewTextBoxColumn.DataPropertyName = "V9";
            this.v9DataGridViewTextBoxColumn.HeaderText = "V9";
            this.v9DataGridViewTextBoxColumn.Name = "v9DataGridViewTextBoxColumn";
            // 
            // vOut1DataGridViewTextBoxColumn
            // 
            this.vOut1DataGridViewTextBoxColumn.DataPropertyName = "VOut1";
            this.vOut1DataGridViewTextBoxColumn.HeaderText = "VOut1";
            this.vOut1DataGridViewTextBoxColumn.Name = "vOut1DataGridViewTextBoxColumn";
            // 
            // vOut2DataGridViewTextBoxColumn
            // 
            this.vOut2DataGridViewTextBoxColumn.DataPropertyName = "VOut2";
            this.vOut2DataGridViewTextBoxColumn.HeaderText = "VOut2";
            this.vOut2DataGridViewTextBoxColumn.Name = "vOut2DataGridViewTextBoxColumn";
            // 
            // vOut3DataGridViewTextBoxColumn
            // 
            this.vOut3DataGridViewTextBoxColumn.DataPropertyName = "VOut3";
            this.vOut3DataGridViewTextBoxColumn.HeaderText = "VOut3";
            this.vOut3DataGridViewTextBoxColumn.Name = "vOut3DataGridViewTextBoxColumn";
            // 
            // vRef1DataGridViewTextBoxColumn
            // 
            this.vRef1DataGridViewTextBoxColumn.DataPropertyName = "VRef1";
            this.vRef1DataGridViewTextBoxColumn.HeaderText = "VRef1";
            this.vRef1DataGridViewTextBoxColumn.Name = "vRef1DataGridViewTextBoxColumn";
            // 
            // vRef2DataGridViewTextBoxColumn
            // 
            this.vRef2DataGridViewTextBoxColumn.DataPropertyName = "VRef2";
            this.vRef2DataGridViewTextBoxColumn.HeaderText = "VRef2";
            this.vRef2DataGridViewTextBoxColumn.Name = "vRef2DataGridViewTextBoxColumn";
            // 
            // dbtestBindingSource
            // 
            this.dbtestBindingSource.DataMember = "dbtest";
            this.dbtestBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbtestTableAdapter
            // 
            this.dbtestTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 420);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Name = "Form2";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource dbtestBindingSource;
        private Database1DataSet1TableAdapters.dbtestTableAdapter dbtestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOut1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOut2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vOut3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vRef1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vRef2DataGridViewTextBoxColumn;
    }
}