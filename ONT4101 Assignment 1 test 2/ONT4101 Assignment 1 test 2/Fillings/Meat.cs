using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2.Fillings
{
    class Meat : Kitchenf
    {
        public override string getFillingSA()
        {
            return ": Mutton";
        }

        public override int getPriceSA()
        {
            return 22;
        }

        public override string getFillingUS()
        {
            return ": Beef";
        }

        public override int getPriceUS()
        {
            return 20;
        }
    }
}
