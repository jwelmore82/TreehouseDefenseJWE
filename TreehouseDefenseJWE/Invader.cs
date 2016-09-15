using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefenseJWE
{
    class Invader
    {
        private readonly Path _path;

        private int _pathStep = 0;

        protected virtual int StepSize { get; } = 1;

        public virtual int Health { get; protected set; } = 2;

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public Invader (Path path)
        {
            _path = path;
            
        }

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHeath(int damage)
        {
            Console.WriteLine("Shot at and hit invader!");
            Health -= damage;
        }
    }
}
