using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2.Fillings
{
    class Poultry :Kitchenf
    {

        string filling = "Chicken";
        int price = 15;
        public override string getFillingSA()
        {
            return ": Chicken";
        }

        public override int getPriceSA()
        {
            return 15;
        }

        public override string getFillingUS()
        {
            return ": Turkey";
        }

        public override int getPriceUS()
        {
            return 15;
        }
    }
}
