using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2.Fillings
{
    class Beans:Kitchenf
    {
        public override string getFillingSA()
        {
            return ": Refried Beans";
        }

        public override int getPriceSA()
        {
            return 6;
        }

        public override string getFillingUS()
        {
            return ": Black Beans";
        }

        public override int getPriceUS()
        {
            return 5;
        }
    }
}
