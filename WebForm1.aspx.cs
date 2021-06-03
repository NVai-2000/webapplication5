using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary4;

namespace webapplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Class1 obj = new Class1();
            Response.Write("The username must be greater than 10 characters ! ");
            Response.Write("Check if Email entered is valid !");
            Response.Write("Password must contain more than 10 characters!");
            Response.Write("Password must have atleast one number,Special character, Uppercase and Lowercase Letters");

            if (obj.Registration(username.Text, email.Text, password.Text))
            {
                Response.Write("Registered Successfully");
            }
            else
            {
                Response.Write("Please enter valid details registration failed !");
                
            }
        }
    }
}