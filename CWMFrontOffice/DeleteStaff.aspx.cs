using CWMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStaff : System.Web.UI.Page
{
    Int32 staff_id;
    protected void Page_Load(object sender, EventArgs e)
    {
       staff_id = Convert.ToInt32(Session["staff_id"]);
    }


    protected void Yes_Click(object sender, EventArgs e)
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(staff_id);
        StaffBook.Delete();
        Response.Redirect("StaffList.aspx");
    }

    protected void No_Click(object sender, EventArgs e)
    {

    }
}


}