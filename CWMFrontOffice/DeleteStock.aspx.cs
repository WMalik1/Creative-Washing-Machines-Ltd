using CWMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStock : System.Web.UI.Page
{
    Int32 Product_Code;
    protected void Page_Load(object sender, EventArgs e)
    {
        Product_Code = Convert.ToInt32(Session["Product_Code"]);
    }

    protected void Yes_Click(object sender, EventArgs e)
    {
        clsStockCollection StockFile = new clsStockCollection();

        StockFile.ThisStock.Find(Product_Code);

        StockFile.Delete();

        Response.Redirect("StockList.aspx");
    }

    protected void No_Click(object sender, EventArgs e)
    {

    }
}