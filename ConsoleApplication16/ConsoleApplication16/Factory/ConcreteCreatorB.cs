namespace ConsoleApplication16.Factory
{
    public class ConcreteCreatorB : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}