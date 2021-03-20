using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public interface Builder
    {
        void BuildSweet();
        void BuildSavories();

        Product GetResults();

    }
}
