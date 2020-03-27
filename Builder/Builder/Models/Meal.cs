using System;
using System.Collections.Generic;
using System.Text;
using Builder.Interfaces;
using System.Linq;

namespace Builder.Models
{
    public class Meal
    {
        private List<IItems> _items = new List<IItems>();

        public void AddItem(IItems item)
        {
            _items.Add(item);
        }
        public float GetCost()
        {
            return _items.Sum(i => i.Price);
        }
        public void ShowItems()
        {
            foreach(var item in _items)
            {
                Console.WriteLine($"{item.Name} || {item.Packing.Pack} || {item.Price}");
            }
        }
    }
}
