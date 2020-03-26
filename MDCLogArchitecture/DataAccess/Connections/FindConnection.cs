using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MDCLogArchitecture.DataAccess.Connections
{
    public class FindConnection
    {

        public SqlConnection GetConnection() {
            SqlConnection conn = new SqlConnection(@"Server =DESKTOP-KH6A94U; Database = WORK; Trusted_Connection = True;");
            return conn;
       
        }
        
    }
}
