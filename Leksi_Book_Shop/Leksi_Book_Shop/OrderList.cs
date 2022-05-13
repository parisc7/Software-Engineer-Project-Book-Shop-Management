/** \file      OrderList.cs
*   \brief     Provides the OrderList Database, which includes the order database for linking purposes
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
    * Class <code>OrderList</code> is a class that is responsible for
    * the attribute elements that are related to every order which is then linked to order list as a unique order ID for the specific Client ID buyer
    * <BR>
    * @return Returns the filled up elements (attributes) of each order (in the order list) in the database through a linked list between forms created, to retrieve and apply changes
    */
    public class OrderList
    {
        // Attributes of each order in the order list
        public int OrderID { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        // Default Constructor
        public OrderList()
        {
            
        }

        /**
        * Function <code>OrderList</code> initialises the order list attributes
        * <BR>
        * @param orderID    The order's unique ID code
        * @param price      The order's Price
        * @param quantity    The order's Quantity
        */

        // Constructor 
        public OrderList(int orderID, double price,int quantity)
        {
            this.OrderID = orderID;
            this.Price = price;
            this.Quantity = quantity; 
        }
    }
}
