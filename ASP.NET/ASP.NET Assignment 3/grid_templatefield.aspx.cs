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
    public partial class grid_templatefield : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=BRY\SQLEXPRESS;database=ASPExample;integrated security = true;");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_grid();
            }
        }

        public void Bind_grid()
        {
            string sel = "select * from RegDetails";
            SqlDataAdapter da = new SqlDataAdapter(sel, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int newid = Convert.ToInt32(e.CommandArgument);
            string del = "delete from RegDetails where id = " + newid + ";";
            SqlCommand cmd = new SqlCommand(del, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Bind_grid();
        }
    }
}