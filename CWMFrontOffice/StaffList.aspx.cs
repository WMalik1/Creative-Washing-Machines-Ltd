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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["staff_id"] = -1;
        Response.Redirect("AStaff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 staff_id;

        if (lstStaff.SelectedIndex != -1)
        {
            staff_id = Convert.ToInt32(lstStaff.SelectedValue);
            Session["staff_id"] = staff_id;
            Response.Redirect("DeleteAddress.aspsx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 staff_id;

        if (lstStaff.SelectedIndex != -1)
        {
            staff_id = Convert.ToInt32(lstStaff.SelectedValue);
            Session["staff_id"] = staff_id;
            Response.Redirect("AStaff.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply2_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByEmail(txtFilter.Text);
        lstStaff.DataSource = Staff.StaffList;
        lstStaff.DataValueField = "staff_id";
        lstStaff.DataTextField = "Email";
        lstStaff.DataBind();
    }

    protected void btnClear2_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByEmail("");
        txtFilter.Text = "";
        lstStaff.DataSource = Staff.StaffList;
        lstStaff.DataValueField = "staff_id";
        lstStaff.DataTextField = "Name";
        lstStaff.DataBind();
    }

    protected void btnApply1_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.FilterByActive(Convert.ToBoolean(lstActive.Text));
        lstStaff.DataSource = Staff.StaffList;
        lstStaff.DataValueField = "staff_id";
        lstStaff.DataTextField = "Name";
        lstStaff.DataBind();

    }

    
}