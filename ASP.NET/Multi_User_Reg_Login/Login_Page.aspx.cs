using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Multi_User_Reg_Login
{
    public partial class Login_Page : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select count(Reg_Id) from Login_Tab where Username='" + TextBox3.Text + "' and password='" + TextBox4.Text + "';";
            string cid = obj.Scalar_Fn(sel);
            if(cid == "1")
            {
                string selregid = "select Reg_Id from Login_Tab where Username ='" + TextBox3.Text + "' and password='" + TextBox4.Text + "';";
                string reg_id = obj.Scalar_Fn(selregid);
                Session["reg_id"] = reg_id;

                string sellogtype = "select Log_Type from Login_Tab where Username='" + TextBox3.Text + "' and Password='" + TextBox4.Text + "';";
                string log_type = obj.Scalar_Fn(sellogtype);
                if(log_type == "Admin")
                {
                    Label1.Text = "Admin";
                }
                else
                {
                    Label1.Text = "User";
                }
            }
            else
            {
                Label1.Text = "Login failed";
            }
        }
    }
}