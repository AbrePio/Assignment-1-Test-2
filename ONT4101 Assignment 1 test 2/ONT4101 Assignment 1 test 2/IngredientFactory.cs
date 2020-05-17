using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2
{
    abstract class IngredientFactory
    {
        public abstract Taco CreateTaco();
        public abstract Burrito CreateBurrito();
    }
}
