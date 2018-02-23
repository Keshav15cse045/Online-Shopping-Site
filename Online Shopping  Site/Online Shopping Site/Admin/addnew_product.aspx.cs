using BusinessLogic;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication14.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("select CategoryId,CategoryName from categories", con);
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "CategoryName";
                DropDownList1.DataValueField = "CategoryId";
                DropDownList1.DataBind();
            }

        }

       /* protected void Button2_Click(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile)
            {
                string filextension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if(filextension.ToLower()==".jpeg" || filextension.ToLower() == ".png" )
                {
                    FileUpload1.SaveAs(Server.MapPath("~/images/" + FileUpload1.FileName));
                }
            }
        }
        */
        protected void addnew_product(object sender, EventArgs e)
        {
            if (FileUpload1.PostedFile != null)
            {
                saveproductsphoto();
                BEL objUserBEL = new BEL();
                objUserBEL.productname = TextBox1.Text;
                objUserBEL.Categoryid = Convert.ToInt32(DropDownList1.SelectedValue);
                objUserBEL.description = TextBox2.Text;
                objUserBEL.productimage = "~/images/" + FileUpload1.FileName;
                objUserBEL.price = TextBox3.Text;
                objUserBEL.productquantity = Convert.ToInt32(TextBox4.Text);
               Class1 BLL = new Class1();
                BLL.addproducts(objUserBEL);
            }
        }
        private void saveproductsphoto()
        {
            if(FileUpload1.PostedFile!=null)
            {
                string filename = FileUpload1.PostedFile.FileName.ToString();
                string fileExt = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (fileExt.ToLower() == ".jpeg" || fileExt.ToLower() == ".jpg")
                {
                    FileUpload1.SaveAs(Server.MapPath("~/images/" + FileUpload1.FileName));
                }
            }
        }

       
    }
}