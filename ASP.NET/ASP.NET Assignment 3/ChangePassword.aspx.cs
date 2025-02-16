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
    public partial class ChangePassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=BRY\SQLEXPRESS;database=ASPExample;integrated security = true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strsel = "select password from RegDetails where id='" + Session["uid"] + "';";
                SqlCommand cmd = new SqlCommand(strsel, con);
                con.Open();
                string old_pwd = cmd.ExecuteScalar().ToString();
                con.Close();
                TextBox1.Text = old_pwd;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strsel = "update RegDetails set password='" + TextBox3.Text + "' where id='"+Session["uid"]+"';";
            SqlCommand cmd = new SqlCommand(strsel, con);
            con.Open();
            int ra = cmd.ExecuteNonQuery();
            con.Close();
            if(ra == 1)
            {
                Label1.Visible = true;
                Label1.Text = "New password saved.";
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Unable to change password.";
            }
        }
    }
}