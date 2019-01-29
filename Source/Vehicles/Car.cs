using System;

namespace Vehicles
{
    class Car
    {
        public int id;
        public int numWheels;

        public Car(int id, int numWheels)
        {
            this.id = id;
            this.numWheels = numWheels;
        }

        public void Beep()
        {
            Console.WriteLine($"Car #{id} has {numWheels} wheels and says 'Beep!'");
        }
    }
}
