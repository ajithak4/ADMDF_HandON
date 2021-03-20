using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcreteFactory : Factory
    {
        private Order order;
        public void makeOrder(Channel channel, Product product)
        {
            if (product == Product.Electronic_Products)
            {
                order = new ElectronicOrder(channel);
            }
            else if (product == Product.Furniture)
            {
                order = new FurnitureOrder(channel);
            }
            else
            {
                order = new ToysOrder(channel);
            }
        }
    }
}
