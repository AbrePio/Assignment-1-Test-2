using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2.Fillings
{
    class Tomato : Kitchenf
    {
        public override string getFillingSA()
        {
            return ": Relish";
        }

        public override int getPriceSA()
        {
            return 5;
        }

        public override string getFillingUS()
        {
            return ": Salsa";
        }

        public override int getPriceUS()
        {
            return 5;
        }
    }
}
