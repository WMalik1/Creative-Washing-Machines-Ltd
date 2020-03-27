using System;
using CWMClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffList : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        lstStaff.DataSource = Staff.StaffList;
        lstStaff.DataValueField = "staff_id";
        lstStaff.DataTextField = "Name";
        lstStaff.DataBind();
    }
}