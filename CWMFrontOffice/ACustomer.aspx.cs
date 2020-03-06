using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CWMClasses;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
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
            ACustomer.Name = customerName;
            ACustomer.Address = customerAddress;
            ACustomer.Email = customerEmail;
            ACustomer.Password = customerPassword;
            ACustomer.Marketing_emails = customerMarketingEmails;
            ACustomer.Registration_date = Convert.ToDateTime(customerRegistrationDate);
            Session["ACustomer"] = ACustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 Customer_id;
        Customer_id = Convert.ToInt32(txtCustomerID.Text);
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