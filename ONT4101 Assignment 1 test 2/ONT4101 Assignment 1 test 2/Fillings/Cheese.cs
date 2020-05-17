using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2.Fillings
{
    class Cheese : Kitchenf
    {
        public override string getFillingSA()
        {
            return ": Cheddar Cheese";
        }

        public override int getPriceSA()
        {
            return 6;
        }

        public override string getFillingUS()
        {
            return ": Pepper Jack Cheese";
        }

        public override int getPriceUS()
        {
            return 5;
        } 
    }
}
