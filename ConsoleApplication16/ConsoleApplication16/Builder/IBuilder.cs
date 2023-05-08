namespace ConsoleApplication16.Builder
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
        Product GetProduct();
    }
}