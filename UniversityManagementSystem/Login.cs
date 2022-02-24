using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                 try
                  {
                string query = "SELECT ID,PASSWORD FROM IDENTIFY WHERE ID='" + textBox1.Text + "' AND PASSWORD='" + textBox2.Text + "'";
                //SELECT ID,PASSWORD FROM IDENTIFY WHERE ID=1101 AND PASSWORD='s1122'
                OracleConnection conn = new OracleConnection(@"TNS_ADMIN=C:\oraclexe\app\oracle\product\10.2.0\server\NETWORK\ADMIN;USER ID=UMS;PASSWORD=sagor;DATA SOURCE=XE;PERSIST SECURITY INFO=True");
                OracleDataAdapter oda = new OracleDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                oda.Fill(dt);
                if (dt.Rows.Count == 1) //this.da.ExecuteUpdateQuery(query) > 0
                {
                   //  MessageBox.Show("Success ! Matched");
                    Dashboard d1 = new Dashboard();
                    d1.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Id or Password not Match");
                }

                  }
                  catch (Exception exc) { }

            }
            else
            {
                MessageBox.Show("Warning.! Id or Password Field cannot be Empty");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
