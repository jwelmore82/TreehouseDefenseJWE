using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefenseJWE
{
    class SharpshooterTower : Tower
    {
        protected override double Accuracy { get; } = .9;

        public SharpshooterTower(MapLocation location, Path path) : base(location, path)
        {

        }
    }
}
