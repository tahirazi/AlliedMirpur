using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace School
{
    class Class1
    {
        SqlConnection con = new SqlConnection(Connection_Properties.GetConnectionString());
        public void savestudentinfo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into stdBasic values ()";
        }
    }
}
