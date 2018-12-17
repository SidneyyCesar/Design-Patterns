using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IFactoryCar factory;
                ICarro car;

                //show de unique car of a chevrolet
                factory = new FactoryChevrolet();
                car = factory.CreateCar();
                car.ShowDetails();

                //define a car in volks constructor
                factory = new FactoryVolks(CarsVolks.Jetta);
                car = factory.CreateCar();
                car.ShowDetails();

                factory = new FactoryVolks(CarsVolks.Golf);
                car = factory.CreateCar();
                car.ShowDetails();

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
