
namespace UniversityManagementSystem
{
    partial class CrudLibrary
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
            this.BupdateBtn = new System.Windows.Forms.Button();
            this.BidLbl = new System.Windows.Forms.Label();
            this.BnameTxt = new System.Windows.Forms.TextBox();
            this.BooksGridView = new System.Windows.Forms.DataGridView();
            this.BnameLbl = new System.Windows.Forms.Label();
            this.BauthorLbl = new System.Windows.Forms.Label();
            this.BcateLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BstockLbl = new System.Windows.Forms.Label();
            this.BauthorTxt = new System.Windows.Forms.TextBox();
            this.BcopyTxt = new System.Windows.Forms.TextBox();
            this.BidTxt = new System.Windows.Forms.TextBox();
            this.BcateTxt = new System.Windows.Forms.TextBox();
            this.BdeleteBtn = new System.Windows.Forms.Button();
            this.BclearBtn = new System.Windows.Forms.Button();
            this.BaddBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataSet4 = new UniversityManagementSystem.DataSet4();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSTableAdapter = new UniversityManagementSystem.DataSet4TableAdapters.BOOKSTableAdapter();
            this.bOOKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOOFCOPIESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVAILABILITYOFBOOKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BupdateBtn
            // 
            this.BupdateBtn.Location = new System.Drawing.Point(264, 60);
            this.BupdateBtn.Name = "BupdateBtn";
            this.BupdateBtn.Size = new System.Drawing.Size(184, 34);
            this.BupdateBtn.TabIndex = 0;
            this.BupdateBtn.Text = "UPDATE";
            this.BupdateBtn.UseVisualStyleBackColor = true;
            this.BupdateBtn.Click += new System.EventHandler(this.BupdateBtn_Click);
            // 
            // BidLbl
            // 
            this.BidLbl.AutoSize = true;
            this.BidLbl.Location = new System.Drawing.Point(3, 18);
            this.BidLbl.Name = "BidLbl";
            this.BidLbl.Size = new System.Drawing.Size(26, 20);
            this.BidLbl.TabIndex = 1;
            this.BidLbl.Text = "ID";
            // 
            // BnameTxt
            // 
            this.BnameTxt.Location = new System.Drawing.Point(193, 12);
            this.BnameTxt.Name = "BnameTxt";
            this.BnameTxt.Size = new System.Drawing.Size(275, 26);
            this.BnameTxt.TabIndex = 2;
            // 
            // BooksGridView
            // 
            this.BooksGridView.AutoGenerateColumns = false;
            this.BooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKIDDataGridViewTextBoxColumn,
            this.bOOKNAMEDataGridViewTextBoxColumn,
            this.aUTHORDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.nOOFCOPIESDataGridViewTextBoxColumn,
            this.aVAILABILITYOFBOOKDataGridViewTextBoxColumn});
            this.BooksGridView.DataSource = this.bOOKSBindingSource;
            this.BooksGridView.Location = new System.Drawing.Point(12, 109);
            this.BooksGridView.Name = "BooksGridView";
            this.BooksGridView.RowHeadersWidth = 62;
            this.BooksGridView.RowTemplate.Height = 28;
            this.BooksGridView.Size = new System.Drawing.Size(1328, 465);
            this.BooksGridView.TabIndex = 3;
            this.BooksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksGridView_CellContentClick);
            // 
            // BnameLbl
            // 
            this.BnameLbl.AutoSize = true;
            this.BnameLbl.Location = new System.Drawing.Point(132, 18);
            this.BnameLbl.Name = "BnameLbl";
            this.BnameLbl.Size = new System.Drawing.Size(55, 20);
            this.BnameLbl.TabIndex = 4;
            this.BnameLbl.Text = "NAME";
            // 
            // BauthorLbl
            // 
            this.BauthorLbl.AutoSize = true;
            this.BauthorLbl.Location = new System.Drawing.Point(484, 12);
            this.BauthorLbl.Name = "BauthorLbl";
            this.BauthorLbl.Size = new System.Drawing.Size(77, 20);
            this.BauthorLbl.TabIndex = 5;
            this.BauthorLbl.Text = "AUTHOR";
            // 
            // BcateLbl
            // 
            this.BcateLbl.AutoSize = true;
            this.BcateLbl.Location = new System.Drawing.Point(861, 12);
            this.BcateLbl.Name = "BcateLbl";
            this.BcateLbl.Size = new System.Drawing.Size(99, 20);
            this.BcateLbl.TabIndex = 6;
            this.BcateLbl.Text = "CATEGORY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1177, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "COPIES";
            // 
            // BstockLbl
            // 
            this.BstockLbl.AutoSize = true;
            this.BstockLbl.Location = new System.Drawing.Point(1184, 47);
            this.BstockLbl.Name = "BstockLbl";
            this.BstockLbl.Size = new System.Drawing.Size(62, 20);
            this.BstockLbl.TabIndex = 8;
            this.BstockLbl.Text = "STOCK";
            // 
            // BauthorTxt
            // 
            this.BauthorTxt.Location = new System.Drawing.Point(567, 9);
            this.BauthorTxt.Name = "BauthorTxt";
            this.BauthorTxt.Size = new System.Drawing.Size(288, 26);
            this.BauthorTxt.TabIndex = 9;
            // 
            // BcopyTxt
            // 
            this.BcopyTxt.Location = new System.Drawing.Point(1253, 9);
            this.BcopyTxt.Name = "BcopyTxt";
            this.BcopyTxt.Size = new System.Drawing.Size(100, 26);
            this.BcopyTxt.TabIndex = 11;
            // 
            // BidTxt
            // 
            this.BidTxt.Location = new System.Drawing.Point(26, 15);
            this.BidTxt.Name = "BidTxt";
            this.BidTxt.Size = new System.Drawing.Size(100, 26);
            this.BidTxt.TabIndex = 12;
            // 
            // BcateTxt
            // 
            this.BcateTxt.Location = new System.Drawing.Point(978, 9);
            this.BcateTxt.Name = "BcateTxt";
            this.BcateTxt.Size = new System.Drawing.Size(193, 26);
            this.BcateTxt.TabIndex = 13;
            // 
            // BdeleteBtn
            // 
            this.BdeleteBtn.Location = new System.Drawing.Point(567, 60);
            this.BdeleteBtn.Name = "BdeleteBtn";
            this.BdeleteBtn.Size = new System.Drawing.Size(160, 34);
            this.BdeleteBtn.TabIndex = 14;
            this.BdeleteBtn.Text = "DELETE";
            this.BdeleteBtn.UseVisualStyleBackColor = true;
            this.BdeleteBtn.Click += new System.EventHandler(this.BdeleteBtn_Click);
            // 
            // BclearBtn
            // 
            this.BclearBtn.Location = new System.Drawing.Point(831, 60);
            this.BclearBtn.Name = "BclearBtn";
            this.BclearBtn.Size = new System.Drawing.Size(173, 34);
            this.BclearBtn.TabIndex = 15;
            this.BclearBtn.Text = "CLEAR";
            this.BclearBtn.UseVisualStyleBackColor = true;
            this.BclearBtn.Click += new System.EventHandler(this.BclearBtn_Click);
            // 
            // BaddBtn
            // 
            this.BaddBtn.Location = new System.Drawing.Point(26, 60);
            this.BaddBtn.Name = "BaddBtn";
            this.BaddBtn.Size = new System.Drawing.Size(146, 34);
            this.BaddBtn.TabIndex = 16;
            this.BaddBtn.Text = "ADD";
            this.BaddBtn.UseVisualStyleBackColor = true;
            this.BaddBtn.Click += new System.EventHandler(this.BaddBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.comboBox1.Location = new System.Drawing.Point(1254, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.dataSet4;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKIDDataGridViewTextBoxColumn
            // 
            this.bOOKIDDataGridViewTextBoxColumn.DataPropertyName = "BOOK_ID";
            this.bOOKIDDataGridViewTextBoxColumn.HeaderText = "BOOK_ID";
            this.bOOKIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bOOKIDDataGridViewTextBoxColumn.Name = "bOOKIDDataGridViewTextBoxColumn";
            this.bOOKIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // bOOKNAMEDataGridViewTextBoxColumn
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOK_NAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.HeaderText = "BOOK_NAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bOOKNAMEDataGridViewTextBoxColumn.Name = "bOOKNAMEDataGridViewTextBoxColumn";
            this.bOOKNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // aUTHORDataGridViewTextBoxColumn
            // 
            this.aUTHORDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR";
            this.aUTHORDataGridViewTextBoxColumn.HeaderText = "AUTHOR";
            this.aUTHORDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aUTHORDataGridViewTextBoxColumn.Name = "aUTHORDataGridViewTextBoxColumn";
            this.aUTHORDataGridViewTextBoxColumn.Width = 150;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.Width = 150;
            // 
            // nOOFCOPIESDataGridViewTextBoxColumn
            // 
            this.nOOFCOPIESDataGridViewTextBoxColumn.DataPropertyName = "NO_OF_COPIES";
            this.nOOFCOPIESDataGridViewTextBoxColumn.HeaderText = "NO_OF_COPIES";
            this.nOOFCOPIESDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nOOFCOPIESDataGridViewTextBoxColumn.Name = "nOOFCOPIESDataGridViewTextBoxColumn";
            this.nOOFCOPIESDataGridViewTextBoxColumn.Width = 150;
            // 
            // aVAILABILITYOFBOOKDataGridViewTextBoxColumn
            // 
            this.aVAILABILITYOFBOOKDataGridViewTextBoxColumn.DataPropertyName = "AVAILABILITY_OF_BOOK";
            this.aVAILABILITYOFBOOKDataGridViewTextBoxColumn.HeaderText = "AVAILABILITY_OF_BOOK";
            this.aVAILABILITYOFBOOKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aVAILABILITYOFBOOKDataGridViewTextBoxColumn.Name = "aVAILABILITYOFBOOKDataGridViewTextBoxColumn";
            this.aVAILABILITYOFBOOKDataGridViewTextBoxColumn.Width = 150;
            // 
            // CrudLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 588);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BaddBtn);
            this.Controls.Add(this.BclearBtn);
            this.Controls.Add(this.BdeleteBtn);
            this.Controls.Add(this.BcateTxt);
            this.Controls.Add(this.BidTxt);
            this.Controls.Add(this.BcopyTxt);
            this.Controls.Add(this.BauthorTxt);
            this.Controls.Add(this.BstockLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BcateLbl);
            this.Controls.Add(this.BauthorLbl);
            this.Controls.Add(this.BnameLbl);
            this.Controls.Add(this.BooksGridView);
            this.Controls.Add(this.BnameTxt);
            this.Controls.Add(this.BidLbl);
            this.Controls.Add(this.BupdateBtn);
            this.Name = "CrudLibrary";
            this.Text = "CrudLibrary";
            this.Load += new System.EventHandler(this.CrudLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BupdateBtn;
        private System.Windows.Forms.Label BidLbl;
        private System.Windows.Forms.TextBox BnameTxt;
        private System.Windows.Forms.DataGridView BooksGridView;
        private System.Windows.Forms.Label BnameLbl;
        private System.Windows.Forms.Label BauthorLbl;
        private System.Windows.Forms.Label BcateLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BstockLbl;
        private System.Windows.Forms.TextBox BauthorTxt;
        private System.Windows.Forms.TextBox BcopyTxt;
        private System.Windows.Forms.TextBox BidTxt;
        private System.Windows.Forms.TextBox BcateTxt;
        private System.Windows.Forms.Button BdeleteBtn;
        private System.Windows.Forms.Button BclearBtn;
        private System.Windows.Forms.Button BaddBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private DataSet4TableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOOFCOPIESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVAILABILITYOFBOOKDataGridViewTextBoxColumn;
    }
}