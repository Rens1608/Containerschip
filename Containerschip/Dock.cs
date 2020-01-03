using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containerschip
{
    public class Dock
    {
        public List<Container> containers = new List<Container>();

        public string PlaceContainersOnShip(int width, int length)
        {
            Ship ship = new Ship(width, length);
            ship.CreateDeck();
            while (containers.Any())
            {
                ship.TryToPlaceCooledContainersInRow(containers);
                ship.TryToPlaceNormalContainersInRow(containers);
                ship.TryToPlaceValuableContainersInRow(containers);
            }
            return ship.ToString();
        }
    }
}
