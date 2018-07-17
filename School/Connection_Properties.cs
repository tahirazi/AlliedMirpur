using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace School
{
    class Connection_Properties
    {

        public static string SrvName = @".";
        public static string DbName = @"school";
        // public static string integeratedsecurity = "SSPI";
        //public static string perstsecurity = "True";
        public static string UsrName = "sa";


        public static string Pasword = "123";

        public static string GetConnectionString()
        {
            return "Data Source=" + SrvName + "; initial catalog=" + DbName + "; User ID=" + UsrName + "; Password=" + Pasword + ";";
        }
    }
    public partial class conn
    {
        public void con()
        {
            SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        }
        public void cmd()
        {
            SqlCommand cmd = new SqlCommand();
            
        }
    }
}
