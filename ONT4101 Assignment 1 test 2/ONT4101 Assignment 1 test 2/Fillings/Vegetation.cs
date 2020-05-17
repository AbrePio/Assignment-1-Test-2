using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2.Fillings
{
    class Vegetation : Kitchenf
    {
        public override string getFillingSA()
        {
            return ": Samp";
        }

        public override int getPriceSA()
        {
            return 10;
        }

        public override string getFillingUS()
        {
            return ": Chickpeas";
        }

        public override int getPriceUS()
        {
            return 10;
        }
    }
}
