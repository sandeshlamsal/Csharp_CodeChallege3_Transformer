using System;

namespace Csharp_CodeChallege3_Transformer
{
    enum State
    {
        Air=1,
        Road=2,
        Water=3
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Vechicles transforms to jet,car,boat
             * if jet, it will go on air, with wheels=8, speed=900
             * if car, it will go on air, with wheels=4, speed=350
             * if boat, it will go on air, with wheels=0, speed=200
             * 
             *Use Enum to store landscape: air, road, water
             * User Ploymorphism concept
             */

            #region Initializing Objects
            Vehicle v = new Vehicle();

            Jet jet = new Jet()
            {
                Wheels = 8,
                speed = 900
            };

            Car car = new Car()
            {
                Wheels = 4,
                speed = 300
            };

            Boat boat = new Boat()
            {
                Wheels = 0,
                speed = 100
            };
            #endregion

            Console.WriteLine("Enter State of Vehicle");
            Console.WriteLine("1 - Air");
            Console.WriteLine("2 - Road");
            Console.WriteLine("3 - Water");

            // Parsing integer to State Enum
            State s = (State)int.Parse(Console.ReadLine());

            // Checking enum values to assign right object
            switch (s)
            {
                case State.Air:
                    v = jet;
                    break;
                case State.Road:
                    v = car;
                    break;
                case State.Water:
                    v = boat;
                    break;
                default:
                    Console.WriteLine("Wrong Option");
                    break;
            }

            // Call Run Method
            v.Run();

            Console.ReadLine();


        }
    }
}
