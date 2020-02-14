using CWMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock stock = new clsStock();
        stock.Description = DescriptionText.Text;
        stock.Price = Convert.ToDouble(PriceValue.Text);
        stock.Next_Intake = System.DateTime.Now.Date;
        stock.Pristine = Convert.ToInt32(Pristine.Checked);
        stock.Non_Pristine = Convert.ToInt32(NonPristine.Checked);
        stock.Clearence = Convert.ToBoolean(Clearence.Checked);
        Session["StockItem"] = stock;
        Response.Redirect("StockViewer.aspx");
    }

}