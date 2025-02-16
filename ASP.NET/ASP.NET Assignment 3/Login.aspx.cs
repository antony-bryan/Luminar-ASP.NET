using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ASP.NET_Assignment_3
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=BRY\SQLEXPRESS;database=ASPExample;integrated security = true;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strsel = "select count(id) from RegDetails where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "';";
            SqlCommand cmd = new SqlCommand(strsel, con); //cmd has the query in it.
            con.Open();
            string cid = cmd.ExecuteScalar().ToString();
            con.Close();
            if(cid == "1")
            { 
                string strselid = "select id from RegDetails where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "';";
                SqlCommand cmd1 = new SqlCommand(strselid, con);
                con.Open();
                string id = cmd1.ExecuteScalar().ToString();
                con.Close();
                Session["uid"] = id;
                Response.Redirect("ViewUserProfile.aspx");
                //Label3.Text = "Success.";
            }
            else
            {
                Label3.Text = "Invalid username and password.";
            }

        }
    }
}