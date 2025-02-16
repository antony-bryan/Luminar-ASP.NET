using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prime_number
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(input_txt.Text);
            int flag = 0;
            for(int i = 1; i <= n; i++)
            {
                if(n%i == 0)
                {
                    flag++;
                }
            }
            if (flag == 2)
            {
                output_txt.Text = $"{n} is a prime number.";
            }
            else
            {
                output_txt.Text = $"{n} is not a prime number.";
            }

            

            for(int j = 2; j <= n; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        flag++;
                    }
                }
                if (flag == 2)
                {
                    list_of_prime.Text = $"{j} is a prime number.";
                }
                else
                {
                    list_of_prime.Text = $"{j} is not a prime number.";
                }
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}