using System;

namespace CWMClasses
{
    public class clsStock
    {
        private Int32 mProductCode;
        private String mDescription;
        private double mPrice;
        private Int32 mPristine;
        private Int32 mNon_Pristine;
        private bool mClearence;
        private DateTime mNext_Intake;

        public Int32 Product_Code 
        {
            get
            {
                return mProductCode;
            }
            set
            {
                mProductCode = value;
            }             
        }
        public String Description 
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }
        public double Price 
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public Int32 Pristine
        {
            get
            {
                return mPristine;
            }
            set
            {
                mPristine = value;
            }
        }
        public Int32 Non_Pristine
        {
            get
            {
                return mNon_Pristine;
            }
            set
            {
                mNon_Pristine = value;
            }
        }
        public bool Clearence
        {
            get
            {
                return mClearence;
            }
            set
            {
                mClearence = value;
            }
        }

        public DateTime Next_Intake
        {
            get
            {
                return mNext_Intake;
            }
            set
            {
                mNext_Intake = value;
            }
        }

        public bool Find(int Product_Code)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductCode", Product_Code);
            DB.Execute("sproc_Stock_FilterByProductCode");
            if (DB.Count == 1)
            {
                mProductCode = Convert.ToInt32(DB.DataTable.Rows[0]["Product_Code"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mPristine = Convert.ToInt32(DB.DataTable.Rows[0]["Pristine"]);
                mNon_Pristine = Convert.ToInt32(DB.DataTable.Rows[0]["Non_Pristine"]);
                mClearence = Convert.ToBoolean(DB.DataTable.Rows[0]["Clearence"]);
                mNext_Intake = Convert.ToDateTime(DB.DataTable.Rows[0]["Next_Intake"]);
            return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string description, string price, string pristine, string non_Pristine, string next_Intake)
        {
            String Error = "";
            DateTime DateTemp;
            Decimal Price;
            int Pristine;
            int Non_Pristine;

            if (description == "")
            {
                Error = Error + "The description may not be blank : ";
            }

            if (description.Length > 80)
            {
                Error = Error + "The description may not be more than 80 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(next_Intake);
                if ((DateTemp < DateTime.Now.Date))
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date.AddYears(2))
                {
                    Error = Error + "The next intake must be within the next 2 years : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
                       
            if (!decimal.TryParse(price, out Price))
            {
                Error = Error + "The price given was not a valid price : ";
            }

            if (!int.TryParse(pristine, out Pristine))
            {
                Error = Error + "The given pristine value is not valid : ";
            }
            
            if (!int.TryParse(non_Pristine, out Non_Pristine))
            {
                Error = Error + "The given pristine value is not valid : ";
            }
            return Error;
        }
    }
}