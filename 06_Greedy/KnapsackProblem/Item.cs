using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    class Item : IComparable<Item>
    {
        public Item(int price, int weight)
        {
            this.Weight = weight;
            this.Price = price;
            this.PriceForWeight = (double)this.Price / this.Weight;
        }


        public int Weight { get; set; }

        public double PriceForWeight { get; set; }

        public int Price { get; set; }

        public int CompareTo(Item other)
        {
            return this.PriceForWeight.CompareTo(other.PriceForWeight) * -1;
        }
    }
}
