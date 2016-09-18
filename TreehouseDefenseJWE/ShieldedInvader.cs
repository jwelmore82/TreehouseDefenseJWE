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

        public override int Health { get; protected set; } = 3;

        public ShieldedInvader(Path path) : base(path)
        {

        }

        public override void DecreaseHeath(int damage)
        {
            if (Random.NextDouble() < .5)
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
