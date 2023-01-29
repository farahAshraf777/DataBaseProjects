namespace BANK2
{
    partial class Form10
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bANK_SYSTEM2DataSet = new BANK2.BANK_SYSTEM2DataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new BANK2.BANK_SYSTEM2DataSetTableAdapters.CustomerTableAdapter();
            this.cSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanTableAdapter = new BANK2.BANK_SYSTEM2DataSetTableAdapters.LoanTableAdapter();
            this.lnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSSNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new BANK2.BANK_SYSTEM2DataSetTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANK_SYSTEM2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(51, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 74);
            this.button3.TabIndex = 5;
            this.button3.Text = "loan with customer and employee name";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(363, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 74);
            this.button2.TabIndex = 4;
            this.button2.Text = "Loan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(656, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "Customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSSNDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.caddrDataGridViewTextBoxColumn,
            this.cphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(667, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(254, 159);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lnumDataGridViewTextBoxColumn,
            this.adminIDDataGridViewTextBoxColumn,
            this.bankcodeDataGridViewTextBoxColumn,
            this.branchnumDataGridViewTextBoxColumn,
            this.cSSNDataGridViewTextBoxColumn1,
            this.eIDDataGridViewTextBoxColumn,
            this.ltypeDataGridViewTextBoxColumn,
            this.lamountDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.loanBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(363, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 26;
            this.dataGridView2.Size = new System.Drawing.Size(254, 159);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(65, 72);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 26;
            this.dataGridView3.Size = new System.Drawing.Size(217, 159);
            this.dataGridView3.TabIndex = 8;
            // 
            // bANK_SYSTEM2DataSet
            // 
            this.bANK_SYSTEM2DataSet.DataSetName = "BANK_SYSTEM2DataSet";
            this.bANK_SYSTEM2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.bANK_SYSTEM2DataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // cSSNDataGridViewTextBoxColumn
            // 
            this.cSSNDataGridViewTextBoxColumn.DataPropertyName = "C_SSN";
            this.cSSNDataGridViewTextBoxColumn.HeaderText = "C_SSN";
            this.cSSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cSSNDataGridViewTextBoxColumn.Name = "cSSNDataGridViewTextBoxColumn";
            this.cSSNDataGridViewTextBoxColumn.Width = 125;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "C_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "C_name";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // caddrDataGridViewTextBoxColumn
            // 
            this.caddrDataGridViewTextBoxColumn.DataPropertyName = "C_addr";
            this.caddrDataGridViewTextBoxColumn.HeaderText = "C_addr";
            this.caddrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.caddrDataGridViewTextBoxColumn.Name = "caddrDataGridViewTextBoxColumn";
            this.caddrDataGridViewTextBoxColumn.Width = 125;
            // 
            // cphoneDataGridViewTextBoxColumn
            // 
            this.cphoneDataGridViewTextBoxColumn.DataPropertyName = "C_phone";
            this.cphoneDataGridViewTextBoxColumn.HeaderText = "C_phone";
            this.cphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cphoneDataGridViewTextBoxColumn.Name = "cphoneDataGridViewTextBoxColumn";
            this.cphoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "Loan";
            this.loanBindingSource.DataSource = this.bANK_SYSTEM2DataSet;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // lnumDataGridViewTextBoxColumn
            // 
            this.lnumDataGridViewTextBoxColumn.DataPropertyName = "L_num";
            this.lnumDataGridViewTextBoxColumn.HeaderText = "L_num";
            this.lnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnumDataGridViewTextBoxColumn.Name = "lnumDataGridViewTextBoxColumn";
            this.lnumDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminIDDataGridViewTextBoxColumn
            // 
            this.adminIDDataGridViewTextBoxColumn.DataPropertyName = "Admin_ID";
            this.adminIDDataGridViewTextBoxColumn.HeaderText = "Admin_ID";
            this.adminIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminIDDataGridViewTextBoxColumn.Name = "adminIDDataGridViewTextBoxColumn";
            this.adminIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bankcodeDataGridViewTextBoxColumn
            // 
            this.bankcodeDataGridViewTextBoxColumn.DataPropertyName = "Bank_code";
            this.bankcodeDataGridViewTextBoxColumn.HeaderText = "Bank_code";
            this.bankcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bankcodeDataGridViewTextBoxColumn.Name = "bankcodeDataGridViewTextBoxColumn";
            this.bankcodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // branchnumDataGridViewTextBoxColumn
            // 
            this.branchnumDataGridViewTextBoxColumn.DataPropertyName = "Branch_num";
            this.branchnumDataGridViewTextBoxColumn.HeaderText = "Branch_num";
            this.branchnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchnumDataGridViewTextBoxColumn.Name = "branchnumDataGridViewTextBoxColumn";
            this.branchnumDataGridViewTextBoxColumn.Width = 125;
            // 
            // cSSNDataGridViewTextBoxColumn1
            // 
            this.cSSNDataGridViewTextBoxColumn1.DataPropertyName = "C_SSN";
            this.cSSNDataGridViewTextBoxColumn1.HeaderText = "C_SSN";
            this.cSSNDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cSSNDataGridViewTextBoxColumn1.Name = "cSSNDataGridViewTextBoxColumn1";
            this.cSSNDataGridViewTextBoxColumn1.Width = 125;
            // 
            // eIDDataGridViewTextBoxColumn
            // 
            this.eIDDataGridViewTextBoxColumn.DataPropertyName = "E_ID";
            this.eIDDataGridViewTextBoxColumn.HeaderText = "E_ID";
            this.eIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eIDDataGridViewTextBoxColumn.Name = "eIDDataGridViewTextBoxColumn";
            this.eIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ltypeDataGridViewTextBoxColumn
            // 
            this.ltypeDataGridViewTextBoxColumn.DataPropertyName = "L_type";
            this.ltypeDataGridViewTextBoxColumn.HeaderText = "L_type";
            this.ltypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ltypeDataGridViewTextBoxColumn.Name = "ltypeDataGridViewTextBoxColumn";
            this.ltypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // lamountDataGridViewTextBoxColumn
            // 
            this.lamountDataGridViewTextBoxColumn.DataPropertyName = "L_amount";
            this.lamountDataGridViewTextBoxColumn.HeaderText = "L_amount";
            this.lamountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lamountDataGridViewTextBoxColumn.Name = "lamountDataGridViewTextBoxColumn";
            this.lamountDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bANK_SYSTEM2DataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 512);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANK_SYSTEM2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private BANK_SYSTEM2DataSet bANK_SYSTEM2DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BANK_SYSTEM2DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private BANK_SYSTEM2DataSetTableAdapters.LoanTableAdapter loanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSSNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private BANK_SYSTEM2DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}