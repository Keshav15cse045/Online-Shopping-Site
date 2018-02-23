using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14.Admin
{
    public partial class details_order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if(!string.IsNullOrEmpty(Request.QueryString["customerid"]))
            {
   
                string transactiono = Request.QueryString["customerid"];
                uccustomerdetails1.Transactionnotext = transactiono;

            }
            if (!string.IsNullOrEmpty(Convert.ToString(Session["shoppingheartadmin"])))
            {
                uccustomerdetails1.Isauthorizedtoaddstatus = true;
            }
            else
            {
                uccustomerdetails1.Isauthorizedtoaddstatus = false;
                Response.Redirect("~/Admin/login.aspx");
            }
        }

        protected void clear_search(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/details_order.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Admin/orderdetails.aspx");
        }

       
    }
}