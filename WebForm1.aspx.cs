using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Show.Text = "Welcome to C Sharp !";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox1.Text);
            int num2 = Convert.ToInt32(TextBox2.Text);

            int result = num1 + num2;

            Result.Text = Convert.ToString(result);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(Username.Text == "bookman" && Password.Text == "bookman")
            {
                Check.Text = "OK";
                Check.ForeColor = Color.Navy;
              
            }
            else
            {
                Check.Text = "Error! ";
                Check.ForeColor = Color.Red;
            
            }
        }
    }
}