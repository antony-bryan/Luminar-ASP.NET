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
    public partial class ProfileView : System.Web.UI.Page
    {
        ConnectionCls objcls = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select name,age,address,photo from TowLayerTab where id='" + Session["uid"] + "';";
            SqlDataReader dr = objcls.Reader_Fn(sel);
            while (dr.Read())
            {
                TextBox1.Text = dr["Name"].ToString();
                TextBox2.Text = dr["Age"].ToString();
                TextBox3.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }
            DataSet ds = objcls.Adapter_Fn(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataTable dt = objcls.ExeDataTable_Fn(sel);
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
    }
}