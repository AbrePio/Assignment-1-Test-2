using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2.Fillings
{
    class CreamCheese : Kitchenf
    {
        public override string getFillingSA()
        {
            return ": Smooth Cream Cheese";
        }

        public override int getPriceSA()
        {
            return 14;
        }


        public override string getFillingUS()
        {
            return ": Chunky Cream Cheese";
        }

        public override int getPriceUS()
        {
            return 12;
        }
    }
}
