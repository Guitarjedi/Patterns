using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    public abstract class Drink  : Interfaces.IItems
    {
        public abstract string Name { get; }
        public abstract float Price { get; }

        public IPacking Packing => new Bottle();
    }
}
