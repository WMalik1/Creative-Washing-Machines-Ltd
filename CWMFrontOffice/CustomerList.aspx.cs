﻿using CWMClasses;
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

}