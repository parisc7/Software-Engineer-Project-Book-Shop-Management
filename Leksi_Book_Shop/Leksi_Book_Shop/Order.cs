/** \file      Order.cs
*   \brief     Provides the Order Database
*   \details   This program regards to all the necessary information of orders
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
    * Class <code>Order</code> is a class that is responsible for
    * the attribute elements that are related to every order
    * <BR>
    * @return Returns the filled up elements (attributes) of each order in the database through a linked list between forms created, to retrieve and apply changes
    */
    public class Order
    {
        // Attributes of every book order
        public int ISBN { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Default Constructor 
        public Order(){}

        // Constructor 

        /**
        * Function <code>Order</code> initialises the order attributes, which orders are the books
        * <BR>
        * @param isbn       The book's unique ID code
        * @param title      The book's title
        * @param price      The book's price
        * @param quantity   The book's quantity
        */
        // Constructor 
        public Order(int isbn,string title,double price,int quantity)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Price = price;
            this.Quantity = quantity;
        }


    }
}
