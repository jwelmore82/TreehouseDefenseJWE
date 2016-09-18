using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefenseJWE
{
    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMovable
    {
        void Move();
    }

    interface IInvader : IMappable, IMovable
    {
        int Health { get;}

        bool HasScored { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        

        void DecreaseHeath(int damage);
    }
}
