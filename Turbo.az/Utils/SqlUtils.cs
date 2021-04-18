using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az.Utils
{
    class SqlUtils
    {
        private static SqlUtils sqlUtils;
        public  string conString { get; set; }
        private SqlUtils()
        {
            conString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
        }
        public static SqlUtils GetInstance()
        {
            if (sqlUtils == null)
            {
                sqlUtils = new SqlUtils();
            }
            return sqlUtils;
        }
        public  DataTable GetDataWithAdapter(string _query)
        {
            SqlConnection sqlCon = new SqlConnection(conString);
            SqlDataAdapter adapter = new SqlDataAdapter(_query,sqlCon);
            DataTable dtTable = new DataTable();
            adapter.Fill(dtTable);
            return dtTable;
        }
        
    }
}
