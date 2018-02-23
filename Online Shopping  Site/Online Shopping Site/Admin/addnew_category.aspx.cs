using BusinessLogic;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14.Admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addnew_category(object sender, EventArgs e)
        {
            BEL objUserBEL = new BEL();
            objUserBEL.Category_Name = TextBox1.Text;
            Class1 BLL = new Class1();
            BLL.InsertUserDetails(objUserBEL);

        }
        
    }
}