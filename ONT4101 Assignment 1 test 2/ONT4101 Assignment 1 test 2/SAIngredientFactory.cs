using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2
{
    class SAIngredientFactory:IngredientFactory
    {
        public override Taco CreateTaco()
        {
            return new SATaco();
        }
        public override Burrito CreateBurrito()
        {
            return new SABurrito();
        }
    }
}
