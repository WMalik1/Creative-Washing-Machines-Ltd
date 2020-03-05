using System;

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
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mHire_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Hire_Date"]);
                mSalary = Convert.ToDouble(DB.DataTable.Rows[0]["Salary"]);

                return true;

            }

            else
            {

                return false;
            }
            
        }
    }
}