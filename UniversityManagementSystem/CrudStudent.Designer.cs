
namespace UniversityManagementSystem
{
    partial class CrudStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.Crtxt = new System.Windows.Forms.TextBox();
            this.Cgpatxt = new System.Windows.Forms.TextBox();
            this.Citytxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.by = new System.Windows.Forms.Label();
            this.Combo = new System.Windows.Forms.ComboBox();
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.dataSet1 = new UniversityManagementSystem.DataSet1();
            this.sTUDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTSTableAdapter = new UniversityManagementSystem.DataSet1TableAdapters.STUDENTSTableAdapter();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CGPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CREDIT COMPLITE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(738, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "EMAIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1018, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "CITY";
            // 
            // Idtxt
            // 
            this.Idtxt.Location = new System.Drawing.Point(35, 41);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(100, 26);
            this.Idtxt.TabIndex = 6;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(811, 44);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(201, 26);
            this.Emailtxt.TabIndex = 7;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(214, 44);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(116, 26);
            this.Nametxt.TabIndex = 8;
            // 
            // Searchtxt
            // 
            this.Searchtxt.Location = new System.Drawing.Point(811, 90);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(201, 26);
            this.Searchtxt.TabIndex = 9;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // Crtxt
            // 
            this.Crtxt.Location = new System.Drawing.Point(649, 44);
            this.Crtxt.Name = "Crtxt";
            this.Crtxt.Size = new System.Drawing.Size(64, 26);
            this.Crtxt.TabIndex = 10;
            // 
            // Cgpatxt
            // 
            this.Cgpatxt.Location = new System.Drawing.Point(396, 44);
            this.Cgpatxt.Name = "Cgpatxt";
            this.Cgpatxt.Size = new System.Drawing.Size(71, 26);
            this.Cgpatxt.TabIndex = 11;
            // 
            // Citytxt
            // 
            this.Citytxt.Location = new System.Drawing.Point(1060, 44);
            this.Citytxt.Name = "Citytxt";
            this.Citytxt.Size = new System.Drawing.Size(121, 26);
            this.Citytxt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(705, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "SEARCH";
            // 
            // by
            // 
            this.by.AutoSize = true;
            this.by.Location = new System.Drawing.Point(1027, 93);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(31, 20);
            this.by.TabIndex = 14;
            this.by.Text = "BY";
            // 
            // Combo
            // 
            this.Combo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sTUDENTSBindingSource, "S_ID", true));
            this.Combo.FormattingEnabled = true;
            this.Combo.Items.AddRange(new object[] {
            "S_ID",
            "S_NAME",
            "CGPA",
            "CREDIT_COMPLETED",
            "S_EMAIL",
            "CITY"});
            this.Combo.Location = new System.Drawing.Point(1060, 88);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(121, 28);
            this.Combo.TabIndex = 15;
            // 
            // StudentGridView
            // 
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Location = new System.Drawing.Point(7, 132);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.RowHeadersWidth = 62;
            this.StudentGridView.RowTemplate.Height = 28;
            this.StudentGridView.Size = new System.Drawing.Size(1174, 404);
            this.StudentGridView.TabIndex = 16;
            this.StudentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView_CellContentClick);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(82, 87);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(96, 37);
            this.Addbtn.TabIndex = 17;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(205, 85);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(89, 39);
            this.Updatebtn.TabIndex = 18;
            this.Updatebtn.Text = "UPDATE";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(454, 87);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(109, 37);
            this.Clearbtn.TabIndex = 19;
            this.Clearbtn.Text = "CLEAR";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(321, 87);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(105, 37);
            this.Deletebtn.TabIndex = 20;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTSBindingSource
            // 
            this.sTUDENTSBindingSource.DataMember = "STUDENTS";
            this.sTUDENTSBindingSource.DataSource = this.dataSet1;
            // 
            // sTUDENTSTableAdapter
            // 
            this.sTUDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // CrudStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 548);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.StudentGridView);
            this.Controls.Add(this.Combo);
            this.Controls.Add(this.by);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Citytxt);
            this.Controls.Add(this.Cgpatxt);
            this.Controls.Add(this.Crtxt);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrudStudent";
            this.Text = "CrudStudent";
            this.Load += new System.EventHandler(this.CrudStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.TextBox Crtxt;
        private System.Windows.Forms.TextBox Cgpatxt;
        private System.Windows.Forms.TextBox Citytxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label by;
        private System.Windows.Forms.ComboBox Combo;
        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Deletebtn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sTUDENTSBindingSource;
        private DataSet1TableAdapters.STUDENTSTableAdapter sTUDENTSTableAdapter;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
    }
}