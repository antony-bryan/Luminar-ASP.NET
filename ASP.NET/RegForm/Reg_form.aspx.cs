using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace RegForm
{
    public partial class Reg_form : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=BRY\SQLEXPRESS;database=Practice;integrated security = true;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            TextBox9.Text = TextBox1.Text;
            TextBox10.Text = TextBox2.Text;
            TextBox11.Text = TextBox3.Text;
            TextBox12.Text = TextBox4.Text;
            TextBox13.Text = TextBox5.Text;
            TextBox14.Text = RadioButtonList1.SelectedItem.Text;
            TextBox15.Text = DropDownList1.SelectedItem.Text;

            string r = "";
            for(int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    r += CheckBoxList1.Items[i].Text + ", ";
                }
            }
            TextBox16.Text = r;

            string pa = "~/PHS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(pa));

            Image1.ImageUrl = pa;

            TextBox18.Text = TextBox6.Text;
            TextBox19.Text = TextBox8.Text;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string r = "";
            for(int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    r += CheckBoxList1.Items[i].Text + ", ";
                }
            }

            string pa = "~/PHS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(pa));

            string str = "insert into RegDetails1 values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + RadioButtonList1.SelectedItem.Text + "','" + DropDownList1.SelectedItem.Text + "','"+r+"','"+pa+"','"+TextBox6.Text+"','"+TextBox7.Text+"');";
            SqlCommand cmd = new SqlCommand(str, con); // cmd has the query in it
            con.Open();
            int ra = cmd.ExecuteNonQuery();
            con.Close();
            if(ra == 1)
            {
                Label24.Text = "Success.";
            }
            else
            {
                Label24.Text = "Did not register";
            }

        }
    }
}