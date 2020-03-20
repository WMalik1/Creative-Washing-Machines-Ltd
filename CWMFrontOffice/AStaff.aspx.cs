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
       
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        AStaff.staff_id = Convert.ToInt32(txtStaffID.Text);
        AStaff.Name = txtName.Text;
        AStaff.Email = txtEmail.Text;
        AStaff.Hire_Date = Convert.ToDateTime(txtHireDate.Text);
        AStaff.Active = Convert.ToBoolean(checkActive.Text);
        AStaff.Salary = Convert.ToDouble(txtSalary.Text);
        Session["AStaff"] = AStaff;
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 staff_id;
        Boolean Found = false;
        staff_id = Convert.ToInt32(txtStaffID.Text);
        Found = AStaff.Find(staff_id);
        if (Found == true)
        {
           
            txtName.Text = AStaff.Name;
            txtEmail.Text = AStaff.Email;
            txtHireDate.Text = AStaff.Hire_Date.ToString("yyyy-MM-dd");
            checkActive.Checked = AStaff.Active;
            txtSalary.Text = AStaff.Salary.ToString("1000");


        }

    }
}