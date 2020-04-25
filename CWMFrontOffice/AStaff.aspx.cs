using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CWMClasses;

public partial class AStaff : System.Web.UI.Page
{
    Int32 staff_id;
    protected void Page_Load(object sender, EventArgs e)
    {

        staff_id = Convert.ToInt32(Session["staff_id"]);
        if (IsPostBack == false)
        {
            if (staff_id != -1)
            {
                DisplayStaff();
            }

        }
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string Hire_Date = txtHireDate.Text;
        bool Active = checkActive.Checked;
        string Salary = txtSalary.Text;
        string Error = "";

        Error = AStaff.Valid(Name, Email, Hire_Date, Salary);

        if (Error == "")

        {
            AStaff.staff_id = staff_id;
            AStaff.Name = Name;
            AStaff.Email = Email;
            AStaff.Hire_Date = Convert.ToDateTime(Hire_Date);
            AStaff.Active = checkActive.Checked;
            AStaff.Salary = Convert.ToDouble(Salary);
            clsStaffCollection StaffList = new clsStaffCollection();
            
            if (staff_id == -1)
            {
                StaffList.ThisStaff = AStaff;
                StaffList.Add();
            
            }
            else
            {
                StaffList.ThisStaff.Find(staff_id);
                StaffList.ThisStaff = AStaff;
                StaffList.Update();
            }

            Response.Redirect("StaffList.aspx");

        }
        else

        {

            lblError.Text = Error;

        }

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


    void DisplayStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(staff_id);
        txtStaffID.Text = StaffBook.ThisStaff.staff_id.ToString();
        txtName.Text = StaffBook.ThisStaff.Name;
        txtEmail.Text = StaffBook.ThisStaff.Email;
        txtHireDate.Text = StaffBook.ThisStaff.Hire_Date.ToString();
        checkActive.Checked = StaffBook.ThisStaff.Active;
    }
}