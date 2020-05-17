using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2.Fillings
{
    class Chili : Kitchenf
    {
        public override string getFillingSA()
        {
            return ": Jalapeno Chillies";
        }

        public override int getPriceSA()
        {
            return 8;
        }

        public override string getFillingUS()
        {
            return ": Habanero Chilies";
        }

        public override int getPriceUS()
        {
            return 8;
        }
    }
}
