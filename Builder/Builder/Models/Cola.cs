using System;
using System.Collections.Generic;
using System.Text;
using Builder.Interfaces;

namespace Builder.Models
{
    public class Cola : Drink
    {
        public override string Name => "Cols";
        public override float Price => 1.5f;
    }
}
