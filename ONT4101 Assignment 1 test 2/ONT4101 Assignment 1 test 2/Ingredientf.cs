using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2
{
    abstract class Ingredientf
    {
        
        private List<Kitchenf> _kitchenf = new List<Kitchenf>();
        //Kitchenf Kitchenf;

        protected Ingredientf()
        {
            CreateIngredientf();
        }
        public List<Kitchenf> Kitchenfs => _kitchenf;
        public abstract void CreateIngredientf();


    }
}
