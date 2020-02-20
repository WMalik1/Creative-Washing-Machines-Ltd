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
        Response.Write(ACustomer.Name + "<br />");
        Response.Write(ACustomer.Address + "<br />");
        Response.Write(ACustomer.Email + "<br />");
        Response.Write(ACustomer.Password + "<br />");
        Response.Write(ACustomer.Marketing_emails + "<br />");
        Response.Write(ACustomer.Registration_date.ToShortDateString());
    }
}