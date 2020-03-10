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

        string Description = txtDescription.Text;
        string Price = txtPrice.Text;
        string Next_Intake = txtNext_Intake.Text;
        string Pristine = txtPristine.Text;
        string Non_Pristine = txtNon_Pristine.Text;
        
        string Error = "";

        Error = stock.Valid(Description, Price, Pristine, Non_Pristine, Next_Intake);

        if (Error == "")
        {
            stock.Description = Description;
            stock.Price = Convert.ToDouble(Price);
            stock.Next_Intake = Convert.ToDateTime(Next_Intake);
            stock.Pristine = Convert.ToInt32(Pristine);
            stock.Non_Pristine = Convert.ToInt32(Non_Pristine);
            stock.Clearence = checkClearence.Checked;

            Session["stock"] = stock;
            Response.Write("stockViewer.aspx");
        } else
        {
            
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