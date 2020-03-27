using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Interfaces
{
    public interface IItems
    {
        string Name { get; }
        IPacking Packing { get; }
        float Price { get; }
    }
}
