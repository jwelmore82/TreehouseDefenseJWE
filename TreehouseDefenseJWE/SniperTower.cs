using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefenseJWE
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = .93;
        protected override int Range { get; } = 3;

        public SniperTower(MapLocation location, Path path) : base(location, path)
        {

        }
    }
}
