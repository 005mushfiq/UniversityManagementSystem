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
    public partial class CrudTeacher : Form
    {
        OracleConnection orc_conn = null;
        public CrudTeacher()
        {
            this.SetConnection();
            InitializeComponent();
            this.UpdateTeacherGridView();
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
        public void UpdateTeacherGridView()
        {
            OracleCommand cmd = orc_conn.CreateCommand();

            cmd.CommandText = "SELECT T_ID,T_NAME,JOIN_DATE,PRIMARY_PHO_NO,T_EMAIL FROM TEACHERS ORDER BY T_ID DESC";
            cmd.CommandType = CommandType.Text;

            OracleDataReader tdr = cmd.ExecuteReader();
            System.Data.DataTable t_tab = new System.Data.DataTable();

            t_tab.Load(tdr);

            TeacherGridView.DataSource = t_tab.DefaultView;


            tdr.Close();
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
                    cmd.Parameters.Add("T_ID", OracleDbType.Int32, 10).Value = tidtxt.Text;
                    cmd.Parameters.Add("T_NAME", OracleDbType.Varchar2, 30).Value = tnametxt.Text;
                    cmd.Parameters.Add("JOIN_DATE", OracleDbType.Date, 160).Value = tdate.Value;
                    cmd.Parameters.Add("PRIMARY_PHO_NO", OracleDbType.Int32, 15).Value = tphonetxt.Text;
                    cmd.Parameters.Add("T_EMAIL", OracleDbType.Varchar2, 30).Value = temailtxt.Text;
                    break;
                case 1:
                    msg = "Row Updated Successfully";

                    cmd.Parameters.Add("T_NAME", OracleDbType.Varchar2, 30).Value = tnametxt.Text;
                    cmd.Parameters.Add("JOIN_DATE", OracleDbType.Date, 160).Value = tdate.Value;
                    cmd.Parameters.Add("PRIMARY_PHO_NO", OracleDbType.Int32, 15).Value = tphonetxt.Text;
                    cmd.Parameters.Add("T_EMAIL", OracleDbType.Varchar2, 30).Value = temailtxt.Text;

                    cmd.Parameters.Add("T_ID", OracleDbType.Int32, 10).Value = tidtxt.Text;
                    break;
                case 2:
                    msg = "Row Deleted Successfully";
                    cmd.Parameters.Add("T_ID", OracleDbType.Int32, 10).Value = tidtxt.Text;
                    break;
            }

            try
            {
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show(msg);
                    this.UpdateTeacherGridView();
                }
            }
            catch (Exception exc) { }
        }

        private void TeacherGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (TeacherGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    return;
                }
                else
                {

                    TeacherGridView.CurrentRow.Selected = true;

                    tidtxt.Text = TeacherGridView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    tnametxt.Text = TeacherGridView.Rows[e.RowIndex].Cells["NAME"].FormattedValue.ToString();
                    tdate.Text = TeacherGridView.Rows[e.RowIndex].Cells["JOIN_DATE"].FormattedValue.ToString();
                    tphonetxt.Text = TeacherGridView.Rows[e.RowIndex].Cells["PRIMARY_PHO_NO"].FormattedValue.ToString();
                    temailtxt.Text = TeacherGridView.Rows[e.RowIndex].Cells["T_EMAIL"].FormattedValue.ToString();

                    tidtxt.Enabled = false;
                    tupdatebtn.Enabled = true;
                    tdeletebtn.Enabled = true;
                    taddbtn.Enabled = false;


                }
            }

            catch (Exception ex)
            {

            }

        }
        public void Check()
        {
            if (tidtxt.Text == "" || tnametxt.Text == "" || tdate.Text == "" || tphonetxt.Text == "" || temailtxt.Text == "")
            {
                MessageBox.Show("Fields Cannot Be Empty");
            }
            else
            {
                for (int item = 0; item < TeacherGridView.Rows.Count; item++)
                {
                    if (tidtxt.Text == TeacherGridView.Rows[item].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Warning.!! ID Already Exist");
                        return;
                    }

                }
            }
        }

       

        private void tupdatebtn_Click(object sender, EventArgs e)
        {
            //UPDATE TEACHERS SET T_NAME='XIAN',JOIN_DATE=to_date('10-05-2012','dd-mm- yyyy'),PRIMARY_PHO_NO=01700000441,T_EMAIL='XI@GMAIL.COM' WHERE T_ID=111;
            String sql = "UPDATE TEACHERS SET T_NAME=:T_NAME,JOIN_DATE=to_date(:JOIN_DATE, 'dd-mm- yyyy'),PRIMARY_PHO_NO:=PRIMARY_PHO_NO,T_EMAIL=:T_EMAIL WHERE T_ID=:T_ID";
            this.CrudOperation(sql, 1);

        }

        private void tdeletebtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                // do what u want
                String sql = "DELETE FROM TEACHERS WHERE T_ID=:T_ID";
                this.CrudOperation(sql, 2);
            }
            else
            {
                MessageBox.Show("Your data not deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tclearbtn_Click(object sender, EventArgs e)
        {
            tidtxt.Text = "";
            tnametxt.Text = "";
            tphonetxt.Text = "";
            temailtxt.Text = "";

            tupdatebtn.Enabled = false;
            tdeletebtn.Enabled = false;
            taddbtn.Enabled = true;
            tidtxt.Enabled = true;

        }

        private void tsearchtxt_TextChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = orc_conn.CreateCommand();

            cmd.CommandText = "SELECT T_ID ID,T_NAME NAME,JOIN_DATE,PRIMARY_PHO_NO,T_EMAIL FROM TEACHERS WHERE " + tcombo.Items + " LIKE '" + tsearchtxt.Text + "%'";
            cmd.CommandType = CommandType.Text;

            OracleDataReader OracleDatar = cmd.ExecuteReader();
            System.Data.DataTable d_tab = new System.Data.DataTable();

            d_tab.Load(OracleDatar);
            TeacherGridView.DataSource = d_tab.DefaultView;
            OracleDatar.Close();
        }

        private void CrudTeacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.TEACHERS' table. You can move, or remove it, as needed.
            this.tEACHERSTableAdapter.Fill(this.dataSet2.TEACHERS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Check();
            String sql = "INSERT INTO TEACHERS(T_ID,T_NAME,JOIN_DATE,PRIMARY_PHO_NO,T_EMAIL)" +
                         "VALUES(:T_ID,:T_NAME, to_date(:JOIN_DATE, 'dd-mm- yyyy'),:PRIMARY_PHO_NO,:T_EMAIL)";
            //INSERT INTO TEACHERS(T_ID,T_NAME,JOIN_DATE,PRIMARY_PHO_NO,T_EMAIL)
            //VALUES(110, 'NASEM', to_date('10-05-2012', 'dd-mm- yyyy'), 017244222, 'NA@GMAIL.COM')
            this.CrudOperation(sql, 0);
        }
    }
}
