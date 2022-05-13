/** \file      Book.cs
*   \brief     Provides the Book Database
*   \details   This program regards to all the necessary information of books
*   \author    SOFTTSING TEAM
*   \version   2.0
*   \date      2022-2022
*   \bug       No bugs Included
*   \copyright SOFTTSING Ltd.
*/

// Packets Used
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leksi_Book_Shop
{
    /**
    * Class <code>Book</code> is a class that is responsible for
    * the attribute elements that are related to every book
    * <BR>
    * @return Returns the filled up elements (attributes) of each book in the database through a linked list between forms created, to retrieve and apply changes
    */
    public class Book
    {
        // Attributes of each book
        public int ISBN { get; set; }
        public string Authors { get; set; }
        public string Publishers { get; set; }
        public string Title { get; set; }
        public int Pyear { get; set; }
        public double Price { get; set; }
             
        /**
        * Function <code>Book</code> initialises the book attributes
        * <BR>
        * @param isbn       The Book's isbn unique code
        * @param authors    The Book's Authors
        * @param publishers The Book's Publisher
        * @param title      The Book's Title
        * @param pyear      The Book's Production year
        * @param price      The Book's Total Price
        */
        public Book(int isbn, string authors, string publishers, string title, int pyear, int price)
        {
            ISBN = isbn;
            Authors = authors;
            Publishers = publishers;
            Title = title;
            Pyear = pyear;
            Price = price;
        }

        // Default Constructor 
        public Book() { }
    }
}
