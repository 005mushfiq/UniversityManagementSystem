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
    public partial class CrudLibrary : Form
    {
        OracleConnection orc_conn = null;
        public CrudLibrary()
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
        public void UpdateBooksGridView()
        {
            OracleCommand cmd = orc_conn.CreateCommand();

            cmd.CommandText = "SELECT BOOK_ID,BOOK_NAME,AUTHOR,CATEGORY,NO_OF_COPIES,AVAILABILITY_OF_BOOK FROM BOOKS ORDER BY BOOK_ID DESC";
            cmd.CommandType = CommandType.Text;

            OracleDataReader odr = cmd.ExecuteReader();
            System.Data.DataTable d_tab = new System.Data.DataTable();

            d_tab.Load(odr);

            BooksGridView.DataSource = d_tab.DefaultView;


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
                    cmd.Parameters.Add("BOOK_ID", OracleDbType.Int32, 10).Value = BidTxt.Text;
                    cmd.Parameters.Add("BOOK_NAME", OracleDbType.Varchar2, 200).Value = BnameTxt.Text;
                    cmd.Parameters.Add("AUTHOR", OracleDbType.Varchar2, 200).Value = BauthorTxt.Text;
                    cmd.Parameters.Add("CATEGORY", OracleDbType.Varchar2, 80).Value = BcateTxt.Text;
                    cmd.Parameters.Add("NO_OF_COPIES", OracleDbType.Int32, 10).Value = BcopyTxt.Text;
                    cmd.Parameters.Add("AVAILABILITY_OF_BOOK", OracleDbType.Varchar2, 10).Value = comboBox1.Items;

                    break;
                case 1:
                    msg = "Row Updated Successfully";

                    cmd.Parameters.Add("BOOK_NAME", OracleDbType.Varchar2, 200).Value = BnameTxt.Text;
                    cmd.Parameters.Add("AUTHOR", OracleDbType.Varchar2, 200).Value = BauthorTxt.Text;
                    cmd.Parameters.Add("CATEGORY", OracleDbType.Varchar2, 80).Value = BcateTxt.Text;
                    cmd.Parameters.Add("NO_OF_COPIES", OracleDbType.Int32, 10).Value = BcopyTxt.Text;
                    cmd.Parameters.Add("AVAILABILITY_OF_BOOK", OracleDbType.Varchar2, 10).Value = comboBox1.Text;

                    cmd.Parameters.Add("BOOK_ID", OracleDbType.Int32, 10).Value = BidTxt.Text;
                    break;
                case 2:
                    msg = "Row Deleted Successfully";
                    cmd.Parameters.Add("BOOK_ID", OracleDbType.Int32, 10).Value = BidTxt.Text;
                    break;
            }

            try
            {
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show(msg);
                    this.UpdateBooksGridView();
                }
            }
            catch (Exception exc) { }
        }

        private void BooksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (BooksGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    return;
                }
                else
                {

                    BooksGridView.CurrentRow.Selected = true;

                    BidTxt.Text = BooksGridView.Rows[e.RowIndex].Cells["BOOK_ID"].FormattedValue.ToString();
                    BnameTxt.Text = BooksGridView.Rows[e.RowIndex].Cells["BOOK_NAME"].FormattedValue.ToString();
                    BauthorTxt.Text = BooksGridView.Rows[e.RowIndex].Cells["AUTHOR"].FormattedValue.ToString();
                    BcateTxt.Text = BooksGridView.Rows[e.RowIndex].Cells["CATEGORY"].FormattedValue.ToString();
                    BcopyTxt.Text = BooksGridView.Rows[e.RowIndex].Cells["NO_OF_COPIES"].FormattedValue.ToString();
                    comboBox1.Text = BooksGridView.Rows[e.RowIndex].Cells["AVAILABILITY_OF_BOOK"].FormattedValue.ToString();

                    BidTxt.Enabled = false;
                    BupdateBtn.Enabled = true;
                    BdeleteBtn.Enabled = true;
                    BaddBtn.Enabled = false;


                }
            }

            catch (Exception ex)
            {

            }

        }

        private void BaddBtn_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO BOOKS(BOOK_ID,BOOK_NAME,AUTHOR,CATEGORY,NO_OF_COPIES,AVAILABILITY_OF_BOOK)" +
                        "VALUES(:BOOK_ID,:BOOK_NAME,:AUTHOR,:CATEGORY,:NO_OF_COPIES,:AVAILABILITY_OF_BOOK)";
            this.CrudOperation(sql, 0);

        }

        private void BupdateBtn_Click(object sender, EventArgs e)
        {
            String sql1 = "UPDATE BOOKS SET BOOK_NAME=:BOOK_NAME,AUTHOR=:AUTHOR,CATEGORY=:CATEGORY,NO_OF_COPIES=:NO_OF_COPIESAVAILABILITY_OF_BOOK=,:AVAILABILITY_OF_BOOK WHERE BOOK_ID=:BOOK_ID";
            this.CrudOperation(sql1, 1);
        }

        private void BdeleteBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                // do what u want
                String sql = "DELETE FROM BOOKS WHERE BOOK_ID=:BOOK_ID";
                this.CrudOperation(sql, 2);
            }
            else
            {
                MessageBox.Show("Your data not deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BclearBtn_Click(object sender, EventArgs e)
        {
            BidTxt.Text = "";
            BnameTxt.Text = "";
            BauthorTxt.Text = "";
            BcateTxt.Text = "";
            BcopyTxt.Text = "";
            comboBox1.Text = "";

            BupdateBtn.Enabled = false;
            BdeleteBtn.Enabled = false;
            BaddBtn.Enabled = true;
            BidTxt.Enabled = true;
        }

        private void CrudLibrary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet4.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.dataSet4.BOOKS);

        }
    }
}
