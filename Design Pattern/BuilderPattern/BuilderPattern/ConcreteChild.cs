using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
	public class ConcreteChild :Builder
	{
        Product p = new Product();
        public void BuildSavories()
        {
            p.Add("1 Savory");
        }

        public void BuildSweet()
        {
            p.Add("2 Sweets");
        }

        public Product GetResults()
        {
            return p;
        }
    }
}
