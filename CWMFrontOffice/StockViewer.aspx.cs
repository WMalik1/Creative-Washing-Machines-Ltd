using CWMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock stock = new clsStock();
        stock = (clsStock)Session["StockItem"];
        Response.Write(stock.Description + "<br />");
        Response.Write(stock.Price + "<br />");
        Response.Write(stock.Next_Intake + "<br />");
        Response.Write(stock.Pristine + "<br />");
        Response.Write(stock.Non_Pristine + "<br />");
        Response.Write(stock.Clearence + "<br />");

    }
}