using System;
using System.Linq;
using System.Text.RegularExpressions;

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

            int NameLength = name.Length; 
            if (NameLength < 2 || NameLength > 50)
            {
                Error += "Name, including the space, must be between 2 and 50 characters long : ";
            }

            Regex nameRegex = new Regex("^[a-zA-Z,-]*$");
            if (!nameRegex.IsMatch(name))
            {
                Error += "Name can only contain letters, spaces and hyphens : ";
            }

            if (name.Count(x => x == ',') == 0)
            {
                Error += "You need to have a space between your first and last name : ";
            }

            if (name.Count(x => x == ',') > 1)
            {
                Error += "You should only have one space in your name : ";
            }

            return Error;
        }

        public string ValidateAddress(string address)
        {
            String Error = "";

            if (address.Length > 250)
            {
                Error += "Address must be less than 250 characters : ";
            }

            int AddressLineCount = address.Split(',').Count();
            if (AddressLineCount < 4 || AddressLineCount > 6)
            {
                Error += "Address needs to be anywhere from 4-6 lines : ";
            }

            Regex addressRegex = new Regex("^[a-zA-Z0-9, ]*$");
            if (!addressRegex.IsMatch(address))
            {
                Error += "Address can only contain letters and digits : ";
            }
            
            return Error;
        }

        public string ValidateEmail(string email)
        {
            String Error = "";

            int EmailLength = email.Length;
            if (EmailLength < 6 || EmailLength > 150)
            {
                Error += "Email must be between 6 and 150 characters long : ";
            }

            try
            {
                var EmailAddress = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                Error += "Email must be a valid email address : ";
            }

            return Error;
        }

        public string ValidatePassword(string password)
        {
            String Error = "";

            int PasswordLength = password.Length;
            if (PasswordLength < 8 || PasswordLength > 30)
            {
                Error += "Password must be between 8 and 30 characters long : ";
            }

            return Error;
        }

        public string ValidateRegistrationDate(string registration_date)
        {
            String Error = "";

            try
            {
                DateTime Date = Convert.ToDateTime(registration_date);
                if (Date != DateTime.Now.Date)
                {
                    Error += "Date must be today's date : ";
                }
            }
            catch
            {
                Error += "Date must be a valid date format : ";
            }

            return Error;
        }

    }
}