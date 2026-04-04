using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.sorting
{
    internal class BookPrices
    {
        public void MergeSort(int[] prices, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(prices, left, mid);
                MergeSort(prices, mid + 1, right);

                Merge(prices, left, mid, right);
            }
        }

        private void Merge(int[] prices, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = prices[left + i];

            for (int j = 0; j < n2; j++)
                rightArray[j] = prices[mid + 1 + j];

            int iIndex = 0, jIndex = 0, k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    prices[k++] = leftArray[iIndex++];
                }
                else
                {
                    prices[k++] = rightArray[jIndex++];
                }
            }

            while (iIndex < n1)
                prices[k++] = leftArray[iIndex++];

            while (jIndex < n2)
                prices[k++] = rightArray[jIndex++];
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
            BookPrices bookPrices = new BookPrices();
            int[] priceArray = { 450, 299, 799, 199, 999, 349, 599 };

            Console.WriteLine("Book prices before sorting: ");
            bookPrices.DisplayAll(priceArray);

            bookPrices.MergeSort(priceArray, 0, priceArray.Length - 1);

            Console.WriteLine("\n\nBook prices after sorting (Ascending Order): ");
            bookPrices.DisplayAll(priceArray);
        }
    }
}

