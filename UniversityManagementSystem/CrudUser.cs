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
    public partial class CrudUser : Form
    {
        OracleConnection orc_conn = null;
        public CrudUser()
        {
            this.SetConnection();
            InitializeComponent();
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
        public void UpdateUserGridView()
        {
            OracleCommand cmd = orc_conn.CreateCommand();

            cmd.CommandText = "SELECT ID,USER_NAME,PASSWORD FROM IDENTIFY ORDER BY ID DESC";
            cmd.CommandType = CommandType.Text;

            OracleDataReader odr = cmd.ExecuteReader();
            System.Data.DataTable d_tab = new System.Data.DataTable();

            d_tab.Load(odr);

            UserGridView.DataSource = d_tab.DefaultView;


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
                    cmd.Parameters.Add("ID", OracleDbType.Int32, 20).Value = UidTxt.Text;
                    cmd.Parameters.Add("USER_NAME", OracleDbType.Varchar2, 30).Value = UnameTxt.Text;
                    cmd.Parameters.Add("PASSWORD", OracleDbType.Varchar2, 40).Value = UpassTxt.Text;

                    break;
                case 1:
                    msg = "Row Updated Successfully";

                    cmd.Parameters.Add("USER_NAME", OracleDbType.Varchar2, 30).Value = UnameTxt.Text;
                    cmd.Parameters.Add("PASSWORD", OracleDbType.Varchar2, 40).Value = UpassTxt.Text;

                    cmd.Parameters.Add("ID", OracleDbType.Int32, 20).Value = UidTxt.Text;
                    break;
                case 2:
                    msg = "Row Deleted Successfully";
                    cmd.Parameters.Add("ID", OracleDbType.Int32, 20).Value = UidTxt.Text;
                    break;
            }

            try
            {
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show(msg);
                    this.UpdateUserGridView();
                }
            }
            catch (Exception exc) { }
        }

        private void UserGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (UserGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    return;
                }
                else
                {

                    UserGridView.CurrentRow.Selected = true;

                    UidTxt.Text = UserGridView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    UnameTxt.Text = UserGridView.Rows[e.RowIndex].Cells["USER_NAME"].FormattedValue.ToString();
                    UpassTxt.Text = UserGridView.Rows[e.RowIndex].Cells["PASSWORD"].FormattedValue.ToString();

                    UidTxt.Enabled = false;
                    UupdateBtn.Enabled = true;
                    UdeleteBtn.Enabled = true;
                    UaddBtn.Enabled = false;


                }
            }

            catch (Exception ex)
            {

            }

        }

        private void UaddBtn_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO IDENTIFY(ID,USER_NAME,PASSWORD)" +
                         "VALUES(:ID,:USER_NAME,:PASSWORD)";
            this.CrudOperation(sql, 0);
        }

        private void UupdateBtn_Click(object sender, EventArgs e)
        {
            String sql1 = "UPDATE IDENTIFY SET USER_NAME=:USER_NAME,PASSWORD=:PASSWORD WHERE ID=:ID";
            this.CrudOperation(sql1, 1);

        }

        private void UdeleteBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                // do what u want
                String sql = "DELETE FROM IDENTIFY WHERE ID=:ID";
                this.CrudOperation(sql, 2);
            }
            else
            {
                MessageBox.Show("Your data not deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void UclearBtn_Click(object sender, EventArgs e)
        {
            UidTxt.Text = "";
            UnameTxt.Text = "";
            UpassTxt.Text = "";

            UupdateBtn.Enabled = false;
            UdeleteBtn.Enabled = false;
            UaddBtn.Enabled = true;
            UidTxt.Enabled = true;

        }

        private void CrudUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.IDENTIFY' table. You can move, or remove it, as needed.
            this.iDENTIFYTableAdapter.Fill(this.dataSet3.IDENTIFY);

        }
    }

}
