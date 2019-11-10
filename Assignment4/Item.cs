using System;

namespace Assignment4
{
    class Item
    {      
        public static int ID;
        public static string description;
        public static float availableQty;
        public static double unitPrice;        
        
        //Updates the current available quantity by add/subtracting
        //the passed value and returns new quantity
        private int updateAvlblQty(int quantity)
        {
            
            
            return ; 
        }

        //Returns the item's unit price
        static (double,double,double) getPrice(double price)
        {
            double price1 = 1.99;
            double price2 = 3.99;
            double price3 = 5.99; 

            return (price1, price2, price3);
        }

        //Returns the item's description
        static string getItemDescription(Item.122, Item.124, Item.126)
        {
            description1 = "groceries #1";
            description2 = "groceries #2";
            description3 = "groceries #3";

            return (description1, description2, description3); 
        }

        //Returns the item's ID
        static int getItemID(int ID)
        {
            int index1 = 122;
            int index2 = 124; 
            int index3 = 126; 

            return (index1, index2, index3); 
                
        }

        //Displays the item info to console(id, desc, price, avlbl )
        static string displayItem(string displayItem)
        {
            Console.WriteLine($"{getItemID}{getItemDescription}{availableQty}{getPrice}");
        
            return displayItem;
        }
    }
}
