using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CWMClasses;

public partial class AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        AStaff = (clsStaff)Session["AnAddress"];
        Response.Write(AStaff.staff_id);

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        AStaff.staff_id = Convert.ToInt32(txtStaffID.Text);
        AStaff.Name = txtName.Text;
        AStaff.Email = txtEmail.Text;
        AStaff.Hire_Date = Convert.ToDateTime(txtHireDate.Text);
        AStaff.Active = Convert.ToBoolean(txtActive.Text);
        AStaff.Salary = Convert.ToDouble(txtSalary.Text);
        Session["AStaff"] = AStaff;
        Response.Redirect("StaffViewer.aspx");
    }
}