namespace FactoryMethod
{
    public class FactoryChevrolet: IFactoryCar
    {
        public ICarro CreateCar()
        {
            return new Camaro();
        }
    }
}
