 namespace ConsoleApplication16.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add("A");
        }
        
        public void BuildPartB()
        {
            _product.Add("B");
        }
        
        public void BuildPartC()
        {
            _product.Add("C");
        }

        public Product GetProduct() => _product;
    }
}