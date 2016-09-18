using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefenseJWE
{
    class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        public bool ContainsLocation(MapLocation location)
        {

            foreach (MapLocation pathStep in _path)
            {
                if (location.Equals(pathStep))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
