using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2.Fillings
{
    class Guacamole : Kitchenf
    {
        public override string getFillingSA()
        {
            return ": Sliced Avocados";
        }

        public override int getPriceSA()
        {
            return 15;
        }

        public override string getFillingUS()
        {
            return ": Guacamole";
        }

        public override int getPriceUS()
        {
            return 10;
        }
    }
}
