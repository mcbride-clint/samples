using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Text;

namespace MDCLogArchitecture.DataAccess.Connections
{
    public class FindConnection
    {

        public SqlConnection GetConnection() {
            //SqlConnection conn = new SqlConnection(@"Server =DESKTOP-KH6A94U; Database = WORK; Trusted_Connection = True;");
            SqlConnection conn = new SqlConnection(@"Server = DESKTOP-UV36790\SQLDRA; Database = MDC; Trusted_Connection = True;");
            return conn;
       
        }
        
    }
}
