using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefenseJWE
{
    class ShieldedInvader : Invader
    {
        private static Random _random = new Random();

        public ShieldedInvader(Path path) : base(path)
        {

        }

        public override void DecreaseHeath(int damage)
        {
            if (_random.NextDouble() < .5)
            {
                base.DecreaseHeath(damage);
            }
            else
            {
                Console.WriteLine("Shot at and hit a shielded invader, but it sustained no damage.");
            }
        }
    }
}
