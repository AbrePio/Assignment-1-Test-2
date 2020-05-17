using ONT4101_Assignment_1_test_2.Fillings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ONT4101_Assignment_1_test_2.Ingredients
{
    class Tacof:Ingredientf
    {
        
        public override void CreateIngredientf()
        {
            Kitchenfs.Add(new Poultry());
            Kitchenfs.Add(new Meat());
            Kitchenfs.Add(new Vegetation());
            Kitchenfs.Add(new Cheese());
            Kitchenfs.Add(new Guacamole());
            Kitchenfs.Add(new Rice());
            Kitchenfs.Add(new Beans());
            Kitchenfs.Add(new CreamCheese());
            Kitchenfs.Add(new Tomato());
            Kitchenfs.Add(new Chili());
        }
        
            
        }
    }
