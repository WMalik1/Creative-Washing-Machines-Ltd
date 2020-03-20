using CWMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "Customer_id";
        lstCustomers.DataTextField = "Name";
        lstCustomers.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["Customer_id"] = -1;
        Response.Redirect("ACustomer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int Customer_id;

        if (lstCustomers.SelectedIndex != -1)
        {
            Customer_id = Convert.ToInt32(lstCustomers.SelectedValue);
            Session["Customer_id"] = Customer_id;
            Response.Redirect("DeleteCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list!";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int Customer_id;

        if (lstCustomers.SelectedIndex != -1)
        {
            Customer_id = Convert.ToInt32(lstCustomers.SelectedValue);
            Session["Customer_id"] = Customer_id;
            Response.Redirect("ACustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list!";
        }
    }

    protected void btnMarketingSearch_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.FilterByMarketingPreference(Convert.ToBoolean(lstPreference.Text));
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "Customer_id";
        lstCustomers.DataTextField = "Name";
        lstCustomers.DataBind();
    }
    protected void btnAddressSearch_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.FilterByAddress(txtAddress.Text);
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "Customer_id";
        lstCustomers.DataTextField = "Name";
        lstCustomers.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.FilterByAddress("");
        txtAddress.Text = "";
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "Customer_id";
        lstCustomers.DataTextField = "Name";
        lstCustomers.DataBind();
    }

}