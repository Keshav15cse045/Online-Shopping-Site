using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class BEL
    {
        private string _Category_Name;
        private int _Categoryid;
        private string _productname;
        private string _productimage;
        private string _price;
        private string _description;
        private int _productquantity;


        public string _customername;
        public string _customeremailid;
        public string _customerphoneno;
        public string _customeraddress;
        public string _productlist;
        public int _totalprice;
        public string _paymentmethod;


        public int _customerid;
        public int _productid;
        public int _totalproducts;

        public string _orderstatus;
        public int _orderno;
        public int _flag;

        public string Category_Name
        {
            get
            {
                return _Category_Name;
            }
            set
            {
                _Category_Name = value;
            }
        }

        public int Categoryid
        {
            get
            {
                return _Categoryid;
            }
            set
            {
                _Categoryid = value;
            }
        }

        public string productname
        {
            get
            {
                return _productname;
            }
            set
            {
                _productname = value;
            }
        }

        public string productimage
        {
            get
            {
                return _productimage;
            }
            set
            {
                _productimage = value;
            }
        }
        public string price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
       
            public int productquantity
        {
            get
            {
                return _productquantity;
            }
            set
            {
                _productquantity = value;
            }
        }



        public string customername
        {
            get
            {
                return _customername;
            }
            set
            {
                _customername = value;
            }
        }

        public string customeremailid
        {
            get
            {
                return _customeremailid;
            }
            set
            {
                _customeremailid = value;
            }
        }

        public string customerphoneno
        {
            get
            {
                return _customerphoneno;
            }
            set
            {
                _customerphoneno = value;
            }
        }

        public string customeraddress
        {
            get
            {
                return _customeraddress;
            }
            set
            {
                _customeraddress = value;
            }
        }
        
        public string productlist
        {
            get
            {
                return _productlist;
            }
            set
            {
                _productlist = value;
            }
        }

        public string paymentmethod
        {
            get
            {
                return _paymentmethod;
            }
            set
            {
                _paymentmethod = value;
            }
        }


        public int totalprice
        {
            get
            {
                return _totalprice;
            }
            set
            {
                _totalprice = value;
            }
        }




        /* ......................................................*/
        /*  customer products  */

        public int customerid
        {
            get
            {
                return _customerid;
            }
            set
            {
                _customerid = value;
            }
        }

        public int productid
        {
            get
            {
                return _productid;
            }
            set
            {
                _productid = value;
            }
        }

        public int totalproducts
        {
            get
            {
                return _totalproducts;
            }
            set
            {
                _totalproducts = value;
            }
        }
   

        public string orderstatus
        {
            get
            {
                return _orderstatus;
            }
            set
            {
                _orderstatus = value;
            }
        }

        public int orderno
        {
            get
            {
                return _orderno;
            }
            set
            {
                _orderno = value;
            }
        }

        public int flag
        {
            get
            {
                return _flag;
            }
            set
            {
                _flag = value;
            }
        }
    }
}
