using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_CodeChallege3_Transformer
{
    public class Jet : Vehicle
    {
        private const int maxSpeed = 900;
        private const int totalWheels = 8;

        public override int speed
        {
            get
            {
                return _speed;
            }

            set
            {
                if (value <= maxSpeed)
                {
                    _speed = value;
                }
                else
                {
                    Console.WriteLine("Jet's maximum speed is : {0}", maxSpeed);
                }
            }

        }

        public override int Wheels
        {
            get
            {
                return _wheels;
            }

            set
            {
                if (value <= totalWheels)
                {
                    _wheels = value;
                }
                else
                {
                    Console.WriteLine("Jet's Total Wheels are : {0}", totalWheels);
                }
            }
        }

        public override void Run()
        {
            Console.WriteLine("Jet is Flying with {0} Wheels and with Speed of {1}", base._wheels, base._speed);
        }


    }
}
