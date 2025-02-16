using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebApp_Dec
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnDisplay_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = txtname.Text;  
        }

        protected void lblname_DataBinding(object sender, EventArgs e)
        {

        }
    }
}