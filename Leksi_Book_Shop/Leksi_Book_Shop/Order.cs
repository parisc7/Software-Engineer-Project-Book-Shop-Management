using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leksi_Book_Shop
{
    public class Order
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


        public Order()
        {

        }

        public Order(int isbn,string title,double price,int quantity)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Price = price;
            this.Quantity = quantity;
        }


    }
}
