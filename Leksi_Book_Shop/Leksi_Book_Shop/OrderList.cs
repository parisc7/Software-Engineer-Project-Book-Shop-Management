using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leksi_Book_Shop
{
    public class OrderList
    {
        public int OrderID { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public OrderList()
        {
            
        }
        public OrderList(int orderID, double price,int quatity)
        {
            this.OrderID = orderID;
            this.Price = price;
            this.Quantity = quatity;
        }
    }
}
