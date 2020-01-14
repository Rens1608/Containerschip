using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containerschip
{
    public class Stack
    {
        public List<Container> containers = new List<Container>();
        public int TotalContainersStack()
        {
            return containers.Count;
        }

        public int TotalWeightStack()
        {
            int weight = containers.Sum(c => c.Weight);
            return weight;
        }

        public bool CheckIfContainerCanGoOnTop(Container container)
        {
            if(TotalWeightStack() + container.Weight <= 120000)
            {
                containers.Add(container);
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return string.Join(", ", containers );
        }
    }
}
