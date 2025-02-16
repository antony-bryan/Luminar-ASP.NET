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
    public partial class ViewUserProfile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=BRY\SQLEXPRESS;database=ASPExample;integrated security = true;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strsel = "select name,age,address,phone,photo from RegDetails where id='" + Session["uid"] + "';";

                SqlCommand cmd = new SqlCommand(strsel, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr["name"].ToString();
                    TextBox2.Text = dr["age"].ToString();
                    TextBox3.Text = dr["address"].ToString();
                    TextBox4.Text = dr["phone"].ToString();
                    Image1.ImageUrl = dr["photo"].ToString();
                }
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strsel = "update RegDetails set age='" + TextBox2.Text + "',address='" + TextBox3.Text + "' where id='" + Session["uid"] + "';";
            SqlCommand cmd = new SqlCommand(strsel, con);
            con.Open();
            int ra = cmd.ExecuteNonQuery();
            con.Close();
            if(ra == 1)
            {
                Label6.Text = "Success.";
            }
            else
            {
                Label6.Text = "Failed.";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }
    }
}