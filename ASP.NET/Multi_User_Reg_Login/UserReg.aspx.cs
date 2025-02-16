using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Multi_User_Reg_Login
{
    public partial class UserReg : System.Web.UI.Page
    {
        ConnectionCls obj = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from Login_Tab;";
            string maxregid = obj.Scalar_Fn(sel);
            int reg_id = 0;
            if(maxregid == "")
            {
                reg_id = 0;
            }
            else
            {
                int newregid = Convert.ToInt32(maxregid);
                reg_id = newregid + 1;
            }
            string ins_user = "insert into User_Reg_Tab values(" + reg_id + ",'" + TextBox1.Text + "'," + TextBox2.Text + ");";
            int ra = obj.NonQuery_Fn(ins_user);
            if(ra == 1)
            {
                string ins_login = "insert into Login_Tab values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','User','Active');";
                int ra1 = obj.NonQuery_Fn(ins_login);
            }
        }
    }
}