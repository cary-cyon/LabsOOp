using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal interface IComponent
    {
        string Value { get; set; }
        void AddChild(IComponent child);
        List<IComponent> Children { get; }
        void Print();
    }
}
