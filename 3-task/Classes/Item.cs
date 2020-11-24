using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_7_3.Classes
{
    class Item
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public double Price { get; set; }

        public Item(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
    }
}
