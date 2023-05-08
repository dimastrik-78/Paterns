using System.Collections.Generic;

namespace ConsoleApplication16.Builder
{
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }
    }
}