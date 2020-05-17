using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2.Fillings
{
    class Rice : Kitchenf
    {
        public override string getFillingSA()
        {
            return ": Jasmin Rice";
        }

        public override int getPriceSA()
        {
            return 4;
        }

        public override string getFillingUS()
        {
            return ": Basmati Rice";
        }

        public override int getPriceUS()
        {
            return 3;
        }
    }
}
