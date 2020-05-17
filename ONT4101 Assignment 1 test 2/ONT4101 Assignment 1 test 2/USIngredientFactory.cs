using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2
{
    class USIngredientFactory:IngredientFactory
    {
        public override Taco CreateTaco()
        {
            return new USTaco();
        }
        public override Burrito CreateBurrito()
        {
            return new USBurrito();
        }
    }
}
