using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefenseJWE
{
    class Game
    {
        static void Main()
        {
            Map map = new Map();
            map.Width = 8;
            map.Height = 5;

            int area = map.Width * map.Height;
        }
    }
}
