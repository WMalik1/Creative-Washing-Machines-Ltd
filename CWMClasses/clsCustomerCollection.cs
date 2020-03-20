using System;
using System.Collections.Generic;
using System.Linq;

namespace CWMClasses
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

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
        
        public clsCustomer ThisCustomer 
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_customer_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            int Index = 0;
            int RecordCount = 0;

            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();

            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.Customer_id = Convert.ToInt32(DB.DataTable.Rows[Index]["customer_id"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["name"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["address"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["email"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["password"]);
                ACustomer.Marketing_emails = Convert.ToBoolean(DB.DataTable.Rows[Index]["marketing_emails"]);
                ACustomer.Registration_date = Convert.ToDateTime(DB.DataTable.Rows[Index]["registration_date"]);

                mCustomerList.Add(ACustomer);
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@name", mThisCustomer.Name);
            DB.AddParameter("@address", mThisCustomer.Address);
            DB.AddParameter("@email", mThisCustomer.Email);
            DB.AddParameter("@password", mThisCustomer.Password);
            DB.AddParameter("@marketing_emails", mThisCustomer.Marketing_emails);
            DB.AddParameter("@registration_date", mThisCustomer.Registration_date);
            return DB.Execute("sproc_customer_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@customer_id", mThisCustomer.Customer_id);
            DB.Execute("sproc_customer_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@customer_id", mThisCustomer.Customer_id);
            DB.AddParameter("@name", mThisCustomer.Name);
            DB.AddParameter("@address", mThisCustomer.Address);
            DB.AddParameter("@email", mThisCustomer.Email);
            DB.AddParameter("@password", mThisCustomer.Password);
            DB.AddParameter("@marketing_emails", mThisCustomer.Marketing_emails);
            DB.AddParameter("@registration_date", mThisCustomer.Registration_date);
            DB.Execute("sproc_customer_Update");
        }

        public void FilterByMarketingPreference(bool Marketing_emails)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@marketing_emails", Marketing_emails);
            DB.Execute("sproc_customer_FilterByMarketingPreference");
            PopulateArray(DB);
        }

        public void FilterByAddress(string Address)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@address", Address);
            string UpperCaseFirstAddress;
            if (!Address.Equals(""))
            {
                UpperCaseFirstAddress = Address.First().ToString().ToUpper() + Address.Substring(1);
            } else
            {
                UpperCaseFirstAddress = "";
            }
            DB.AddParameter("@addressFirstLetterCap", UpperCaseFirstAddress);
            DB.Execute("sproc_customer_FilterByAddress");
            PopulateArray(DB);
        }

    }
}