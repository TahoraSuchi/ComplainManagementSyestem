namespace ComplainManagementSyestem
{
    partial class ComplainHistory
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
            this.complainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complainManagementSystemDataSet = new ComplainManagementSyestem.ComplainManagementSystemDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.complainHistoryTableAdapter = new ComplainManagementSyestem.ComplainManagementSystemDataSetTableAdapters.ComplainHistoryTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.complainManagementSystemDataSet3 = new ComplainManagementSyestem.ComplainManagementSystemDataSet3();
            this.complainHistoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.complainHistoryTableAdapter1 = new ComplainManagementSyestem.ComplainManagementSystemDataSet3TableAdapters.ComplainHistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainHistoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.complainIDDataGridViewTextBoxColumn,
            this.oldStatusDataGridViewTextBoxColumn,
            this.newStatusDataGridViewTextBoxColumn,
            this.changeDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.complainHistoryBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(171, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 317);
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
            this.complainHistoryBindingSource.DataSource = this.complainManagementSystemDataSet;
            // 
            // complainManagementSystemDataSet
            // 
            this.complainManagementSystemDataSet.DataSetName = "ComplainManagementSystemDataSet";
            this.complainManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // complainHistoryTableAdapter
            // 
            this.complainHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // complainManagementSystemDataSet3
            // 
            this.complainManagementSystemDataSet3.DataSetName = "ComplainManagementSystemDataSet3";
            this.complainManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complainHistoryBindingSource1
            // 
            this.complainHistoryBindingSource1.DataMember = "ComplainHistory";
            this.complainHistoryBindingSource1.DataSource = this.complainManagementSystemDataSet3;
            // 
            // complainHistoryTableAdapter1
            // 
            this.complainHistoryTableAdapter1.ClearBeforeFill = true;
            // 
            // ComplainHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ComplainHistory";
            this.Text = "ComplainHistory";
            this.Load += new System.EventHandler(this.ComplainHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainHistoryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private ComplainManagementSystemDataSet complainManagementSystemDataSet;
        private System.Windows.Forms.BindingSource complainHistoryBindingSource;
        private ComplainManagementSystemDataSetTableAdapters.ComplainHistoryTableAdapter complainHistoryTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDateDataGridViewTextBoxColumn;
        private ComplainManagementSystemDataSet3 complainManagementSystemDataSet3;
        private System.Windows.Forms.BindingSource complainHistoryBindingSource1;
        private ComplainManagementSystemDataSet3TableAdapters.ComplainHistoryTableAdapter complainHistoryTableAdapter1;
    }
}