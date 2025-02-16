using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebApp_Dec
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            outputAdd.Visible = true;
            int a, b;
            a = Convert.ToInt32(txtnum1.Text);
            b = Convert.ToInt32(txtnum2.Text);
            outputAdd.Text = (a + b).ToString(); ;
        }

        protected void subtract_Click(object sender, EventArgs e)
        {
            outputSubtract.Visible = true;
            int a, b;
            a = Convert.ToInt32(txtnum1.Text);
            b = Convert.ToInt32(txtnum2.Text);
            outputSubtract.Text = (a - b).ToString();
        }

        protected void multiply_Click(object sender, EventArgs e)
        {
            outputMultiply.Visible = true;
            int a, b;
            a = Convert.ToInt32(txtnum1.Text);
            b = Convert.ToInt32(txtnum2.Text);
            outputMultiply.Text = (a * b).ToString();
        }

        protected void divide_Click(object sender, EventArgs e)
        {
            outputDivide.Visible = true;
            int a, b;
            a = Convert.ToInt32(txtnum1.Text);
            b = Convert.ToInt32(txtnum2.Text);
            outputDivide.Text = (a / b).ToString();
        }
    }
}