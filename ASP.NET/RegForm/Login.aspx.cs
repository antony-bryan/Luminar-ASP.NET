using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace RegForm
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=BRY\SQLEXPRESS;database=Practice;integrated security = true;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strsel = "select count(id) from RegDetails1 where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "';";
            SqlCommand cmd = new SqlCommand(strsel, con);
            con.Open();
            string cid = cmd.ExecuteScalar().ToString();
            con.Close();
            if(cid == "1")
            {
                Response.Redirect("ViewUserProfile.aspx");
                //Label3.Text = "login in successful.";
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "login in failed.";
            }
        }
    }
}