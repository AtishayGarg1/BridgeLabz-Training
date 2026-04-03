using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased
{
    internal class InvoiceGenerator
    {
        static void Main()
        {
            Console.WriteLine("Enter invoice description:");
            string input = Console.ReadLine();

            string[] tasks = FormatInvoice(input);
            int totalAmount = GetTotalAmount(tasks);

            Console.WriteLine("\nInvoice Details:");
            foreach (string task in tasks)
            {
                Console.WriteLine(task.Trim());
            }

            Console.WriteLine("\nTotal Invoice Amount: " + totalAmount + " INR");
        }

        static string[] FormatInvoice(string input)
        {
            return input.Split(',');
        }

        static int GetTotalAmount(string[] tasks)
        {
            int total = 0;

            foreach (string task in tasks)
            {
                string[] parts = task.Split('-');

                if (parts.Length == 2)
                {
                    string amountPart = parts[1].Replace("INR", "").Trim();

                    int amount = int.Parse(amountPart);
                    total += amount;
                }
            }

            return total;
        }
    }
}
