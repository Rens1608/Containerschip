using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containerschip
{
    public enum Cargo { Cooled, Normal, Empty, Valuable}
    public class Container
    {
        public Cargo Cargo { get; set; }
        public int Weight { get; set; }

        public Container(Cargo cargo, int weight)
        {
            Cargo = cargo;
            Weight = weight;
        }

        public override string ToString()
        {
            return Cargo.ToString() + " - " + Weight.ToString();
        }
    }
}
