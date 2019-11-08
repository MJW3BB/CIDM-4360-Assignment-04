using System;

namespace Assignment4
{
    class Item
    {
        static void Main(string[] args)
        {
           
            int ID;
            string description;
            float availableQty;
            double unitPrice;        
        
            //Updates the current available quantity by add/subtracting
            //the passed value and returns new quantity
            static int updateAvlblQty(int qty1, int qty2, int qty3)
            {
                qty1 = 30;
                qty2 = 10;
                qty3 = 20; 

                return qty1, qty2, qty3; 
            }

            //Returns the item's unit price
            static double getPrice(double price1, double price2, double price3)
            {
                price1 = 1.99;
                price2 = 3.99;
                price3 = 5.99; 

                return price1, price2, price3;
            }

            //Returns the item's description
            static string getItemDescription(string description1, string description2, string description3)
            {
                description1 = "groceries #1";
                description2 = "groceries #2";
                description3 = "groceries #3";

                return description1, description2, description3; 
            }

            //Returns the item's ID
            static int getItemID(int ID)
            {
                int index1 = 122;
                int index2 = 124; 
                int index3 = 126; 

                return index1, index2, index3; 
                
            }

            //Displays the item info to console(id, desc, price, avlbl )
            static string displayItem(string displayItem)
            {
                Console.WriteLine($"{getItemID}{getItemDescription}{availableQty}{getPrice}")
            
                return displayItem;
            }
        }
    }
}