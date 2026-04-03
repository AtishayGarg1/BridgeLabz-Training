using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.inventorymanagementsystem
{
    internal class InventoryNode
    {
        public int ItemId;
        public string ItemName;
        public int Quantity;
        public double Price;

        public InventoryNode next;

        public InventoryNode(int itemId, string itemName, int quantity, double price)
        {
            ItemId = itemId;
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
            next = null;
        }

        public override string ToString()
        {
            return $"Item ID: {ItemId}\nItem Name: {ItemName}\nQuantity: {Quantity}\nPrice: {Price}";
        }
    }
}
