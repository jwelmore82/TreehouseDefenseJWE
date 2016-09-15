using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefenseJWE
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;
        

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }

        public Tower(MapLocation location, Path path)
        {
            if (path.ContainsLocation(location))
            {
                throw new OutOfBoundsException(location.X + ", " + location.Y + " is on the path!");
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
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHeath(Power);
                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Missed a shot.");
                    }
                    
                    break;
                }
            }

        }
    }
}
