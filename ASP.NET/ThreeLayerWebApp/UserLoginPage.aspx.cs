using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace ThreeLayerWebApp
{
    public partial class UserLoginPage : System.Web.UI.Page
    {
        UserLoginCls objbll = new UserLoginCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cid = objbll.LoginDB(TextBox1.Text, TextBox2.Text);
            int j = Convert.ToInt32(cid);
            if(j == 1)
            {
                string id = objbll.GetUserId(TextBox1.Text, TextBox2.Text);
                Session["uid"] = id;
                Response.Redirect("UserProfileView.aspx");               
                //Label1.Text = "Login Successful.";
            }
            else
            {
                Label1.Text = "Login Failed.";
            }
        }
    }
}