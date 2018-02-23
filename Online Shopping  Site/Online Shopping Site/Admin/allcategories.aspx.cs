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
    public partial class allcategories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                getcategories();
            }
        }
        public void getcategories()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from categories", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}