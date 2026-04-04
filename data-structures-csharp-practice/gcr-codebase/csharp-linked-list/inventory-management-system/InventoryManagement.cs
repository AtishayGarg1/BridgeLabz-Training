using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.inventorymanagementsystem
{
    internal class InventoryManagement
    {
        private InventoryNode head;

        public InventoryManagement()
        {
            head = null;
        }

        public void AddAtBeginning(int itemId, string itemName, int quantity, double price)
        {
            InventoryNode node = new InventoryNode(itemId, itemName, quantity, price);
            node.next = head;
            head = node;
        }

        public void AddAtEnd(int itemId, string itemName, int quantity, double price)
        {
            InventoryNode node = new InventoryNode(itemId, itemName, quantity, price);

            if (head == null)
            {
                head = node;
                return;
            }

            InventoryNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
        }

        public void AddAtPosition(int itemId, string itemName, int quantity, double price, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(itemId, itemName, quantity, price);
                return;
            }

            InventoryNode temp = head;
            int count = 1;

            while (temp != null && count < position - 1)
            {
                temp = temp.next;
                count++;
            }

            if (temp == null)
            {
                AddAtEnd(itemId, itemName, quantity, price);
                return;
            }

            InventoryNode node = new InventoryNode(itemId, itemName, quantity, price);
            node.next = temp.next;
            temp.next = node;
        }

        public void RemoveByItemId(int itemId)
        {
            if (head == null)
                return;

            if (head.ItemId == itemId)
            {
                head = head.next;
                return;
            }

            InventoryNode temp = head;
            while (temp.next != null)
            {
                if (temp.next.ItemId == itemId)
                {
                    temp.next = temp.next.next;
                    return;
                }
                temp = temp.next;
            }
        }

        public void UpdateQuantity(int itemId, int newQuantity)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.ItemId == itemId)
                {
                    temp.Quantity = newQuantity;
                    return;
                }
                temp = temp.next;
            }
        }

        public void SearchByItemId(int itemId)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.ItemId == itemId)
                {
                    Console.WriteLine(temp);
                    return;
                }
                temp = temp.next;
            }
        }

        public void SearchByItemName(string itemName)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(temp);
                }
                temp = temp.next;
            }
        }

        public void DisplayTotalInventoryValue()
        {
            double total = 0;
            InventoryNode temp = head;

            while (temp != null)
            {
                total += temp.Price * temp.Quantity;
                temp = temp.next;
            }

            Console.WriteLine("Total Inventory Value: " + total);
        }

        public void SortByItemName(bool ascending)
        {
            if (head == null)
                return;

            for (InventoryNode i = head; i.next != null; i = i.next)
            {
                for (InventoryNode j = i.next; j != null; j = j.next)
                {
                    if ((ascending && string.Compare(i.ItemName, j.ItemName) > 0) ||
                        (!ascending && string.Compare(i.ItemName, j.ItemName) < 0))
                    {
                        SwapData(i, j);
                    }
                }
            }
        }

        public void SortByPrice(bool ascending)
        {
            if (head == null)
                return;

            for (InventoryNode i = head; i.next != null; i = i.next)
            {
                for (InventoryNode j = i.next; j != null; j = j.next)
                {
                    if ((ascending && i.Price > j.Price) ||
                        (!ascending && i.Price < j.Price))
                    {
                        SwapData(i, j);
                    }
                }
            }
        }

        private void SwapData(InventoryNode a, InventoryNode b)
        {
            int tempId = a.ItemId;
            string tempName = a.ItemName;
            int tempQty = a.Quantity;
            double tempPrice = a.Price;

            a.ItemId = b.ItemId;
            a.ItemName = b.ItemName;
            a.Quantity = b.Quantity;
            a.Price = b.Price;

            b.ItemId = tempId;
            b.ItemName = tempName;
            b.Quantity = tempQty;
            b.Price = tempPrice;
        }

        public void DisplayAllItems()
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp);
                temp = temp.next;
            }
        }
    }
}
