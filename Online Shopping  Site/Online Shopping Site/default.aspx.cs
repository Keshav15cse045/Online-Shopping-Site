using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinessLogic;
using BusinessObject;
using DataAccess;
using System.IO;
using System.Configuration;
namespace WebApplication14
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                //  SqlConnection con = new SqlConnection("data source=.;database=testdb;integrated security=SSPI");
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from categories", con);
                DataList2.DataSource = cmd.ExecuteReader();
                DataList2.DataBind();
                getproducts(0);
            }

        }
        private void getproducts(int categoryid)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("getallproducts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoryid", categoryid);
            cmd.Connection = con;
            DataList1.DataSource = cmd.ExecuteReader();
            DataList1.DataBind();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            pnlemptycart.Visible = false;
            pnlproducts.Visible = true;
            int categoryid=Convert.ToInt16((((LinkButton)sender).CommandArgument));
            getproducts(categoryid);


        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void addtocart_Click(object sender, EventArgs e)
        {
            //Button1_Click

            string productid = Convert.ToInt16((((Button)sender).CommandArgument)).ToString();
            string productquantity = "1";
            DataListItem currentitem = (sender as Button).NamingContainer as DataListItem;
            Label lblavailablestock = currentitem.FindControl("Label4") as Label;

            if (Session["mycart"] != null)
            {
                DataTable dt = (DataTable)Session["mycart"];
                var checkproduct = dt.AsEnumerable().Where(r => r.Field<string>("productid") == productid);
                if (checkproduct.Count() == 0)
                {
                    string query = "select * from products where productid=" + productid + "";
                    DataTable dtproducts = getdata(query);
                    DataRow dr = dt.NewRow();
                    dr["productid"] = productid;
                    dr["name"] = Convert.ToString(dtproducts.Rows[0]["name"]);
                    dr["description"] = Convert.ToString(dtproducts.Rows[0]["description"]);
                    dr["price"] = Convert.ToString(dtproducts.Rows[0]["price"]);
                    dr["productimage"] = Convert.ToString(dtproducts.Rows[0]["productimage"]);
                    dr["productquantity"] = productquantity;
                    dr["availablestock"] = lblavailablestock;
                    dt.Rows.Add(dr);

                    Session["mycart"] = dt;
                    btncartcount.Text = dt.Rows.Count.ToString();
                }
                }
                else
                {
                string query = "select * from products where productid=" + productid + "";
                    DataTable dtproducts = getdata(query);
        
                DataTable dt = new DataTable();
                    dt.Columns.Add("productid", typeof(string));
                    dt.Columns.Add("name", typeof(string));
                    dt.Columns.Add("description", typeof(string));
                    dt.Columns.Add("price", typeof(string));
                    dt.Columns.Add("productimage", typeof(string));
                    dt.Columns.Add("productquantity", typeof(string));
                    dt.Columns.Add("availablestock", typeof(string));

                    DataRow dr = dt.NewRow();
                    dr["productid"] = productid;
                    dr["name"] = Convert.ToString(dtproducts.Rows[0]["name"]);
                    dr["description"] = Convert.ToString(dtproducts.Rows[0]["description"]);
                    dr["price"] = Convert.ToString(dtproducts.Rows[0]["price"]);
                    dr["productimage"] = Convert.ToString(dtproducts.Rows[0]["productimage"]);
                    dr["productquantity"] = productquantity;
                    dr["availablestock"] = lblavailablestock;
                    dt.Rows.Add(dr);

                    Session["mycart"] = dt;
                    btncartcount.Text = dt.Rows.Count.ToString();
                }
            }
            
        public DataTable getdata(string query )
        {
            DataTable dt = new DataTable();

            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter da = new SqlDataAdapter(query, con);
           
           da.Fill(dt);
            con.Close();
            return dt;
        }

     
        private void getmycart()
        {
            DataTable dtproducts;
            if(Session["mycart"]!=null)
            {
                dtproducts = (DataTable)Session["mycart"];

            }
            else
            {
                dtproducts = new DataTable();
            }
            if(dtproducts.Rows.Count>0)
            {
               txttotalproduct.Text = dtproducts.Rows.Count.ToString();
                btncartcount.Text = dtproducts.Rows.Count.ToString();
                dlcartproducts.DataSource = dtproducts;
                dlcartproducts.DataBind();
                 updatetotalbill();

                Panel1.Visible = true;
                pnlmycart.Visible = true;
               
                pnlemptycart.Visible = false;
                pnlproducts.Visible = false;
                pnlcategories.Visible = false;
                pnlordersuccessfull.Visible = false;
        
            }
            else
            {
                pnlemptycart.Visible = true;
                pnlmycart.Visible = false;
                Panel1.Visible = false;
                pnlproducts.Visible = false;
                pnlcategories.Visible = false;
                pnlordersuccessfull.Visible = false;

                dlcartproducts.DataSource = null;
                dlcartproducts.DataBind();
                txttotalproducts.Text = "0";
                txttotalprice.Text = "0";
                btncartcount.Text = "0";
            }
        }
        private void updatetotalbill()
        {
            long totalprice = 0;
            long totalproducts = 0;
            foreach(DataListItem item in dlcartproducts.Items)
            {
                
                    Label pricelabel = item.FindControl("lblprice") as Label;
            
                    TextBox productquantity = item.FindControl("txtproductquantity") as TextBox;
             
                
                    long productprice = Convert.ToInt64(pricelabel.Text) * Convert.ToInt64(productquantity.Text);
                    totalprice = totalprice + productprice;
                    totalproducts = totalproducts + Convert.ToInt32(productquantity.Text);
                
               
            }
            txttotalpric.Text = Convert.ToString(totalprice);
            txttotalproduct.Text = Convert.ToString(totalproducts);
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox txtquantity = (sender as TextBox);
            DataListItem currentitem = (sender as TextBox).NamingContainer as DataListItem;
            HiddenField productid = currentitem.FindControl("HiddenField1") as HiddenField;
            Label lblavailablestock = currentitem.FindControl("Label4") as Label;

            if(txtquantity.Text==string.Empty || txtquantity.Text=="0" || txtquantity.Text=="1")
            {
                txtquantity.Text = "1";
            }
            else
            {
                if(Session["mycart"]!=null)
                {
                    if(Convert.ToInt32(txtquantity.Text)<=Convert.ToInt32(lblavailablestock.Text))
                    {
                        DataTable dt = (DataTable)Session["mycart"];
                        DataRow[] rows = dt.Select("productid= '" + productid.Value + " ' ");
                        int index = dt.Rows.IndexOf(rows[0]);
                        dt.Rows[index]["productquantity"] = txtquantity.Text;
                        Session["mycart"] = dt;

                    }
                    else
                    {
                        txtquantity.Text = "1";
                    }
                      
                  }
            }
            updatetotalbill();
        }

           protected void remove_cart(object sender, EventArgs e)
           {
            //to remove from cart


            string productid = Convert.ToInt16((((Button)sender).CommandArgument)).ToString();
            if(Session["mycart"]!=null)
            {
                DataTable dt = (DataTable)Session["mycart"];
                DataRow drr = dt.Select("productid=" + productid + "").FirstOrDefault();
                if (drr != null)
                    dt.Rows.Remove(drr);
                Session["mycart"] = dt;
            }

            getmycart();
           }

        protected void btncartcount_Click(object sender, EventArgs e)
        {
            getmycart();
           
        }

        protected void place_order(object sender, EventArgs e)
        {
            //submit customer form
            string productids = string.Empty;
            DataTable dt;
            if (Session["mycart"] != null)
            {
                dt = (DataTable)Session["mycart"];
                BEL k = new BEL();

                k._customername = TextBox22.Text.ToString();
                k._customeremailid = TextBox44.Text.ToString();
                k._customeraddress = TextBox55.Text.ToString();
                k._customerphoneno = TextBox33.Text.ToString();
                k._totalproducts = Convert.ToInt32(txttotalproduct.Text);
                k._totalprice = Convert.ToInt32(txttotalpric.Text);
                //k._productlist = productids;
                k._paymentmethod = RadioButtonList1.SelectedItem.Text;

                DAL BLL = new DAL();
                DataTable dtResult = BLL.savecustomerdetails(k);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BEL saveproducts = new BEL();


                    saveproducts._customerid = Convert.ToInt32(dtResult.Rows[0][0]);
                    saveproducts._productid = Convert.ToInt32(dt.Rows[i]["productid"]);
                    saveproducts._totalproducts = Convert.ToInt32(dt.Rows[i]["productquantity"]);

                    DAL kk = new DAL();
                    kk.savecustomerproducts(saveproducts);
                    kk.updateproducts(saveproducts);

                    //  SendOrderPlacedAlert(TextBox22.Text, TextBox44.Text, Convert.ToString(dtResult.Rows[0][0]));
                    pnlemptycart.Visible = false;
                    pnlmycart.Visible = false;
                    Panel1.Visible = false;
                    pnlproducts.Visible = false;
                    pnlcategories.Visible = false;
                    pnlordersuccessfull.Visible = true;
                    Session.Clear();
                }

            }
        }
        private string populateorderemailbody(string customername,string transaction)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader(Server.MapPath("~/ordertemplate.html")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{customername}", customername);
            body = body.Replace("{orderno}", transaction);
            return body;
        }
                private void SendOrderPlacedAlert(string customername,string customeremailid,string transaction)
        {
            string body = this.populateorderemailbody(customername, transaction);
            EmailEngine.sendemail(customeremailid, "shopping heart-- your order details", body);
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
              Response.Redirect("~/trackurorder.aspx");
           
        }

        protected void track_order(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/trackurorder.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            pnlemptycart.Visible = false;
            pnlmycart.Visible = false;
            pnlcheckoutform.Visible = false;
            pnlproducts.Visible = true;
            pnlcategories.Visible = true;
            pnlordersuccessfull.Visible = false;
        }

        protected void back_home(object sender, ImageClickEventArgs e)
        {
            pnlemptycart.Visible = false;
            pnlmycart.Visible = false;
            Panel1.Visible = false;
            pnlproducts.Visible = true;
            pnlcategories.Visible = true;
            pnlordersuccessfull.Visible = false;
        }
    }

        }

  