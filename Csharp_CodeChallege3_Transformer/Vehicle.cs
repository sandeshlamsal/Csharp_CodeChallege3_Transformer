using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_CodeChallege3_Transformer
{
    public class Vehicle
    {
        protected int _speed;
        public virtual int speed { get; set; }
        protected int _wheels;
        public virtual int Wheels { get; set; }

        public virtual void Run()
        {
            Console.WriteLine("Vechicle is running with {0} wheels and spedd of {1) ", _wheels,_speed);
        }
    }
}
