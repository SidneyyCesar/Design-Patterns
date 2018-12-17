using System.Collections;
using System.Collections.Generic;

namespace FactoryMethod
{
    public class FactoryVolks : IFactoryCar
    {
        private readonly CarsVolks typeCar;

        public FactoryVolks() { }

        public FactoryVolks(CarsVolks typeCar)
        {
            this.typeCar = typeCar;
        }

        public ICarro CreateCar()
        {
            switch (typeCar)
            {
                case CarsVolks.Golf:
                    return new Golf();

                case CarsVolks.Jetta:
                    return new Jetta();

                default:
                    return null;
            }
        }
    }

    public enum CarsVolks
    {
        Golf,
        Jetta
    }
}
