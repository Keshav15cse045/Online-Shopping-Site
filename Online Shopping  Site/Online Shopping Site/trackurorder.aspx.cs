using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14
{
    public partial class trackurorder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                string transactiono = Request.QueryString["id"];
                uccustomerdetails1.Transactionnotext = transactiono;

            }
            if (!string.IsNullOrEmpty(Convert.ToString(Session["shoppingheartadmin"])))
            {
                uccustomerdetails1.Isauthorizedtoaddstatus = true;
            }
            else
            {
                uccustomerdetails1.Isauthorizedtoaddstatus = false;
               
            }
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }
    }
}