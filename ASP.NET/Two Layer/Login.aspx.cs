using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Two_Layer
{
    public partial class Login : System.Web.UI.Page
    {
        ConnectionCls objcls = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strsel = "select count(id) from TowLayerTab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "';";
            string cid = objcls.Scalar_Fn(strsel);
            if (cid == "1")
            {
                string getid = "select id from TowLayerTab where username='" + TextBox1.Text + "' and password ='" + TextBox2.Text + "';";
                string id = objcls.Scalar_Fn(getid);
                Session["uid"] = id;
                Response.Redirect("ProfileView.aspx");
                //Label1.Text = "Login successfull.";
            }
            else
            {
                Label1.Text = "Login failed.";
            }
        }
    }
}