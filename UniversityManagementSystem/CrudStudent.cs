using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace UniversityManagementSystem
{
    public partial class CrudStudent : Form
    {
        OracleConnection orc_conn = null;
        public CrudStudent()
        {
            this.SetConnection();
            //DataAccess da = new DataAccess();
            InitializeComponent();
            this.UpdateStudentGridView();
        }
        public void SetConnection()
        {
            String connectionString1 = ConfigurationManager.ConnectionStrings["UniversityManagementSystem.Properties.Settings.ConnectionString1"].ConnectionString;
            orc_conn = new OracleConnection(connectionString1);

            try
            {

                orc_conn.Open();
            }
            catch (Exception ex)
            {

            }
        }
        public void UpdateStudentGridView()
        {
            OracleCommand cmd = orc_conn.CreateCommand();

            cmd.CommandText = "SELECT S_ID ID,S_NAME NAME,CGPA,CREDIT_COMPLETED,S_EMAIL,CITY FROM STUDENTS ORDER BY S_ID DESC";
            cmd.CommandType = CommandType.Text;

            OracleDataReader odr = cmd.ExecuteReader();
            System.Data.DataTable d_tab = new System.Data.DataTable();

            d_tab.Load(odr);

            StudentGridView.DataSource = d_tab.DefaultView;


            odr.Close();
        }
        public void CrudOperation(string query, int val)
        {
            String msg = "";

            OracleCommand cmd = orc_conn.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;


            switch (val)
            {
                case 0:
                    msg = "Row Inserted Successfully ";
                    cmd.Parameters.Add("S_ID", OracleDbType.Int32, 10).Value = Idtxt.Text;
                    cmd.Parameters.Add("S_NAME", OracleDbType.Varchar2, 30).Value = Nametxt.Text;
                    cmd.Parameters.Add("CGPA", OracleDbType.BinaryFloat, 22).Value = Cgpatxt.Text;
                    cmd.Parameters.Add("CREDIT_COMPLETED", OracleDbType.Int32, 5).Value = Crtxt.Text;
                    cmd.Parameters.Add("S_EMAIL", OracleDbType.Varchar2, 30).Value = Emailtxt.Text;
                    cmd.Parameters.Add("CITY", OracleDbType.Varchar2, 10).Value = Citytxt.Text;
                    break;
                case 1:
                    msg = "Row Updated Successfully";

                    cmd.Parameters.Add("S_NAME", OracleDbType.Varchar2, 30).Value = Nametxt.Text;
                    cmd.Parameters.Add("CGPA", OracleDbType.Double, 10).Value = Cgpatxt.Text;
                    cmd.Parameters.Add("CREDIT_COMPLETED", OracleDbType.Int32, 5).Value = Crtxt.Text;
                    cmd.Parameters.Add("S_EMAIL", OracleDbType.Varchar2, 30).Value = Emailtxt.Text;
                    cmd.Parameters.Add("CITY", OracleDbType.Varchar2, 30).Value = Citytxt.Text;

                    cmd.Parameters.Add("S_ID", OracleDbType.Int32, 10).Value = Idtxt.Text;
                    break;
                case 2:
                    msg = "Row Deleted Successfully";
                    cmd.Parameters.Add("S_ID", OracleDbType.Int32, 10).Value = Idtxt.Text;
                    break;
            }

            try
            {
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show(msg);
                    this.UpdateStudentGridView();
                }
            }
            catch (Exception exc) { }
        }

        private void StudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (StudentGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    return;
                }
                else
                {

                    StudentGridView.CurrentRow.Selected = true;

                    Idtxt.Text = StudentGridView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    Nametxt.Text = StudentGridView.Rows[e.RowIndex].Cells["NAME"].FormattedValue.ToString();
                    Cgpatxt.Text = StudentGridView.Rows[e.RowIndex].Cells["CGPA"].FormattedValue.ToString();
                    Crtxt.Text = StudentGridView.Rows[e.RowIndex].Cells["CREDIT_COMPLETED"].FormattedValue.ToString();
                    Emailtxt.Text = StudentGridView.Rows[e.RowIndex].Cells["S_EMAIL"].FormattedValue.ToString();
                    Citytxt.Text = StudentGridView.Rows[e.RowIndex].Cells["CITY"].FormattedValue.ToString();

                    Idtxt.Enabled = false;
                    Updatebtn.Enabled = true;
                    Deletebtn.Enabled = true;
                    Addbtn.Enabled = false;


                }
            }

            catch (Exception ex)
            {

            }

        }
        public void Check()
        {
            if (Idtxt.Text == "" || Nametxt.Text == "" || Cgpatxt.Text == "" || Crtxt.Text == "" || Emailtxt.Text == "" || Citytxt.Text == "")
            {
                MessageBox.Show("Fields Cannot Be Empty");
            }
            else { 
            for (int item = 0; item < StudentGridView.Rows.Count; item++)
            {
                if (Idtxt.Text == StudentGridView.Rows[item].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Warning.!! ID Already Exist");
                    return;
                }
            }
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
           // this.Check();
            String sql = "INSERT INTO STUDENTS(S_ID,S_NAME,CGPA,CREDIT_COMPLETED,S_EMAIL,CITY)" +
                          "VALUES(:S_ID,:S_NAME,:CGPA,:CREDIT_COMPLETED,:S_EMAIL,:CITY)";
            this.CrudOperation(sql, 0);
           
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            String sql1 = "UPDATE STUDENTS SET S_NAME=:S_NAME,CGPA=:CGPA,CREDIT_COMPLETED=:CREDIT_COMPLETED,S_EMAIL=:S_EMAIL,CITY=:CITY WHERE S_ID=:S_ID";
            this.CrudOperation(sql1, 1);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                // do what u want
                String sql = "DELETE FROM STUDENTS WHERE S_ID=:S_ID";
                this.CrudOperation(sql, 2);
            }
            else
            {
                MessageBox.Show("Your data not deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Idtxt.Text = "";
            Nametxt.Text = "";
            Cgpatxt.Text = "";
            Crtxt.Text = "";
            Emailtxt.Text = "";
            Citytxt.Text = "";

            Updatebtn.Enabled = false;
            Deletebtn.Enabled = false;
            Addbtn.Enabled = true;
            Idtxt.Enabled = true;
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = orc_conn.CreateCommand();

            cmd.CommandText = "SELECT S_ID ID,S_NAME NAME,CGPA,CREDIT_COMPLETED,S_EMAIL,CITY FROM STUDENTS WHERE " + Combo.Text + " LIKE '" + Searchtxt.Text + "%'";
            cmd.CommandType = CommandType.Text;

            OracleDataReader OracleDatar = cmd.ExecuteReader();
            System.Data.DataTable d_tab = new System.Data.DataTable();

            d_tab.Load(OracleDatar);
            StudentGridView.DataSource = d_tab.DefaultView;
            OracleDatar.Close();
        }

        private void CrudStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.STUDENTS' table. You can move, or remove it, as needed.
            this.sTUDENTSTableAdapter.Fill(this.dataSet1.STUDENTS);

        }
    }
}
