
using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Class1
    {
        public int InsertUserDetails(BEL objUserDetails)
        {
            DAL objUserDAL = new DAL();
            try
            {
                return objUserDAL.InsertUserInformation(objUserDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objUserDAL = null;
            }
        }



        public int addproducts(BEL objUserDetails)
        {
            DAL objUserDAL = new DAL();
            try
            {
                return objUserDAL.Insertproducts(objUserDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objUserDAL = null;
            }
        }

    }
}
