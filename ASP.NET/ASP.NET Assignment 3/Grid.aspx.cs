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
    public partial class Grid : System.Web.UI.Page
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
            string strsel = "select * from RegDetails;";
            SqlDataAdapter da = new SqlDataAdapter(strsel, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e) // e = row index
        {
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex]; //rw=1
            Label1.Text = rw.Cells[2].Text;
            Label2.Text = rw.Cells[3].Text;
            Label3.Text = rw.Cells[4].Text;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            String del = "delete from RegDetails where id=" + getid + ";";
            SqlCommand cmd = new SqlCommand(del, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Bind_grid(); // to see the updated table.
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind_grid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Bind_grid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtag = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox txtaddr = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            string strup = "update RegDetails set Age=" + txtag.Text + ",address='" + txtaddr.Text + "' where id=" + getid + ";";
            SqlCommand cmd = new SqlCommand(strup, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            GridView1.EditIndex = -1;
            Bind_grid();


        }
    }
}