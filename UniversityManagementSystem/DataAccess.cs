using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    public class DataAccess
    {
        private OracleConnection oraclecon;

        public OracleConnection Oraclecon
        {
            get { return oraclecon; }
            set { oraclecon = value; }
        }

        private OracleCommand oraclecom;

        public OracleCommand Oraclecom
        {
            get { return oraclecom; }
            set { oraclecom = value; }
        }

        private OracleDataAdapter sda;
        public OracleDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        //internal DataTable dt;

        public DataAccess()
        {
         
            this.Oraclecon = new OracleConnection(@"TNS_ADMIN=C:\oraclexe\app\oracle\product\10.2.0\server\NETWORK\ADMIN;USER ID=UMS;PASSWORD=sagor;DATA SOURCE=XE;PERSIST SECURITY INFO=True");
            Oraclecon.Open();

        }

        private void QueryText(string query)
        {
            this.Oraclecom = new OracleCommand(query, this.Oraclecon);

        }

        public DataSet ExecuteQuery(string Oracle)
        {
            this.QueryText(Oracle);
            this.Sda = new OracleDataAdapter(this.Oraclecom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds;
        }

        public int ExecuteUpdateQuery(string Oracle)
        {
            this.QueryText(Oracle);
            int u = this.Oraclecom.ExecuteNonQuery();
            return u;
        }
    }
}
