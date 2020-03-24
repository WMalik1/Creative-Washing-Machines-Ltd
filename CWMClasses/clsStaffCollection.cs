using System;
using System.Collections.Generic;

namespace CWMClasses
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();

        public clsStaff ThisStaff { get; set; }

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

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_staff_SelectAll");
            RecordCount = DB.Count;
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
    }




}