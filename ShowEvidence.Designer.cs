namespace ComplainManagementSyestem
{
    partial class ShowEvidence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowEvidence));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.evidenceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complainManagementSystemDataSet15 = new ComplainManagementSyestem.ComplainManagementSystemDataSet15();
            this.backbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.evidenceTableAdapter = new ComplainManagementSyestem.ComplainManagementSystemDataSet15TableAdapters.EvidenceTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evidenceIDDataGridViewTextBoxColumn,
            this.complainIDDataGridViewTextBoxColumn,
            this.filePathDataGridViewTextBoxColumn,
            this.uploadDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.evidenceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(152, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(573, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // evidenceIDDataGridViewTextBoxColumn
            // 
            this.evidenceIDDataGridViewTextBoxColumn.DataPropertyName = "EvidenceID";
            this.evidenceIDDataGridViewTextBoxColumn.HeaderText = "EvidenceID";
            this.evidenceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evidenceIDDataGridViewTextBoxColumn.Name = "evidenceIDDataGridViewTextBoxColumn";
            this.evidenceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.evidenceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // complainIDDataGridViewTextBoxColumn
            // 
            this.complainIDDataGridViewTextBoxColumn.DataPropertyName = "ComplainID";
            this.complainIDDataGridViewTextBoxColumn.HeaderText = "ComplainID";
            this.complainIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.complainIDDataGridViewTextBoxColumn.Name = "complainIDDataGridViewTextBoxColumn";
            this.complainIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            this.filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn.HeaderText = "FilePath";
            this.filePathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            this.filePathDataGridViewTextBoxColumn.Width = 125;
            // 
            // uploadDateDataGridViewTextBoxColumn
            // 
            this.uploadDateDataGridViewTextBoxColumn.DataPropertyName = "UploadDate";
            this.uploadDateDataGridViewTextBoxColumn.HeaderText = "UploadDate";
            this.uploadDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uploadDateDataGridViewTextBoxColumn.Name = "uploadDateDataGridViewTextBoxColumn";
            this.uploadDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // evidenceBindingSource
            // 
            this.evidenceBindingSource.DataMember = "Evidence";
            this.evidenceBindingSource.DataSource = this.complainManagementSystemDataSet15;
            // 
            // complainManagementSystemDataSet15
            // 
            this.complainManagementSystemDataSet15.DataSetName = "ComplainManagementSystemDataSet15";
            this.complainManagementSystemDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backbtn
            // 
            this.backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbtn.BackgroundImage")));
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backbtn.Location = new System.Drawing.Point(34, 25);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(50, 45);
            this.backbtn.TabIndex = 13;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Complain ID";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(557, 94);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 10;
            this.searchbtn.Text = "search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshbtn.BackgroundImage")));
            this.refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshbtn.Location = new System.Drawing.Point(409, 482);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(45, 45);
            this.refreshbtn.TabIndex = 14;
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // evidenceTableAdapter
            // 
            this.evidenceTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Find evidence ";
            // 
            // ShowEvidence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowEvidence";
            this.Text = "ShowEvidence";
            this.Load += new System.EventHandler(this.ShowEvidence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button refreshbtn;
        private ComplainManagementSystemDataSet15 complainManagementSystemDataSet15;
        private System.Windows.Forms.BindingSource evidenceBindingSource;
        private ComplainManagementSystemDataSet15TableAdapters.EvidenceTableAdapter evidenceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn evidenceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}