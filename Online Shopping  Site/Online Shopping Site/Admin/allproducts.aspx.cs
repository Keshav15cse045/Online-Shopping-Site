using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace WebApplication14.Admin
{
    public partial class allproducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                getproducts();
            }
        }
        public void getproducts()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
             SqlCommand cmd = new SqlCommand();
             SqlDataAdapter  da= new SqlDataAdapter("getmrproducts", con);
       //     SqlParameter param = new SqlParameter("@categoryid",0);
         //   cmd.Parameters.AddWithValue("@categoryid", 0);
            cmd.CommandType = CommandType.StoredProcedure;
           
            DataSet ds = new DataSet();
            da.Fill(ds, "newtable");
            GridView1.DataSource = null;
            GridView1.DataSource = ds.Tables["newtable"];
            GridView1.DataBind();
            con.Close();

        }
    }
}