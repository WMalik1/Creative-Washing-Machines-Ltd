using System;

namespace CWMClasses
{
    public class clsCustomer
    {
        public int customer_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool marketing_emails { get; set; }
        public DateTime registration_date { get; set; }

    }
}