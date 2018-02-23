using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace WebApplication14.Admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string loginid = WebConfigurationManager.AppSettings["adminloginid"];
            string password = WebConfigurationManager.AppSettings["adminpassword"];
            if(TextBox1.Text==loginid && TextBox2.Text==password)
            {
                Session["shoppingheartadmin"] = "shoppingheartadmin";
               // Response.Redirect("~/Admin/WebForm3.aspx");
                Response.Redirect("~/Admin/addnew_category.aspx");

            }
            else
            {
                Label2.Text = "incorrect login/password";
            }
        }
    }
}