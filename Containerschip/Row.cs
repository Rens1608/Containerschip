using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containerschip
{
    public class Row
    {
        public List<Stack> stacks = new List<Stack>();

        public int TotalContainers()
        {
            return stacks.Sum(s => s.TotalContainersStack());
        }

        public bool TryToPlaceContainer(Container container, string side = "")
        {
            if (PickLowestStackInRow(side).CheckIfContainerCanGoOnTop(container) == true)
            {
                PickLowestStackInRow(side).containers.Add(container);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Stack PickLowestStackInRow(string side)
        {
            if (side == "Right")
            {
                return RightSide().OrderBy(s => s.containers.Count).First();
            }
            if (side == "Left")
            {
                return LeftSide().OrderBy(s => s.containers.Count).First();
            }
            else
            {
                return stacks.OrderBy(s => s.containers.Count).First();
            }
        }

        private List<Stack> LeftSide()
        {
            List<Stack> leftStacks = stacks.Take(stacks.Count / 2).ToList();
            return leftStacks;
        }

        private List<Stack> RightSide()
        {
            if (stacks.Capacity % 2 == 0)
            {
                List<Stack> rightStacks = stacks.Skip(stacks.Capacity / 2).Take(stacks.Capacity / 2).ToList();
                return rightStacks;
            }
            else
            {
                List<Stack> rightStacks = stacks.Skip(stacks.Capacity / 2 + 1).Take(stacks.Capacity / 2).ToList();
                return rightStacks;
            }
        }

        public int WeigthLeftSide()
        {
            int weight = LeftSide().Sum(s => s.TotalWeightStack());
            return weight;
        }

        public int WeightRightSide()
        {
            int weight = RightSide().Sum(s => s.TotalWeightStack());
            return weight;
        }

        public void createStacks(int width)
        {
            for (int i = 0; i < width; i++)
            {
                Stack stack = new Stack();
                stacks.Add(stack);
            }
        }

        public override string ToString()
        {
            return "Row:" + string.Join(" | ", stacks) + Environment.NewLine;
        }
    }
}
