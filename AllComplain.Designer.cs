namespace ComplainManagementSyestem
{
    partial class AllComplain
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
            this.backbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.complainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complainManagementSystemDataSet2 = new ComplainManagementSyestem.ComplainManagementSystemDataSet2();
            this.complainTableAdapter = new ComplainManagementSyestem.ComplainManagementSystemDataSet2TableAdapters.ComplainTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.complainManagementSystemDataSet7 = new ComplainManagementSyestem.ComplainManagementSystemDataSet7();
            this.complainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.complainTableAdapter1 = new ComplainManagementSyestem.ComplainManagementSystemDataSet7TableAdapters.ComplainTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(22, 35);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 0;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.complainIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.currentStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.complainBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(107, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 425);
            this.dataGridView1.TabIndex = 1;
            // 
            // complainIDDataGridViewTextBoxColumn
            // 
            this.complainIDDataGridViewTextBoxColumn.DataPropertyName = "ComplainID";
            this.complainIDDataGridViewTextBoxColumn.HeaderText = "ComplainID";
            this.complainIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.complainIDDataGridViewTextBoxColumn.Name = "complainIDDataGridViewTextBoxColumn";
            this.complainIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.complainIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentStatusDataGridViewTextBoxColumn
            // 
            this.currentStatusDataGridViewTextBoxColumn.DataPropertyName = "CurrentStatus";
            this.currentStatusDataGridViewTextBoxColumn.HeaderText = "CurrentStatus";
            this.currentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentStatusDataGridViewTextBoxColumn.Name = "currentStatusDataGridViewTextBoxColumn";
            this.currentStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // complainBindingSource
            // 
            this.complainBindingSource.DataMember = "Complain";
            this.complainBindingSource.DataSource = this.complainManagementSystemDataSet2;
            // 
            // complainManagementSystemDataSet2
            // 
            this.complainManagementSystemDataSet2.DataSetName = "ComplainManagementSystemDataSet2";
            this.complainManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complainTableAdapter
            // 
            this.complainTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Complain ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Complain By Complain ID";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(562, 126);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 5;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // complainManagementSystemDataSet7
            // 
            this.complainManagementSystemDataSet7.DataSetName = "ComplainManagementSystemDataSet7";
            this.complainManagementSystemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complainBindingSource1
            // 
            this.complainBindingSource1.DataMember = "Complain";
            this.complainBindingSource1.DataSource = this.complainManagementSystemDataSet7;
            // 
            // complainTableAdapter1
            // 
            this.complainTableAdapter1.ClearBeforeFill = true;
            // 
            // AllComplain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backbtn);
            this.Name = "AllComplain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllComplain";
            this.Load += new System.EventHandler(this.AllComplain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainManagementSystemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complainBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComplainManagementSystemDataSet2 complainManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource complainBindingSource;
        private ComplainManagementSystemDataSet2TableAdapters.ComplainTableAdapter complainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button button1;
        private ComplainManagementSystemDataSet7 complainManagementSystemDataSet7;
        private System.Windows.Forms.BindingSource complainBindingSource1;
        private ComplainManagementSystemDataSet7TableAdapters.ComplainTableAdapter complainTableAdapter1;
    }
}