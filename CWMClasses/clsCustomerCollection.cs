using System;
using System.Collections.Generic;

namespace CWMClasses
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomer ThisCustomer { get; set; }

        public clsCustomerCollection()
        {
            int Index = 0;
            int RecordCount = 0;
            
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.Customer_id = Convert.ToInt32(DB.DataTable.Rows[Index][""]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index][""]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index][""]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index][""]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index][""]);
                ACustomer.Marketing_emails = Convert.ToBoolean(DB.DataTable.Rows[Index][""]);
                ACustomer.Registration_date = Convert.ToDateTime(DB.DataTable.Rows[Index][""]);

                mCustomerList.Add(ACustomer);
                Index++;
            }

        }

    }
}