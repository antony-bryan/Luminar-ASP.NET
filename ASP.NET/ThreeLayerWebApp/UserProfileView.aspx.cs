using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

namespace ThreeLayerWebApp
{
    public partial class UserProfileView : System.Web.UI.Page
    {
        UserProfileViewCls objbll = new UserProfileViewCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["uid"]);
            SqlDataReader dr = objbll.UserProfileView_Data(id);
            while (dr.Read())
            {
                Label1.Text = dr["Name"].ToString();
                Label2.Text = dr["Age"].ToString();
                Label3.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }
        }
    }
}