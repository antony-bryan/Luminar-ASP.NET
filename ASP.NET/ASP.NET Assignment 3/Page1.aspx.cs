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
    public partial class Page1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=BRY\SQLEXPRESS;database=ASPExample;Integrated security = true;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            TextBox9.Text = TextBox1.Text;   //name
            TextBox10.Text = TextBox2.Text;  //age
            TextBox11.Text = TextBox3.Text;  //address
            TextBox12.Text = TextBox4.Text;  //phone
            TextBox13.Text = TextBox5.Text;  //email
            TextBox14.Text = RadioButtonList1.SelectedItem.Text;  //gender
            TextBox15.Text = DropDownList1.SelectedItem.Text; //state

            string s = "";
            for(int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    s = s + CheckBoxList1.Items[i].Text + ",";
                }
            }
            TextBox16.Text = s; //qualification

            string pa = "~/PHS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(pa));
            Image1.ImageUrl = pa; //image

            TextBox18.Text = TextBox6.Text;  //username
            TextBox19.Text = TextBox8.Text;  //password

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string pa = "~/PHSDB/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(pa));

            string result = "";
            for(int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if(CheckBoxList1.Items[i].Selected)
                {
                    result = result + CheckBoxList1.Items[i].Text + ", ";
                }
            }

            string str = "insert into RegDetails values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + RadioButtonList1.SelectedItem.Text + "','" + DropDownList1.SelectedItem.Text + "','" + result + "','" + pa + "','" + TextBox6.Text + "','" + TextBox7.Text + "');";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            int ra = cmd.ExecuteNonQuery();
            con.Close();
            if(ra == 1)
            {
                Label25.Text = "Inserted successfully.";
            }

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            string strsel = "select count(id) from RegDetails where username='" + TextBox6.Text + "';";
            SqlCommand cmd = new SqlCommand(strsel, con);
            con.Open();
            string cid = cmd.ExecuteScalar().ToString();
            con.Close();
            int x = Convert.ToInt32(cid);
            if (x >= 1)
            {
                Label26.Visible = true;
                Label26.Text = "Username already in use.";
            }
            else
            {
                Label26.Visible = false;
            }
        }
    }
}