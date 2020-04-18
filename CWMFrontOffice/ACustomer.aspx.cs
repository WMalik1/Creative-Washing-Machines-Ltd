using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CWMClasses;

public partial class ACustomer : System.Web.UI.Page
{
    int Customer_id;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Customer_id"] == null)
        {
            Customer_id = -1;
        } else
        {
            Customer_id = Convert.ToInt32(Session["Customer_id"]);
        }

        if (IsPostBack == false)
        {
            if (Customer_id != -1)
            {
                DisplayAddress();
            }
        }
    }

    protected void DisplayAddress()
    {
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        CustomerList.ThisCustomer.Find(Customer_id);

        txtName.Text = CustomerList.ThisCustomer.Name.Replace(',', ' ');

        string customerAddress = "";
        string[] customerAddressLines = CustomerList.ThisCustomer.Address.Split(',');
        string lastLine = customerAddressLines.Last();
        foreach (string line in customerAddressLines)
        {
            if (line.Equals(lastLine))
            {
                customerAddress += line;
            }
            else
            {
                customerAddress += line + Environment.NewLine;
            }
        }
        txtAddress.Text = customerAddress;

        txtEmail.Text = CustomerList.ThisCustomer.Email;
        txtPassword.Attributes["value"] = CustomerList.ThisCustomer.Password;
        checkMarketingEmails.Checked = CustomerList.ThisCustomer.Marketing_emails;
        txtRegistrationDate.Text = CustomerList.ThisCustomer.Registration_date.ToString("yyyy-MM-dd");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();

        //collect customer data
        string customerName = txtName.Text.Trim().Replace(' ', ',');
        string customerEmail = txtEmail.Text.Trim();
        string customerPassword = txtPassword.Text.Trim();
        bool customerMarketingEmails = checkMarketingEmails.Checked;
        string customerRegistrationDate = txtRegistrationDate.Text.Trim();

        string customerAddress = "";
        string[] customerAddressLines = txtAddress.Text.Trim().Replace(",", String.Empty).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        string lastLine = customerAddressLines.Last();
        foreach (string line in customerAddressLines)
        {
            if (line.Equals(lastLine))
            {
                customerAddress += line;
            }
            else
            {
                customerAddress += line + ',';
            }
        }

        string Error = "";
        Error = ACustomer.Valid(customerName, customerAddress, customerEmail, customerPassword, customerRegistrationDate);

        if (Error == "")
        {
            ACustomer.Customer_id = Customer_id;
            ACustomer.Name = customerName;
            ACustomer.Address = customerAddress;
            ACustomer.Email = customerEmail;
            ACustomer.Password = customerPassword;
            ACustomer.Marketing_emails = customerMarketingEmails;
            ACustomer.Registration_date = Convert.ToDateTime(customerRegistrationDate);

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            
            if (Customer_id == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(Customer_id);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }

            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 Customer_id;
        if (txtCustomerID.Text.Length != 0)
        {
            Customer_id = Convert.ToInt32(txtCustomerID.Text);
        } else
        {
            Customer_id = 1;
        }
        Boolean Found = ACustomer.Find(Customer_id);

        if (Found == true)
        {
            txtName.Text = ACustomer.Name.Replace(',', ' ');

            string customerAddress = "";
            string[] customerAddressLines = ACustomer.Address.Split(',');
            string lastLine = customerAddressLines.Last();
            foreach (string line in customerAddressLines)
            {
                if (line.Equals(lastLine))
                {
                    customerAddress += line;
                }
                else
                {
                    customerAddress += line + Environment.NewLine;
                }
            }
            txtAddress.Text = customerAddress;

            txtEmail.Text = ACustomer.Email;
            txtPassword.Attributes["value"] = ACustomer.Password;
            checkMarketingEmails.Checked = ACustomer.Marketing_emails;
            txtRegistrationDate.Text = ACustomer.Registration_date.ToString("yyyy-MM-dd");
        }

    }
}