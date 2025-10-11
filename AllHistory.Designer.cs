namespace ComplainManagementSyestem
{
    partial class AllHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllHistory));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.complainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complainManagementSystemDataSet5 = new ComplainManagementSyestem.ComplainManagementSystemDataSet5();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.complainHistoryTableAdapter = new ComplainManagementSyestem.ComplainManagementSystemDataSet5TableAdapters.ComplainHistoryTableAdapter();
            this.complainManagementSystemDataSet8 = new ComplainManagementSyestem.ComplainManagementSystemDataSet8();
            this.complaintHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complaintHistoryTableAdapter = new ComplainManagementSyestem.ComplainManagementSystemDataSet8TableAdapters.ComplaintHistoryTableAdapter();
            this.complainManagementSystemDataSet11 = new ComplainManagementSyestem.ComplainManagementSystemDataSet11();
            this.complainHistoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.complainHistoryTableAdapter1 = new ComplainManagementSyestem.ComplainManagementSystemDataSet11TableAdapters.ComplainHistoryTableAdapter();
            this.complainManagementSystemDataSet13 = new ComplainManagementSyestem.ComplainManagementSystemDataSet13();
            this.complainHistoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.complainHistoryTableAdapter2 = new ComplainManagementSyestem.ComplainManagementSystemDataSet13TableAdapters.ComplainHistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainHistoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainHistoryBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.complainIDDataGridViewTextBoxColumn,
            this.changedByDataGridViewTextBoxColumn,
            this.oldStatusDataGridViewTextBoxColumn,
            this.newStatusDataGridViewTextBoxColumn,
            this.changeDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.complainHistoryBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(163, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // complainIDDataGridViewTextBoxColumn
            // 
            this.complainIDDataGridViewTextBoxColumn.DataPropertyName = "ComplainID";
            this.complainIDDataGridViewTextBoxColumn.HeaderText = "ComplainID";
            this.complainIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.complainIDDataGridViewTextBoxColumn.Name = "complainIDDataGridViewTextBoxColumn";
            this.complainIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // changedByDataGridViewTextBoxColumn
            // 
            this.changedByDataGridViewTextBoxColumn.DataPropertyName = "ChangedBy";
            this.changedByDataGridViewTextBoxColumn.HeaderText = "ChangedBy";
            this.changedByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.changedByDataGridViewTextBoxColumn.Name = "changedByDataGridViewTextBoxColumn";
            this.changedByDataGridViewTextBoxColumn.Width = 125;
            // 
            // oldStatusDataGridViewTextBoxColumn
            // 
            this.oldStatusDataGridViewTextBoxColumn.DataPropertyName = "OldStatus";
            this.oldStatusDataGridViewTextBoxColumn.HeaderText = "OldStatus";
            this.oldStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oldStatusDataGridViewTextBoxColumn.Name = "oldStatusDataGridViewTextBoxColumn";
            this.oldStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // newStatusDataGridViewTextBoxColumn
            // 
            this.newStatusDataGridViewTextBoxColumn.DataPropertyName = "NewStatus";
            this.newStatusDataGridViewTextBoxColumn.HeaderText = "NewStatus";
            this.newStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newStatusDataGridViewTextBoxColumn.Name = "newStatusDataGridViewTextBoxColumn";
            this.newStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // changeDateDataGridViewTextBoxColumn
            // 
            this.changeDateDataGridViewTextBoxColumn.DataPropertyName = "ChangeDate";
            this.changeDateDataGridViewTextBoxColumn.HeaderText = "ChangeDate";
            this.changeDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.changeDateDataGridViewTextBoxColumn.Name = "changeDateDataGridViewTextBoxColumn";
            this.changeDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // complainHistoryBindingSource
            // 
            this.complainHistoryBindingSource.DataMember = "ComplainHistory";
            this.complainHistoryBindingSource.DataSource = this.complainManagementSystemDataSet5;
            // 
            // complainManagementSystemDataSet5
            // 
            this.complainManagementSystemDataSet5.DataSetName = "ComplainManagementSystemDataSet5";
            this.complainManagementSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Complain ID";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(622, 58);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 6;
            this.searchbtn.Text = "search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbtn.BackgroundImage")));
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backbtn.Location = new System.Drawing.Point(49, 31);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(50, 45);
            this.backbtn.TabIndex = 9;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshbtn.BackgroundImage")));
            this.refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshbtn.Location = new System.Drawing.Point(475, 500);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(45, 45);
            this.refreshbtn.TabIndex = 10;
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // complainHistoryTableAdapter
            // 
            this.complainHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // complainManagementSystemDataSet8
            // 
            this.complainManagementSystemDataSet8.DataSetName = "ComplainManagementSystemDataSet8";
            this.complainManagementSystemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complaintHistoryBindingSource
            // 
            this.complaintHistoryBindingSource.DataMember = "ComplaintHistory";
            this.complaintHistoryBindingSource.DataSource = this.complainManagementSystemDataSet8;
            // 
            // complaintHistoryTableAdapter
            // 
            this.complaintHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // complainManagementSystemDataSet11
            // 
            this.complainManagementSystemDataSet11.DataSetName = "ComplainManagementSystemDataSet11";
            this.complainManagementSystemDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complainHistoryBindingSource1
            // 
            this.complainHistoryBindingSource1.DataMember = "ComplainHistory";
            this.complainHistoryBindingSource1.DataSource = this.complainManagementSystemDataSet11;
            // 
            // complainHistoryTableAdapter1
            // 
            this.complainHistoryTableAdapter1.ClearBeforeFill = true;
            // 
            // complainManagementSystemDataSet13
            // 
            this.complainManagementSystemDataSet13.DataSetName = "ComplainManagementSystemDataSet13";
            this.complainManagementSystemDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complainHistoryBindingSource2
            // 
            this.complainHistoryBindingSource2.DataMember = "ComplainHistory";
            this.complainHistoryBindingSource2.DataSource = this.complainManagementSystemDataSet13;
            // 
            // complainHistoryTableAdapter2
            // 
            this.complainHistoryTableAdapter2.ClearBeforeFill = true;
            // 
            // AllHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 556);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "AllHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllHistory";
            this.Load += new System.EventHandler(this.AllHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainHistoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainHistoryBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button refreshbtn;
        private ComplainManagementSystemDataSet5 complainManagementSystemDataSet5;
        private System.Windows.Forms.BindingSource complainHistoryBindingSource;
        private ComplainManagementSystemDataSet5TableAdapters.ComplainHistoryTableAdapter complainHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDateDataGridViewTextBoxColumn;
        private ComplainManagementSystemDataSet8 complainManagementSystemDataSet8;
        private System.Windows.Forms.BindingSource complaintHistoryBindingSource;
        private ComplainManagementSystemDataSet8TableAdapters.ComplaintHistoryTableAdapter complaintHistoryTableAdapter;
        private ComplainManagementSystemDataSet11 complainManagementSystemDataSet11;
        private System.Windows.Forms.BindingSource complainHistoryBindingSource1;
        private ComplainManagementSystemDataSet11TableAdapters.ComplainHistoryTableAdapter complainHistoryTableAdapter1;
        private ComplainManagementSystemDataSet13 complainManagementSystemDataSet13;
        private System.Windows.Forms.BindingSource complainHistoryBindingSource2;
        private ComplainManagementSystemDataSet13TableAdapters.ComplainHistoryTableAdapter complainHistoryTableAdapter2;
    }
}