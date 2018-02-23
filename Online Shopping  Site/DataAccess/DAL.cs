using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using BusinessObject;
using System.Configuration;

namespace DataAccess
{
    public class DAL
    {
        public int InsertUserInformation(BEL objBELUserDetails)
        {
              SqlConnection con = new SqlConnection("data source=.;database=testdb;integrated security=SSPI");
            
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_userinformation", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@category", objBELUserDetails.Category_Name);
            int Result = cmd.ExecuteNonQuery();
            return Result;
        }



        public int Insertproducts(BEL objBELUserDetails)
        {
             SqlConnection con = new SqlConnection("data source=.;database=testdb;integrated security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("addnewproducts", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@productname", objBELUserDetails.productname);
            cmd.Parameters.AddWithValue("@productimage", objBELUserDetails.productimage);

            cmd.Parameters.AddWithValue("@productprice", objBELUserDetails.price);
            cmd.Parameters.AddWithValue("@productdescription", objBELUserDetails.description);
            cmd.Parameters.AddWithValue("@categoryid", objBELUserDetails.Categoryid);
            cmd.Parameters.AddWithValue("@productquantity", objBELUserDetails.productquantity);
            int Result = cmd.ExecuteNonQuery();
            return Result;
        }





        public DataTable savecustomerdetails(BEL objBELUserDetails)
        {
            SqlConnection con = new SqlConnection("data source=.;database=testdb;integrated security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("savecustomerdetails", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@customername", objBELUserDetails.customername);
            cmd.Parameters.AddWithValue("@customeremail", objBELUserDetails.customeremailid);
            cmd.Parameters.AddWithValue("@customerphoneno", objBELUserDetails.customerphoneno);

            cmd.Parameters.AddWithValue("@customeraddress", objBELUserDetails.customeraddress);
            cmd.Parameters.AddWithValue("@totalproducts", objBELUserDetails.totalproducts);
            cmd.Parameters.AddWithValue("@totalprice", objBELUserDetails.totalprice);
            cmd.Parameters.AddWithValue("@paymentmethod", objBELUserDetails.paymentmethod);

            int Result = cmd.ExecuteNonQuery();
            DataTable dtt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select @@IDENTITY as customerid from customerdetails",con);
            da.Fill(dtt);
            con.Close();
            return dtt;
        }

        public DataTable getsetcustomerdetails(BEL objBELUserDetails)
        {
            SqlConnection con = new SqlConnection("data source=.;database=testdb;integrated security=SSPI");
            con.Open();
         //   SqlCommand cmd = new SqlCommand("orderstatus", con);
           // cmd.CommandType = CommandType.StoredProcedure;

        /*    cmd.Parameters.AddWithValue("@transactionno", objBELUserDetails._orderno);
            cmd.Parameters.AddWithValue("@orderstatus", objBELUserDetails._orderstatus);
            cmd.Parameters.AddWithValue("@flag", objBELUserDetails._flag);

    */
            SqlDataAdapter da = new SqlDataAdapter("orderstatus", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@transactionno", objBELUserDetails._orderno);
            da.SelectCommand.Parameters.AddWithValue("@orderstatus", objBELUserDetails._orderstatus);
            da.SelectCommand.Parameters.AddWithValue("@flag", objBELUserDetails._flag);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //   int Result = cmd.ExecuteNonQuery();
           // DataTable dtt = new DataTable();
           // SqlDataAdapter da = new SqlDataAdapter("select * from delieverystatus", con);
           // da.Fill(dtt);
           // con.Close();
            return dt;
        }


        public void savecustomerproducts(BEL objBELUserDetails)
        {
            SqlConnection con = new SqlConnection("data source=.;database=testdb;integrated security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("savecustomerproducts", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@customerid", objBELUserDetails._customerid);
            cmd.Parameters.AddWithValue("@productid", objBELUserDetails._productid);
            cmd.Parameters.AddWithValue("@totalproduct", objBELUserDetails._totalproducts);
            
            cmd.ExecuteNonQuery();
            
        }
        public void updateproducts(BEL objBELUserDetails)
        {
            SqlConnection con = new SqlConnection("data source=.;database=testdb;integrated security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_updateproducts", con);
            cmd.CommandType = CommandType.StoredProcedure;


           
            cmd.Parameters.AddWithValue("@productid", objBELUserDetails._productid);
            cmd.Parameters.AddWithValue("@productquantity", objBELUserDetails._totalproducts);

            cmd.ExecuteNonQuery();

        }
    }
}
