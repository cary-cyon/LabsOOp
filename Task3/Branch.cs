using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Branch : IComponent
    {
        private List<IComponent> _childrens = new List<IComponent>();
        public string Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IComponent> Children => _childrens;

        public void AddChild(IComponent child)
        {
            _childrens.Add(child);
        }

        public void Print()
        {
            foreach (var child in Children)
            {
                child.Print();
            }
        }
    }
}
