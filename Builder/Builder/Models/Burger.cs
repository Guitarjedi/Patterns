using System;
using System.Collections.Generic;
using System.Text;
using Builder.Interfaces;

namespace Builder.Models
{
    public abstract class Burger : Interfaces.IItems
    {
        public abstract string Name { get; }
        public IPacking Packing => new Box();
        public abstract float Price { get; }
    }
}
