using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    public class ChickenBurger : Burger
    {
        public override string Name => "Chickenburger";
        public override float Price => 2.5f;
    }
}
