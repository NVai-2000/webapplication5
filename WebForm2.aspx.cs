using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary4;

namespace webapplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 obj = new Class1();
            if(obj.Login(username.Text, password.Text))
            {
                Response.Write("Logged in Successfully");
            }
            else
            {
                Response.Write("Login Failed, Please enter valid details");
            }

        }
    }
}