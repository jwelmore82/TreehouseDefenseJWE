using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefenseJWE
{
    class LongRangeTower : Tower
    {
        protected override int Range { get; } = 2;

        public LongRangeTower(MapLocation location, Path path) : base (location, path)
        {

        }
    }
}
