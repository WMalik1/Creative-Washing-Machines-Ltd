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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["Product_Code"] = -1;
        Response.Redirect("StockEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 Product_Code;
        if (lstStockList.SelectedIndex != 1)
        {
            Product_Code = Convert.ToInt32(lstStockList.SelectedValue);

            Session["Product_Code"] = Product_Code;

            Response.Redirect("DeleteStock.aspx");
        }
        else
        {
            lblError.Text = "Please select a stock item to delete from the list";
        }
    }

}