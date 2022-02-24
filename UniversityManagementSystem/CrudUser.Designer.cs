
namespace UniversityManagementSystem
{
    partial class CrudUser
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
            this.UaddBtn = new System.Windows.Forms.Button();
            this.UupdateBtn = new System.Windows.Forms.Button();
            this.UdeleteBtn = new System.Windows.Forms.Button();
            this.UidLbl = new System.Windows.Forms.Label();
            this.UidTxt = new System.Windows.Forms.TextBox();
            this.UnameLbl = new System.Windows.Forms.Label();
            this.UpassLbl = new System.Windows.Forms.Label();
            this.UnameTxt = new System.Windows.Forms.TextBox();
            this.UpassTxt = new System.Windows.Forms.TextBox();
            this.UclearBtn = new System.Windows.Forms.Button();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.dataSet3 = new UniversityManagementSystem.DataSet3();
            this.iDENTIFYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDENTIFYTableAdapter = new UniversityManagementSystem.DataSet3TableAdapters.IDENTIFYTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDENTIFYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UaddBtn
            // 
            this.UaddBtn.Location = new System.Drawing.Point(187, 64);
            this.UaddBtn.Name = "UaddBtn";
            this.UaddBtn.Size = new System.Drawing.Size(90, 35);
            this.UaddBtn.TabIndex = 0;
            this.UaddBtn.Text = "ADD";
            this.UaddBtn.UseVisualStyleBackColor = true;
            this.UaddBtn.Click += new System.EventHandler(this.UaddBtn_Click);
            // 
            // UupdateBtn
            // 
            this.UupdateBtn.Location = new System.Drawing.Point(301, 64);
            this.UupdateBtn.Name = "UupdateBtn";
            this.UupdateBtn.Size = new System.Drawing.Size(100, 35);
            this.UupdateBtn.TabIndex = 1;
            this.UupdateBtn.Text = "UPDATE";
            this.UupdateBtn.UseVisualStyleBackColor = true;
            this.UupdateBtn.Click += new System.EventHandler(this.UupdateBtn_Click);
            // 
            // UdeleteBtn
            // 
            this.UdeleteBtn.Location = new System.Drawing.Point(418, 64);
            this.UdeleteBtn.Name = "UdeleteBtn";
            this.UdeleteBtn.Size = new System.Drawing.Size(99, 35);
            this.UdeleteBtn.TabIndex = 2;
            this.UdeleteBtn.Text = "DELETE";
            this.UdeleteBtn.UseVisualStyleBackColor = true;
            this.UdeleteBtn.Click += new System.EventHandler(this.UdeleteBtn_Click);
            // 
            // UidLbl
            // 
            this.UidLbl.AutoSize = true;
            this.UidLbl.Location = new System.Drawing.Point(1, 15);
            this.UidLbl.Name = "UidLbl";
            this.UidLbl.Size = new System.Drawing.Size(26, 20);
            this.UidLbl.TabIndex = 3;
            this.UidLbl.Text = "ID";
            // 
            // UidTxt
            // 
            this.UidTxt.Location = new System.Drawing.Point(42, 12);
            this.UidTxt.Name = "UidTxt";
            this.UidTxt.Size = new System.Drawing.Size(131, 26);
            this.UidTxt.TabIndex = 4;
            // 
            // UnameLbl
            // 
            this.UnameLbl.AutoSize = true;
            this.UnameLbl.Location = new System.Drawing.Point(222, 15);
            this.UnameLbl.Name = "UnameLbl";
            this.UnameLbl.Size = new System.Drawing.Size(55, 20);
            this.UnameLbl.TabIndex = 5;
            this.UnameLbl.Text = "NAME";
            // 
            // UpassLbl
            // 
            this.UpassLbl.AutoSize = true;
            this.UpassLbl.Location = new System.Drawing.Point(712, 12);
            this.UpassLbl.Name = "UpassLbl";
            this.UpassLbl.Size = new System.Drawing.Size(103, 20);
            this.UpassLbl.TabIndex = 6;
            this.UpassLbl.Text = "PASSWORD";
            // 
            // UnameTxt
            // 
            this.UnameTxt.Location = new System.Drawing.Point(301, 12);
            this.UnameTxt.Name = "UnameTxt";
            this.UnameTxt.Size = new System.Drawing.Size(371, 26);
            this.UnameTxt.TabIndex = 7;
            // 
            // UpassTxt
            // 
            this.UpassTxt.Location = new System.Drawing.Point(830, 9);
            this.UpassTxt.Name = "UpassTxt";
            this.UpassTxt.Size = new System.Drawing.Size(225, 26);
            this.UpassTxt.TabIndex = 8;
            // 
            // UclearBtn
            // 
            this.UclearBtn.Location = new System.Drawing.Point(542, 64);
            this.UclearBtn.Name = "UclearBtn";
            this.UclearBtn.Size = new System.Drawing.Size(90, 35);
            this.UclearBtn.TabIndex = 9;
            this.UclearBtn.Text = "CLEAR";
            this.UclearBtn.UseVisualStyleBackColor = true;
            this.UclearBtn.Click += new System.EventHandler(this.UclearBtn_Click);
            // 
            // UserGridView
            // 
            this.UserGridView.AutoGenerateColumns = false;
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.pASSWORDDataGridViewTextBoxColumn});
            this.UserGridView.DataSource = this.iDENTIFYBindingSource;
            this.UserGridView.Location = new System.Drawing.Point(139, 123);
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.RowHeadersWidth = 62;
            this.UserGridView.RowTemplate.Height = 28;
            this.UserGridView.Size = new System.Drawing.Size(576, 411);
            this.UserGridView.TabIndex = 10;
            this.UserGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGridView_CellContentClick);
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDENTIFYBindingSource
            // 
            this.iDENTIFYBindingSource.DataMember = "IDENTIFY";
            this.iDENTIFYBindingSource.DataSource = this.dataSet3;
            // 
            // iDENTIFYTableAdapter
            // 
            this.iDENTIFYTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USER_NAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USER_NAME";
            this.uSERNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            this.uSERNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            this.pASSWORDDataGridViewTextBoxColumn.Width = 150;
            // 
            // CrudUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 569);
            this.Controls.Add(this.UserGridView);
            this.Controls.Add(this.UclearBtn);
            this.Controls.Add(this.UpassTxt);
            this.Controls.Add(this.UnameTxt);
            this.Controls.Add(this.UpassLbl);
            this.Controls.Add(this.UnameLbl);
            this.Controls.Add(this.UidTxt);
            this.Controls.Add(this.UidLbl);
            this.Controls.Add(this.UdeleteBtn);
            this.Controls.Add(this.UupdateBtn);
            this.Controls.Add(this.UaddBtn);
            this.Name = "CrudUser";
            this.Text = "CrudUser";
            this.Load += new System.EventHandler(this.CrudUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDENTIFYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UaddBtn;
        private System.Windows.Forms.Button UupdateBtn;
        private System.Windows.Forms.Button UdeleteBtn;
        private System.Windows.Forms.Label UidLbl;
        private System.Windows.Forms.TextBox UidTxt;
        private System.Windows.Forms.Label UnameLbl;
        private System.Windows.Forms.Label UpassLbl;
        private System.Windows.Forms.TextBox UnameTxt;
        private System.Windows.Forms.TextBox UpassTxt;
        private System.Windows.Forms.Button UclearBtn;
        private System.Windows.Forms.DataGridView UserGridView;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource iDENTIFYBindingSource;
        private DataSet3TableAdapters.IDENTIFYTableAdapter iDENTIFYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
    }
}