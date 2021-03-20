using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface Factory
    {
        void makeOrder(Channel channel, Product product);
    }
}
