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
        string customerName = nameText.Text.Trim().Replace(' ', ',');
        ACustomer.name = customerName;

        //collect customer address
        string customerAddress = "";
        string[] customerAddressLines = addressText.Text.Trim().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
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
        ACustomer.address = customerAddress;

        //collect customer email
        ACustomer.email = emailText.Text.Trim();

        //collect customer password
        ACustomer.password = passwordText.Text.Trim();

        //collect marketing emails preference
        ACustomer.marketing_emails = marketingEmailsCheck.Checked;

        //customer registration date
        ACustomer.registration_date = System.DateTime.Now.Date;
            
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }
}