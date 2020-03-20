using System;
using System.Collections.Generic;

namespace CWMClasses
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();

        clsStock mThisStock = new clsStock();
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count 
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock 
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Pristine", mThisStock.Pristine);
            DB.AddParameter("@Non_Pristine", mThisStock.Non_Pristine);
            DB.AddParameter("@Clearence", mThisStock.Clearence);
            DB.AddParameter("@Next_Intake", mThisStock.Next_Intake);

            return DB.Execute("sproc_Stock_Insert");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Product_Code", mThisStock.Product_Code);

            DB.Execute("sproc_Stock_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Product_Code", mThisStock.Product_Code);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Pristine", mThisStock.Pristine);
            DB.AddParameter("@Non_Pristine", mThisStock.Non_Pristine);
            DB.AddParameter("@Clearence", mThisStock.Clearence);
            DB.AddParameter("@Next_Intake", mThisStock.Next_Intake);

            DB.Execute("sproc_Stock_Update");

        }

        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_Stock_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsStock stock = new clsStock();

                stock.Product_Code = Convert.ToInt32(DB.DataTable.Rows[Index]["Product_Code"]);
                stock.Clearence = Convert.ToBoolean(DB.DataTable.Rows[Index]["Clearence"]);
                stock.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                stock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                stock.Pristine = Convert.ToInt32(DB.DataTable.Rows[Index]["Pristine"]);
                stock.Non_Pristine = Convert.ToInt32(DB.DataTable.Rows[Index]["Non_Pristine"]);
                stock.Next_Intake = Convert.ToDateTime(DB.DataTable.Rows[Index]["Next_Intake"]);

                mStockList.Add(stock);

                Index++;
            }
        }
    }

    

}