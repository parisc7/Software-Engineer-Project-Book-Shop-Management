/** \file      Customer.cs
*   \brief     Provides the Customer Database
*   \details   This program regards to all the necessary information of Customers
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
    * Class <code>Customer</code> is a class that is responsible for
    * the attribute elements that are related to every Customer
    * <BR>
    * @return Returns the filled up elements (attributes) of each Customer in the database through a linked list between forms created, to retrieve and apply changes
    */
    public class Customer
    {
        // Attributes of each customer
        public int Customer_id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public int Points { get; set; }

        /**
        * Function <code>Customer</code> initialises the Customer attributes
        * <BR>
        * @param customer_id The Customer's unique ID code
        * @param fName       The Customer's First Name
        * @param lName       The Customer's Last Name
        * @param email       The Customer's Email
        * @param address     The Customer's Address
        * @param points      The Customer's Loyalty Points
        */
        // Constructor 
        public Customer(int customer_id, string fName, string lName, string email, int phone, string address,int points)
        {
            Customer_id = customer_id;
            Firstname = fName;
            Lastname = lName;
            Phone = phone;
            Email = email;
            Address = address;
            Points = points;
        }


        // Default Constructor 
        public Customer() { }

        /**
        * Function <code>copy</code> copies Customer attributes to current customer attributes
        * <BR>
        * @param now Represents every current customer on the system
        */
        public void copy(Customer now)
        {

            Customer_id = now.Customer_id;
            Firstname = now.Firstname;
            Lastname = now.Lastname;
            Phone = now.Phone;
            Email = now.Email;
            Address = now.Address;
            Points = now.Points;
        }

    }
}
