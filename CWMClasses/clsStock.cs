using System;

namespace CWMClasses
{
    public class clsStock
    {
        public int Product_Code { get; set; }
        public object Description { get; set; }
        public double Price { get; set; }
        public int Pristine { get; set; }
        public int Non_Pristine { get; set; }
        public bool Clearence { get; set; }
        public DateTime Next_Intake { get; set; }
    }
}