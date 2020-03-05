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

        //collect customer name
        string customerName = txtName.Text.Trim().Replace(' ', ',');
        ACustomer.Name = customerName;

        //collect customer address
        string customerAddress = "";
        string[] customerAddressLines = txtAddress.Text.Trim().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        string lastLine = customerAddressLines.Last();

        foreach(string line in customerAddressLines) {
            if (line.Equals(lastLine))
            {
                customerAddress += line;
            } else
            {
                customerAddress += line + ',';
            }
        }
        ACustomer.Address = customerAddress;

        //collect customer email
        ACustomer.Email = txtEmail.Text.Trim();

        //collect customer password
        ACustomer.Password = txtPassword.Text.Trim();

        //collect marketing emails preference
        ACustomer.Marketing_emails = checkMarketingEmails.Checked;

        //customer registration date
        ACustomer.Registration_date = Convert.ToDateTime(txtRegistrationDate.Text);

        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
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