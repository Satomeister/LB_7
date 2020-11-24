using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_7_3.Classes
{
    class Article
    {
        public List<Item> Goods { get; set; }
        public string StoreName { get; set; }
        public double Cost { get; set; }
        public Article (List<Item> goods, string storeName)
        {
            Goods = goods;
            StoreName = storeName;
            Cost = GetCost();
        }
        private double GetCost()
        {
            double cost = 0;
            foreach (Item g in Goods)
            {
                cost += g.Price * g.Count;
            }
            return cost;
        }
        public void AddItem(Item item)
        {
            Goods.Add(item);
        }
    }
}
