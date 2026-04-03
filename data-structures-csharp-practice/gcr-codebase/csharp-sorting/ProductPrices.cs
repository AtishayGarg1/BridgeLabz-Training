using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.sorting
{
    internal class ProductPrices
    {
        public void QuickSort(int[] prices, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(prices, low, high);

                QuickSort(prices, low, pivotIndex - 1);
                QuickSort(prices, pivotIndex + 1, high);
            }
        }

        private int Partition(int[] prices, int low, int high)
        {
            int pivot = prices[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (prices[j] <= pivot)
                {
                    i++;
                    int temp = prices[i];
                    prices[i] = prices[j];
                    prices[j] = temp;
                }
            }

            int swap = prices[i + 1];
            prices[i + 1] = prices[high];
            prices[high] = swap;

            return i + 1;
        }

        public void DisplayAll(int[] prices)
        {
            for (int i = 0; i < prices.Length - 1; i++)
            {
                Console.Write(prices[i] + ", ");
            }
            Console.Write(prices[prices.Length - 1]);
        }

        static void Main(string[] args)
        {
            ProductPrices productPrices = new ProductPrices();
            int[] priceArray = { 1599, 799, 1299, 499, 999, 1899, 699 };

            Console.WriteLine("Before Sorting:");
            productPrices.DisplayAll(priceArray);

            productPrices.QuickSort(priceArray, 0, priceArray.Length - 1);

            Console.WriteLine("\n\nAfter Sorting:");
            productPrices.DisplayAll(priceArray);
        }
    }
}
