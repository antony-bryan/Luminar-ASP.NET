﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConCls
    {
        SqlConnection con;
        SqlCommand cmd;

        public ConCls()
        {
            con = new SqlConnection(@"server=BRY\SQLEXPRESS;database=TwoLayerDB;integrated security = true;");
        }

        public int NonQuery_Fn(string sqlqry)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlqry, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string Scalar_Fn(string sqlqry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlqry, con);
            con.Open();
            string i = cmd.ExecuteScalar().ToString();
            con.Close();
            return i;
        }
        public SqlDataReader Reader_Fn(string sqlqry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlqry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataSet Adapter_Fn(string sqlqry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlqry, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataTable ExeDataTable_Fn(string sqlqry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
