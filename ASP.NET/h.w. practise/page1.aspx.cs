using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace h.w.practise
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;

            TextBox9.Text =  TextBox1.Text;  //name
            TextBox10.Text = TextBox2.Text; //age
            TextBox11.Text = TextBox3.Text; //address
            TextBox12.Text = TextBox4.Text; //Phone
            TextBox13.Text = TextBox5.Text; //email
            TextBox14.Text = RadioButtonList1.SelectedItem.Text; //Gender
            TextBox15.Text = DropDownList1.SelectedItem.Text; //State

            string t = "";
            for(int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    t = t + CheckBoxList1.Items[i] + ", ";
                }
            }
            TextBox16.Text = t; //Qualification
            
            string pa = "~/PHS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(pa));

            Image1.ImageUrl = pa; //photo

            TextBox18.Text = TextBox6.Text; //username
            TextBox19.Text = TextBox8.Text; //password










        }
    }
}