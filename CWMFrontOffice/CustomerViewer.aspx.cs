using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CWMClasses;


public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer = (clsCustomer)Session["ACustomer"];
        Response.Write(ACustomer.name + "<br />");
        Response.Write(ACustomer.address + "<br />");
        Response.Write(ACustomer.email + "<br />");
        Response.Write(ACustomer.password + "<br />");
        Response.Write(ACustomer.marketing_emails + "<br />");
        Response.Write(ACustomer.registration_date.ToShortDateString());
    }
}