using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leksi_Book_Shop
{
    internal class Customer
    {
        public int Customer_id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
      

        public Customer(int customer_id, string fName, string lName, string email, int phone, string address)
        {
            Customer_id = customer_id;
            FName = fName;
            LName = lName;
            Phone = phone;
            Email = email;
            Address = address;
        }

        public Customer() { }
    }
}
