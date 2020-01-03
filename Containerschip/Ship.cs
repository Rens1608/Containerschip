using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containerschip
{
    public class Ship
    {
        public List<Row> rows = new List<Row>();
        public int Width { get; set; }
        public int Length { get; set; }

        public Ship(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public Ship()
        {
        }

        public void CreateDeck()
        {
            for (int i = 0; i < Length; i++)
            {
                Row row = new Row();
                row.createStacks(Width);
                rows.Add(row);
            }
        }

        public void TryToPlaceCooledContainersInRow(List<Container> containers)
        {
            foreach (Container container in containers.Where(c => c.Cargo == Cargo.Cooled).Reverse())
            {
                rows.Last().TryToPlaceContainer(container);
                containers.Remove(container);
            }
        }

        public void TryToPlaceNormalContainersInRow(List<Container> containers)
        {
            foreach (Container container in containers.Where(c => c.Cargo == Cargo.Normal).Reverse())
            {
                if (GetRowWithLeastContainers().TryToPlaceContainer(container))
                {
                    containers.Remove(container);
                }
            }
        } 

        public void TryToPlaceValuableContainersInRow(List<Container> containers)
        {
            foreach (Container container in containers.Where(c => c.Cargo == Cargo.Valuable).Reverse())
            {
                if (GetRowWithLeastContainers().TryToPlaceContainer(container,PickSideWithLeastWeight()))
                {
                    containers.Remove(container);
                }
            }
        }

        private Row GetRowWithLeastContainers()
        {
            return rows.OrderBy(r => r.TotalContainers()).First();
        }

        public string PickSideWithLeastWeight()
        {
            if (rows.Sum(r => r.WeightRightSide()) > rows.Sum(r => r.WeigthLeftSide()))
            {
                return "Left";
            }
            else
            {
                return "Right";
            }
        }
        public override string ToString()
        {
            return string.Join("" , rows);
        }
    }
}
