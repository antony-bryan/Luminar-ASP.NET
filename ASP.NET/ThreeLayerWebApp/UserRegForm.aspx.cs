﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ThreeLayerWebApp
{
    public partial class UserRegForm : System.Web.UI.Page
    {
        UserRegCls objbll = new UserRegCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/PHS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            int i = objbll.InsertDB(TextBox1.Text, Convert.ToInt32(TextBox2.Text), TextBox3.Text, path, TextBox4.Text, TextBox5.Text);
            if (i == 1)
            {
                Label1.Text = "Inserted.";
            }
            else
            {
                Label1.Text = "Failed";
            }
        }
    }
}