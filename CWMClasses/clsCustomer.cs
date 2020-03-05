using System;

namespace CWMClasses
{
    public class clsCustomer
    {
        private Int32 mCustomer_id;
        public int Customer_id
        { 
            get
            {
                return mCustomer_id;
            }
            set
            {
                mCustomer_id = value;
            }
        }

        private string mName;
        public string Name
        {
            get 
            {
                return mName;
            }
            set 
            {
                mName = value;
            }
        }

        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        private string mPassword;
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        private Boolean mMarketing_emails;
        public bool Marketing_emails
        {
            get
            {
                return mMarketing_emails;
            }
            set
            {
                mMarketing_emails = value;
            }
        }

        private DateTime mRegistration_date;
        public DateTime Registration_date
        {
            get
            {
                return mRegistration_date;
            }
            set
            {
                mRegistration_date = value;
            }
        }

        public bool Find(int Customer_id)
        {
            Boolean Found = false;
            
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@customer_id", Customer_id);
            DB.Execute("sproc_customer_FilterByCustomerID");

            if (DB.Count == 1)
            {
                mCustomer_id = Convert.ToInt32(DB.DataTable.Rows[0]["customer_id"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["name"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["address"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["password"]);
                mMarketing_emails = Convert.ToBoolean(DB.DataTable.Rows[0]["marketing_emails"]);
                mRegistration_date = Convert.ToDateTime(DB.DataTable.Rows[0]["registration_date"]);
                Found = true;
            }

            return Found;
        }

        public string Valid(string name, string address, string email, string password, string registration_date)
        {
            String Error = "";
            Error += ValidateName(name);
            Error += ValidateAddress(address);
            Error += ValidateEmail(email);
            Error += ValidatePassword(password);
            Error += ValidateRegistrationDate(registration_date);
            return Error;
        }

        public string ValidateName(string name)
        {
            String Error = "";

            return Error;
        }

        public string ValidateAddress(string name)
        {
            String Error = "";

            return Error;
        }

        public string ValidateEmail(string name)
        {
            String Error = "";

            return Error;
        }

        public string ValidatePassword(string name)
        {
            String Error = "";

            return Error;
        }

        public string ValidateRegistrationDate(string name)
        {
            String Error = "";

            return Error;
        }

    }
}