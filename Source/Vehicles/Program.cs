using System;
using System.Collections.Generic;

namespace Vehicles
{
    class Program
    {
        static List<Car> cars;

        static void Main(string[] args)
        {
            CreateCars();
            BeepHorns();
        }

        private static void CreateCars()
        {
            cars = new List<Car>();

            for (int carId = 0; carId < 10; carId++)
            {
                cars.Add(new Car(carId, 4));
            }
        }

        private static void BeepHorns()
        {
            foreach (Car car in cars)
            {
                car.Beep();
            }
        }
    }
}
