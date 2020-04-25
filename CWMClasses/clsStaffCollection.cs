using System;
using System.Collections.Generic;

namespace CWMClasses
{
    public class clsStaffCollection
    {


        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;


            }
            set
            {

                mThisStaff = value;


            }

        }

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;

            }
        }


        
        public int Count
        {
            get
            {

                return mStaffList.Count;

            }
            set

            {


            }

        }


        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_staff_SelectAll");
            PopulateArray(DB);
          
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;

            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();

            while (Index < RecordCount)
            {

                clsStaff AStaff = new clsStaff();

                AStaff.staff_id = Convert.ToInt32(DB.DataTable.Rows[Index]["staff_id"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["name"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["email_address"]);
                AStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["active"]);
                AStaff.Hire_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["hire_date"]);
                AStaff.Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["salary"]);

                mStaffList.Add(AStaff);

                Index++;

            }

        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@name", mThisStaff.Name);
            DB.AddParameter("@email_address", mThisStaff.Email);
            DB.AddParameter("@hire_date", mThisStaff.Hire_Date);
            DB.AddParameter("@salary", mThisStaff.Salary);
            DB.AddParameter("@active", mThisStaff.Active);

            return DB.Execute("sproc_staff_Insert");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staff_id", mThisStaff.staff_id);
            DB.Execute("sproc_staff_Delete");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@staff_id", mThisStaff.staff_id);
            DB.AddParameter("@name", mThisStaff.Name);
            DB.AddParameter("@email_address", mThisStaff.Email);
            DB.AddParameter("@hire_date", mThisStaff.Hire_Date);
            DB.AddParameter("@salary", mThisStaff.Salary);
            DB.AddParameter("@active", mThisStaff.Active);

            DB.Execute("sproc_staff_Update");
        }

        public void ReportByEmail(string Email)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@email_address", Email);
            DB.Execute("sproc_staff_FilterByEmail");
            PopulateArray(DB);
        }

        public void FilterByActive(bool Active)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@active", Active);
            DB.Execute("sproc_staff_FilterByActive");
            PopulateArray(DB);
        }
    }




}