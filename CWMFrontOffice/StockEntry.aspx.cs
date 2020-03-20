using CWMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockEntry : System.Web.UI.Page
{
    Int32 Product_Code;
    protected void Page_Load(object sender, EventArgs e)
    {
        Product_Code = Convert.ToInt32(Session["Product_Code"]);
        if (IsPostBack == false)
        {
            if (Product_Code != 1)
            {
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        clsStockCollection StockFile = new clsStockCollection();

        StockFile.ThisStock.Find(Product_Code);

        txtProductCode.Text = StockFile.ThisStock.Product_Code.ToString();
        txtDescription.Text = StockFile.ThisStock.Description;
        txtPrice.Text = StockFile.ThisStock.Price.ToString();
        txtPristine.Text = StockFile.ThisStock.Pristine.ToString();
        txtNon_Pristine.Text = StockFile.ThisStock.Non_Pristine.ToString();
        checkClearence.Checked = StockFile.ThisStock.Clearence;
        txtNext_Intake.Text = StockFile.ThisStock.Next_Intake.ToString();
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock stock = new clsStock();

        string Description = txtDescription.Text;
        string Price = txtPrice.Text;
        string Next_Intake = txtNext_Intake.Text;
        string Pristine = txtPristine.Text;
        string Non_Pristine = txtNon_Pristine.Text;
        
        string Error = "";

        Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);

        if (Error == "")
        {
            stock.Product_Code = Product_Code;
            stock.Description = Description;
            stock.Price = Convert.ToDouble(Price);
            stock.Next_Intake = Convert.ToDateTime(Next_Intake);
            stock.Pristine = Convert.ToInt32(Pristine);
            stock.Non_Pristine = Convert.ToInt32(Non_Pristine);
            stock.Clearence = checkClearence.Checked;

            clsStockCollection StockList = new clsStockCollection();

            if (Product_Code == -1)
            {
                StockList.ThisStock = stock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(Product_Code);
                StockList.ThisStock = stock;
                StockList.Update();
            }
            Response.Redirect("StockList.aspx");
        } 
        else
        {
            lblError.Text = Error;
        }

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
            txtDescription.Text = stock.Description;
            txtPrice.Text = stock.Price.ToString();
            txtNext_Intake.Text = stock.Next_Intake.ToString();
            txtPristine.Text = stock.Pristine.ToString();
            txtNon_Pristine.Text = stock.Non_Pristine.ToString();
            checkClearence.Checked = stock.Clearence;
            

        }
    }
}