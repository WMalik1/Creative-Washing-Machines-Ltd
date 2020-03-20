using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CWMClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        AStaff = (clsStaff)Session["AStaff"];
        Response.Write(AStaff.staff_id);
        Response.Write(AStaff.Name + "<br />");
        Response.Write(AStaff.Email + "<br />");
        Response.Write(AStaff.Hire_Date.ToShortDateString());
        Response.Write(AStaff.Active + "<br />");
        Response.Write(AStaff.Salary + "<br />");
    }


}