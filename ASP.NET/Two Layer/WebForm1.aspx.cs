using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Two_Layer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ConnectionCls objcls = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pa = "~/PHS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(pa));

            string strinsert = "insert into TowLayerTab values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + pa + "','" + TextBox4.Text + "','" + TextBox5.Text + "');";
            int ra = objcls.NonQuery_Fn(strinsert);
            if(ra == 1)
            {
                Label1.Text = "Inserted";
            }
        }
    }
}