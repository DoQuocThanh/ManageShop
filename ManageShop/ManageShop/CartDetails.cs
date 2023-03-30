using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShop
{
    public class CartDetails
    {
        public String ProductName {
            get; set;
        }
        public int ProductID
        {
            get; set;
        }
        public int Quantity {
            get;set;
        }
       

        public float Price {
            get;set;
        }
    }
}
