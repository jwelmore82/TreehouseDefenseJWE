using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefenseJWE
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;

        private readonly MapLocation _location;

        public Tower(MapLocation location, Path path)
        {
            if (path.ContainsLocation(location))
            {
                throw new OutOfBoundsException(location.X + ", " + location.Y + " is on the path!")
            }
            else
            {
                _location = location;
            }
        }

        public void FireOnInvaders(Invader[] invaders)
        {
          
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.DecreaseHeath(_power);
                    break;
                }
            }

        }
    }
}
