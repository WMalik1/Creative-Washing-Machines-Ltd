using System;

namespace CWMClasses
{
    public class clsOrder
    {
        public int OrderID { get; set; }

        public int customerID { get; set; }

        public int staffID { get; set; }

        public int Product_code { get; set; }

        public int Total_cost { get; set; }

        public System.DateTime Date_delivery { get; set; }
        public DateTime DateAdded { get; set; }

        public bool Find(int OrderID)
        {
            //always return true
            return true;
        }
    }
}