
using System;

namespace FlashDealz
{
    class Product
    {
        public string Name;
        public int Discount;
    }

    class ProductSorter
    {
        private Product[] products;
        private int count;

        public ProductSorter(int size)
        {
            products = new Product[size];
            count = 0;
        }

        public void AddProduct(string name, int discount)
        {
            products[count++] = new Product { Name = name, Discount = discount };
        }

        public void QuickSort(int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(low, high);
                QuickSort(low, pivotIndex - 1);
                QuickSort(pivotIndex + 1, high);
            }
        }

        private int Partition(int low, int high)
        {
            int pivot = products[high].Discount;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (products[j].Discount > pivot)
                {
                    i++;
                    Swap(i, j);
                }
            }
            Swap(i + 1, high);
            return i + 1;
        }

        private void Swap(int i, int j)
        {
            Product temp = products[i];
            products[i] = products[j];
            products[j] = temp;
        }

        public void Display()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(products[i].Name + " - " + products[i].Discount + "%");
        }

        static void Main()
        {
            ProductSorter sorter = new ProductSorter(10);
            sorter.AddProduct("Phone", 40);
            sorter.AddProduct("Laptop", 60);
            sorter.AddProduct("Shoes", 30);
            sorter.AddProduct("Watch", 50);

            sorter.QuickSort(0, 3);
            sorter.Display();
        }
    }
}
