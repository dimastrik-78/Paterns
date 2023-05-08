namespace ConsoleApplication16.Factory
{
    public class ConcreteCreatorA : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}