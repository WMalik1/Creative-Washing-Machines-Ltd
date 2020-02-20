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
            mCustomer_id = 1;
            mName = "Joe,Bloggs";
            mAddress = "2 Random Street,RandomTown,RandomCounty,RN27FT";
            mEmail = "random.email@email.co.uk";
            mPassword = "password";
            mMarketing_emails = false;
            mRegistration_date = DateTime.Now.Date;

            return true;
        }

    }
}