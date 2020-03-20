using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CWMClasses
{
    public class clsStaff
    {
        private int mstaff_id;
        private double mSalary;
        private string mEmail;
        private string mName;
        private bool mActive;
        private DateTime mHire_Date;

        public int staff_id
        {
            get
            {
                return mstaff_id;
            }
            set
            {
                mstaff_id = value;
            }
        }
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

        public string Valid(object name, object email, object hire_Date, object salary)
        {
            throw new NotImplementedException();
        }

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public double Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }
        public DateTime Hire_Date
        {
            get
            {
                return mHire_Date;
            }
            set
            {
                mHire_Date = value;
            }
        }

        public bool Find(int staff_id)
        {


            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@staff_id", staff_id);
            DB.Execute("sproc_staff_FilterByStaffID");

            if (DB.Count == 1)
            {

                mstaff_id = Convert.ToInt32(DB.DataTable.Rows[0]["staff_id"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["email_address"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["active"]);
                mHire_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["hire_date"]);
                mSalary = Convert.ToDouble(DB.DataTable.Rows[0]["salary"]);

                return true;

            }

            else
            {

                return false;
            }
            
        }


        public string Valid(string name, string email_address,string hire_date,string salary)
        {
            String Error = "";
            Error += ValidateName(name);
            Error += ValidateEmail(email_address);
            Error += ValidateHireDate(hire_date);
            Error += ValidateSalary(salary);


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

        public string ValidateEmail(string email_address)

        {
            String Error = "";
            int EmailLength = email_address.Length;

            if (EmailLength < 6 || EmailLength > 150)

            {
                Error += "Email must be between 6 and 150 characters long : ";
            }

            try
            {
                var EmailAddress = new System.Net.Mail.MailAddress(email_address);
            }
            catch
            {
                Error += "Email must be a valid email address : ";
            }
            return Error;

        }


        public string ValidateHireDate(string hire_date)

        {

            String Error = "";

            try

            {
                DateTime Date = Convert.ToDateTime(hire_date);

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

        public string ValidateSalary(string salary)

        {

            String Error = "";
            Decimal Salary;

            if (!decimal.TryParse(salary, out Salary))

            {

                Error = Error + "The price given was not a valid price : ";

            }

            return Error;

        }


    }
}