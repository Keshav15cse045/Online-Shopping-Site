using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BusinessObject;
using DataAccess;
using System.Configuration;
namespace WebApplication14
{
    public partial class uccustomerdetails : System.Web.UI.UserControl
    {
        public bool CanIUpdateStatus;
        public string Transactionnotext
        {
          

            get { return TextBox1.Text; }
            set { TextBox1.Text = value; }
        }
        public bool Isauthorizedtoaddstatus
        {
            set { CanIUpdateStatus = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
               
                if (TextBox1.Text!=string.Empty)
                {
                    showorderdetails(RadioButtonList1.SelectedValue, Convert.ToInt32(TextBox1.Text));
                }
                else
                {
                    RadioButtonList1.Visible = false;
                     Panel1.Visible = false;
                    Panel2.Visible = false;
                    Panel3.Visible = false;
                    Panel4.Visible = false;
                }
            }
        }


        public void showorderdetails(string Panelid,int Orderno)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            RadioButtonList1.Visible = false;

            if(IsOrderNoValid(Orderno))
            {
                RadioButtonList1.Visible = true;
                if(Panelid=="1")
                {
                    string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("getorderlist", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@flag", Orderno);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Panel1.Visible = true;
                        Label2.Text = Convert.ToString(dt.Rows[0]["customername"]);
                        Label3.Text = Convert.ToString(dt.Rows[0]["customerphoneno"]);
                        Label4.Text = Convert.ToString(dt.Rows[0]["customeremail"]);
                        Label5.Text = Convert.ToString(dt.Rows[0]["totalprice"]);
                        Label6.Text = Convert.ToString(dt.Rows[0]["totalproducts"]);
                        Label7.Text = Convert.ToString(dt.Rows[0]["customeraddress"]);
                        Label8.Text = Convert.ToString(dt.Rows[0]["paymentmethod"]);
                        

                    }
                }
                if(Panelid=="2")
                {
                    Panel2.Visible = true;
                    string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    SqlDataAdapter da = new SqlDataAdapter("gettransactiondetails", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Transactionno", Orderno);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataList1.DataSource = null;

                    DataList1.DataSource = ds;
                    DataList1.DataBind();
                   
                    con.Close();

  
                   
                }
                if(Panelid=="3")
                {
                    Panel3.Visible = true;
                    TextBox2.Visible = CanIUpdateStatus;
                    Button2.Visible= CanIUpdateStatus;
                    GetSetOrderStatus(0);

                }
                else
                {
                    Panel4.Visible = true;
                }
            }
        }
        private bool IsOrderNoValid(int OrderNo)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("getorderlist", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@flag", OrderNo);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
                       
        }

        public void GetSetOrderStatus(int flag)
        {
            BEL k = new BEL();
             k._orderstatus= TextBox2.Text;
             k._orderno= Convert.ToInt32(TextBox1.Text);
            k._flag=flag;

            DAL BLL = new DAL();
            DataTable dtResult = BLL.getsetcustomerdetails(k);
            GridView1.DataSource = dtResult;
            GridView1.DataBind();
            TextBox2.Text = string.Empty;
        }
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showorderdetails(RadioButtonList1.SelectedValue, Convert.ToInt32(TextBox1.Text));
        }

        protected void update_status(object sender, EventArgs e)
        {
            //add status
            GetSetOrderStatus(1);
        }

        protected void search_userdetail(object sender, EventArgs e)
        {
            //check using id
            if(TextBox1.Text!=string.Empty)
            {
                RadioButtonList1.Visible = true;
                showorderdetails(RadioButtonList1.SelectedValue, Convert.ToInt32(TextBox1.Text));
            }
            else
            {
                RadioButtonList1.Visible = false;
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
            }
        }
        
    }
}