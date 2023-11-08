using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Leaf : IComponent
    {
        public Leaf(string val)
        {
            Value = val;
        }
        public string Value { get; set; } = "";

        public List<IComponent> Children 
        { 
            get
            {
                throw new NotImplementedException();
            } 
        }

        public void AddChild(IComponent child)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.Write(Value);
        }
    }
}
