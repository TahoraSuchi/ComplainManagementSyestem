namespace ComplainManagementSyestem
{
    partial class ComplainForPolice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplainForPolice));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.complainManagementSystemDataSet16 = new ComplainManagementSyestem.ComplainManagementSystemDataSet16();
            this.complainAssignBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complainAssignTableAdapter = new ComplainManagementSyestem.ComplainManagementSystemDataSet16TableAdapters.ComplainAssignTableAdapter();
            this.backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.assignIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainAssignBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignIDDataGridViewTextBoxColumn,
            this.complainIDDataGridViewTextBoxColumn,
            this.assignedDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.complainAssignBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(179, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // complainManagementSystemDataSet16
            // 
            this.complainManagementSystemDataSet16.DataSetName = "ComplainManagementSystemDataSet16";
            this.complainManagementSystemDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complainAssignBindingSource
            // 
            this.complainAssignBindingSource.DataMember = "ComplainAssign";
            this.complainAssignBindingSource.DataSource = this.complainManagementSystemDataSet16;
            // 
            // complainAssignTableAdapter
            // 
            this.complainAssignTableAdapter.ClearBeforeFill = true;
            // 
            // backbtn
            // 
            this.backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbtn.BackgroundImage")));
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backbtn.Location = new System.Drawing.Point(28, 36);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(49, 45);
            this.backbtn.TabIndex = 10;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 54);
            this.label1.TabIndex = 11;
            this.label1.Text = "This Complain for you ";
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshbtn.BackgroundImage")));
            this.refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshbtn.Location = new System.Drawing.Point(403, 489);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(45, 45);
            this.refreshbtn.TabIndex = 12;
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // assignIDDataGridViewTextBoxColumn
            // 
            this.assignIDDataGridViewTextBoxColumn.DataPropertyName = "AssignID";
            this.assignIDDataGridViewTextBoxColumn.HeaderText = "AssignID";
            this.assignIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assignIDDataGridViewTextBoxColumn.Name = "assignIDDataGridViewTextBoxColumn";
            this.assignIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.assignIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // complainIDDataGridViewTextBoxColumn
            // 
            this.complainIDDataGridViewTextBoxColumn.DataPropertyName = "ComplainID";
            this.complainIDDataGridViewTextBoxColumn.HeaderText = "ComplainID";
            this.complainIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.complainIDDataGridViewTextBoxColumn.Name = "complainIDDataGridViewTextBoxColumn";
            this.complainIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // assignedDateDataGridViewTextBoxColumn
            // 
            this.assignedDateDataGridViewTextBoxColumn.DataPropertyName = "AssignedDate";
            this.assignedDateDataGridViewTextBoxColumn.HeaderText = "AssignedDate";
            this.assignedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assignedDateDataGridViewTextBoxColumn.Name = "assignedDateDataGridViewTextBoxColumn";
            this.assignedDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // ComplainForPolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 581);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ComplainForPolice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComplainForPolice";
            this.Load += new System.EventHandler(this.ComplainForPolice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainAssignBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ComplainManagementSystemDataSet16 complainManagementSystemDataSet16;
        private System.Windows.Forms.BindingSource complainAssignBindingSource;
        private ComplainManagementSystemDataSet16TableAdapters.ComplainAssignTableAdapter complainAssignTableAdapter;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedDateDataGridViewTextBoxColumn;
    }
}