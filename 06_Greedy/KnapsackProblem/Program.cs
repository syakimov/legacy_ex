using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] capacityLine = Console.ReadLine().Split(' ');
            int capacity = int.Parse(capacityLine[1]);

            string[] itemsLine = Console.ReadLine().Split(' ');
            int numberOfItems = int.Parse(itemsLine[1]);

            List<Item> items = new List<Item>();

            for (int i = 0; i < numberOfItems; i++)
            {
                string[] currentLine = Console.ReadLine().Split(' ');
                int price = int.Parse(currentLine[0]);
                int weight = int.Parse(currentLine[2]);

                Item currentItem = new Item(price, weight);
                items.Add(currentItem);
            }

            items.Sort();
            double totalPrice = 0;

            for (int i = 0; i < items.Count; i++)
            {
                var currentItem = items[i];
                if (currentItem.Weight >= capacity)
                {
                    double percentCanTake = (capacity * 100) / (double)currentItem.Weight;
                    double priceForThePart = (percentCanTake * currentItem.Price) / (double)100;

                    totalPrice += priceForThePart;

                    Console.WriteLine("Take {2:F2}% of item with price {0:F2} and weight {1:F2}",
                        currentItem.Price,
                        currentItem.Weight,
                        percentCanTake);

                    break;
                }

                capacity -= currentItem.Weight;
                totalPrice += currentItem.Price;
                Console.WriteLine("Take 100% of item with price {0:F2} and weight {1:F2}",
                    currentItem.Price,
                    currentItem.Weight);
            }

            Console.WriteLine("Total price {0:F2}",totalPrice);
        }
    }
}
