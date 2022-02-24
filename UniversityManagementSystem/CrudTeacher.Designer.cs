
namespace UniversityManagementSystem
{
    partial class CrudTeacher
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
            this.tidlbl = new System.Windows.Forms.Label();
            this.tidtxt = new System.Windows.Forms.TextBox();
            this.tnamelbl = new System.Windows.Forms.Label();
            this.joinlbl = new System.Windows.Forms.Label();
            this.tphonelbl = new System.Windows.Forms.Label();
            this.temaillbl = new System.Windows.Forms.Label();
            this.tnametxt = new System.Windows.Forms.TextBox();
            this.temailtxt = new System.Windows.Forms.TextBox();
            this.tphonetxt = new System.Windows.Forms.TextBox();
            this.tdate = new System.Windows.Forms.DateTimePicker();
            this.taddbtn = new System.Windows.Forms.Button();
            this.tupdatebtn = new System.Windows.Forms.Button();
            this.tdeletebtn = new System.Windows.Forms.Button();
            this.tclearbtn = new System.Windows.Forms.Button();
            this.tsearchlbl = new System.Windows.Forms.Label();
            this.tsearchtxt = new System.Windows.Forms.TextBox();
            this.tcombo = new System.Windows.Forms.ComboBox();
            this.tbylbl = new System.Windows.Forms.Label();
            this.TeacherGridView = new System.Windows.Forms.DataGridView();
            this.TeachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new UniversityManagementSystem.DataSet2();
            this.oracleCommand2 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.tEACHERSTableAdapter = new UniversityManagementSystem.DataSet2TableAdapters.TEACHERSTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tidlbl
            // 
            this.tidlbl.AutoSize = true;
            this.tidlbl.Location = new System.Drawing.Point(12, 31);
            this.tidlbl.Name = "tidlbl";
            this.tidlbl.Size = new System.Drawing.Size(26, 20);
            this.tidlbl.TabIndex = 0;
            this.tidlbl.Text = "ID";
            // 
            // tidtxt
            // 
            this.tidtxt.Location = new System.Drawing.Point(44, 28);
            this.tidtxt.Name = "tidtxt";
            this.tidtxt.Size = new System.Drawing.Size(133, 26);
            this.tidtxt.TabIndex = 1;
            // 
            // tnamelbl
            // 
            this.tnamelbl.AutoSize = true;
            this.tnamelbl.Location = new System.Drawing.Point(195, 31);
            this.tnamelbl.Name = "tnamelbl";
            this.tnamelbl.Size = new System.Drawing.Size(55, 20);
            this.tnamelbl.TabIndex = 2;
            this.tnamelbl.Text = "NAME";
            // 
            // joinlbl
            // 
            this.joinlbl.AutoSize = true;
            this.joinlbl.Location = new System.Drawing.Point(457, 31);
            this.joinlbl.Name = "joinlbl";
            this.joinlbl.Size = new System.Drawing.Size(92, 20);
            this.joinlbl.TabIndex = 3;
            this.joinlbl.Text = "JOIN DATE";
            // 
            // tphonelbl
            // 
            this.tphonelbl.AutoSize = true;
            this.tphonelbl.Location = new System.Drawing.Point(880, 29);
            this.tphonelbl.Name = "tphonelbl";
            this.tphonelbl.Size = new System.Drawing.Size(65, 20);
            this.tphonelbl.TabIndex = 4;
            this.tphonelbl.Text = "PHONE";
            // 
            // temaillbl
            // 
            this.temaillbl.AutoSize = true;
            this.temaillbl.Location = new System.Drawing.Point(880, 72);
            this.temaillbl.Name = "temaillbl";
            this.temaillbl.Size = new System.Drawing.Size(58, 20);
            this.temaillbl.TabIndex = 5;
            this.temaillbl.Text = "EMAIL";
            // 
            // tnametxt
            // 
            this.tnametxt.Location = new System.Drawing.Point(256, 28);
            this.tnametxt.Name = "tnametxt";
            this.tnametxt.Size = new System.Drawing.Size(195, 26);
            this.tnametxt.TabIndex = 6;
            // 
            // temailtxt
            // 
            this.temailtxt.Location = new System.Drawing.Point(951, 69);
            this.temailtxt.Name = "temailtxt";
            this.temailtxt.Size = new System.Drawing.Size(210, 26);
            this.temailtxt.TabIndex = 7;
            // 
            // tphonetxt
            // 
            this.tphonetxt.Location = new System.Drawing.Point(951, 26);
            this.tphonetxt.Name = "tphonetxt";
            this.tphonetxt.Size = new System.Drawing.Size(210, 26);
            this.tphonetxt.TabIndex = 8;
            // 
            // tdate
            // 
            this.tdate.Location = new System.Drawing.Point(567, 26);
            this.tdate.Name = "tdate";
            this.tdate.Size = new System.Drawing.Size(295, 26);
            this.tdate.TabIndex = 9;
            // 
            // taddbtn
            // 
            this.taddbtn.Location = new System.Drawing.Point(0, 0);
            this.taddbtn.Name = "taddbtn";
            this.taddbtn.Size = new System.Drawing.Size(75, 23);
            this.taddbtn.TabIndex = 19;
            // 
            // tupdatebtn
            // 
            this.tupdatebtn.Location = new System.Drawing.Point(256, 92);
            this.tupdatebtn.Name = "tupdatebtn";
            this.tupdatebtn.Size = new System.Drawing.Size(102, 40);
            this.tupdatebtn.TabIndex = 11;
            this.tupdatebtn.Text = "UPDATE";
            this.tupdatebtn.UseVisualStyleBackColor = true;
            this.tupdatebtn.Click += new System.EventHandler(this.tupdatebtn_Click);
            // 
            // tdeletebtn
            // 
            this.tdeletebtn.Location = new System.Drawing.Point(387, 91);
            this.tdeletebtn.Name = "tdeletebtn";
            this.tdeletebtn.Size = new System.Drawing.Size(99, 40);
            this.tdeletebtn.TabIndex = 12;
            this.tdeletebtn.Text = "DELETE";
            this.tdeletebtn.UseVisualStyleBackColor = true;
            this.tdeletebtn.Click += new System.EventHandler(this.tdeletebtn_Click);
            // 
            // tclearbtn
            // 
            this.tclearbtn.Location = new System.Drawing.Point(518, 91);
            this.tclearbtn.Name = "tclearbtn";
            this.tclearbtn.Size = new System.Drawing.Size(91, 40);
            this.tclearbtn.TabIndex = 13;
            this.tclearbtn.Text = "CLEAR";
            this.tclearbtn.UseVisualStyleBackColor = true;
            this.tclearbtn.Click += new System.EventHandler(this.tclearbtn_Click);
            // 
            // tsearchlbl
            // 
            this.tsearchlbl.AutoSize = true;
            this.tsearchlbl.Location = new System.Drawing.Point(680, 109);
            this.tsearchlbl.Name = "tsearchlbl";
            this.tsearchlbl.Size = new System.Drawing.Size(77, 20);
            this.tsearchlbl.TabIndex = 14;
            this.tsearchlbl.Text = "SEARCH";
            // 
            // tsearchtxt
            // 
            this.tsearchtxt.Location = new System.Drawing.Point(778, 106);
            this.tsearchtxt.Name = "tsearchtxt";
            this.tsearchtxt.Size = new System.Drawing.Size(167, 26);
            this.tsearchtxt.TabIndex = 15;
            this.tsearchtxt.TextChanged += new System.EventHandler(this.tsearchtxt_TextChanged);
            // 
            // tcombo
            // 
            this.tcombo.FormattingEnabled = true;
            this.tcombo.Items.AddRange(new object[] {
            "ID",
            "NAME",
            "JOIN DATE",
            "PHONE",
            "EMAIL"});
            this.tcombo.Location = new System.Drawing.Point(1040, 106);
            this.tcombo.Name = "tcombo";
            this.tcombo.Size = new System.Drawing.Size(121, 28);
            this.tcombo.TabIndex = 16;
            // 
            // tbylbl
            // 
            this.tbylbl.AutoSize = true;
            this.tbylbl.Location = new System.Drawing.Point(979, 109);
            this.tbylbl.Name = "tbylbl";
            this.tbylbl.Size = new System.Drawing.Size(31, 20);
            this.tbylbl.TabIndex = 17;
            this.tbylbl.Text = "BY";
            // 
            // TeacherGridView
            // 
            this.TeacherGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherGridView.Location = new System.Drawing.Point(25, 150);
            this.TeacherGridView.Name = "TeacherGridView";
            this.TeacherGridView.RowHeadersWidth = 62;
            this.TeacherGridView.RowTemplate.Height = 28;
            this.TeacherGridView.Size = new System.Drawing.Size(1122, 372);
            this.TeacherGridView.TabIndex = 18;
            this.TeacherGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherGridView_CellContentClick);
            // 
            // TeachersBindingSource
            // 
            this.TeachersBindingSource.DataMember = "TEACHERS";
            this.TeachersBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Transaction = null;
            // 
            // tEACHERSTableAdapter
            // 
            this.tEACHERSTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrudTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TeacherGridView);
            this.Controls.Add(this.tbylbl);
            this.Controls.Add(this.tcombo);
            this.Controls.Add(this.tsearchtxt);
            this.Controls.Add(this.tsearchlbl);
            this.Controls.Add(this.tclearbtn);
            this.Controls.Add(this.tdeletebtn);
            this.Controls.Add(this.tupdatebtn);
            this.Controls.Add(this.taddbtn);
            this.Controls.Add(this.tdate);
            this.Controls.Add(this.tphonetxt);
            this.Controls.Add(this.temailtxt);
            this.Controls.Add(this.tnametxt);
            this.Controls.Add(this.temaillbl);
            this.Controls.Add(this.tphonelbl);
            this.Controls.Add(this.joinlbl);
            this.Controls.Add(this.tnamelbl);
            this.Controls.Add(this.tidtxt);
            this.Controls.Add(this.tidlbl);
            this.Name = "CrudTeacher";
            this.Text = "CrudTeacher";
            this.Load += new System.EventHandler(this.CrudTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tidlbl;
        private System.Windows.Forms.TextBox tidtxt;
        private System.Windows.Forms.Label tnamelbl;
        private System.Windows.Forms.Label joinlbl;
        private System.Windows.Forms.Label tphonelbl;
        private System.Windows.Forms.Label temaillbl;
        private System.Windows.Forms.TextBox tnametxt;
        private System.Windows.Forms.TextBox temailtxt;
        private System.Windows.Forms.TextBox tphonetxt;
        private System.Windows.Forms.DateTimePicker tdate;
        private System.Windows.Forms.Button taddbtn;
        private System.Windows.Forms.Button tupdatebtn;
        private System.Windows.Forms.Button tdeletebtn;
        private System.Windows.Forms.Button tclearbtn;
        private System.Windows.Forms.Label tsearchlbl;
        private System.Windows.Forms.TextBox tsearchtxt;
        private System.Windows.Forms.ComboBox tcombo;
        private System.Windows.Forms.Label tbylbl;
        private System.Windows.Forms.DataGridView TeacherGridView;
        private System.Windows.Forms.BindingSource TeachersBindingSource;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand2;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.TEACHERSTableAdapter tEACHERSTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}