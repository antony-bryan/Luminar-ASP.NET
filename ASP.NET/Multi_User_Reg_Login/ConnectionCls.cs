using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Multi_User_Reg_Login
{
    public class ConnectionCls
    {
        SqlConnection con;
        SqlCommand cmd;

        public ConnectionCls()
        {
            con = new SqlConnection(@"server=BRY\SQLEXPRESS;database=TwoLayerDB;integrated security = true;");
        }
        public int NonQuery_Fn(string sqlquery)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public string Scalar_Fn(string sqlquery)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string i = cmd.ExecuteScalar().ToString();
            con.Close();
            return i;
        }
    }
}