using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack == false)
        {
            DisplayStockItems();
        }

    }

    void DisplayStockItems()
    {
        CWMClasses.clsStockCollection stockItems = new CWMClasses.clsStockCollection();

        lstStockList.DataSource = stockItems.StockList;

        lstStockList.DataValueField = "Product_Code";

        lstStockList.DataTextField = "Description";

        lstStockList.DataBind();
    }
}