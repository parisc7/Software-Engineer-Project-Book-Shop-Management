using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leksi_Book_Shop
{
    public class Book
    {
        public int ISBN { get; set; }
        public string Authors { get; set; }
        public string Publishers { get; set; }
        public string Title { get; set; }
        public int Pyear { get; set; }
        public double Price { get; set; }


        public Book(int isbn, string authors, string publishers, string title, int pyear, int price)
        {
            ISBN = isbn;
            Authors = authors;
            Publishers = publishers;
            Title = title;
            Pyear = pyear;
            Price = price;
        }

        public Book() { }
    }
}
