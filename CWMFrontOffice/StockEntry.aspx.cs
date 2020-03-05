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
        stock.Description = txtDescription.Text;
        stock.Price = Convert.ToDouble(txtPrice.Text);
        stock.Next_Intake = System.DateTime.Now.Date;
        stock.Pristine = Convert.ToInt32(txtPristine);
        stock.Non_Pristine = Convert.ToInt32(txtNon_Pristine);
        stock.Clearence = Convert.ToBoolean(txtClearence);
        Session["StockItem"] = stock;
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock stock = new clsStock();
        Int32 Product_Code;
        Boolean Found = false;
        Product_Code = Convert.ToInt32(txtProductCode.Text);
        Found = stock.Find(Product_Code);

        if (Found == true)
        {
            // txtProductCode.Text = stock.Product_Code.ToString();
            txtDescription.Text = stock.Description;
            txtPrice.Text = stock.Price.ToString();
            txtNext_Intake.Text = stock.Next_Intake.ToString();
            txtPristine.Text = stock.Pristine.ToString();
            txtNon_Pristine.Text = stock.Non_Pristine.ToString();
            txtClearence.Text = stock.Clearence.ToString();
            

        }
    }
}