using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIntermediate
{
    internal class Inventory:IInventory
    {
        
        public void ActualPricesOfItems(int itemID) {
            Console.WriteLine($"Actual price of the item {itemID} is 2999");
        }

        public void ProfitPercentOnItems(int itemID) {
            Console.WriteLine($"Profit percent on the item {itemID} is 20%");

        }
    }

    public class InventoryFactory
    {
        public IInventory InventoryFactoryObject() { 
            return new Inventory();
        }
    }
}
