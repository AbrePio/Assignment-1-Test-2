using System;
using ONT4101_Assignment_1_test_2.Ingredients;

namespace ONT4101_Assignment_1_test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Taco taco;
            Burrito burrito;



            Console.Write("In what country are you? SA/US: ");
            string response = Console.ReadLine();
            Console.Write("What ingredient do you want to create? Taco/Burrito: ");
            string ingChosen = Console.ReadLine();
            Console.WriteLine();

            Ingredientf[] ingredientfs = new Ingredientf[2];
            if (response == "SA" || response == "sa")
            {
                //SA
                IngredientFactory SA = new SAIngredientFactory();
                if (ingChosen == "taco" || ingChosen == "Taco")
                {
                    taco = SA.CreateTaco();
                    taco.Display();
                    Console.WriteLine();
                    ingredientfs[0] = new Tacof();


                    Console.WriteLine(ingredientfs[0].GetType().Name + ": ");
                    foreach (Kitchenf kitchenf in ingredientfs[0].Kitchenfs)
                    {
                        Console.Write(kitchenf.GetType().Name + "");
                        Console.Write(kitchenf.getFillingSA() + " R");
                        Console.WriteLine(kitchenf.getPriceSA());
                    }
                    Console.WriteLine();


                }
                else if (ingChosen == "burrito" || ingChosen == "Burrito")
                {
                    burrito = SA.CreateBurrito();
                    burrito.Display();
                    Console.WriteLine();
                    ingredientfs[1] = new Burritof();

                    Console.WriteLine(ingredientfs[1].GetType().Name + ": ");
                    foreach (Kitchenf kitchenf in ingredientfs[1].Kitchenfs)
                    {
                        Console.Write(kitchenf.GetType().Name + " ");
                        Console.Write(kitchenf.getFillingSA() + " R");
                        Console.WriteLine(kitchenf.getPriceSA());
                    }
                    Console.WriteLine();

                }
                //taco = SA.CreateTaco();
                //taco.Display();
                //burrito = SA.CreateBurrito();
                //burrito.Display();
            }
            else if (response == "US" || response == "us")
            {

                //US
                IngredientFactory US = new USIngredientFactory();

                if (ingChosen == "taco" || ingChosen == "Taco")
                {
                    taco = US.CreateTaco();
                    taco.Display();
                    Console.WriteLine();
                    ingredientfs[0] = new Tacof();


                    Console.WriteLine(ingredientfs[0].GetType().Name + ": ");
                    foreach (Kitchenf kitchenf in ingredientfs[0].Kitchenfs)
                    {
                        Console.Write(kitchenf.GetType().Name + " ");
                        Console.Write(kitchenf.getFillingUS() + " R");
                        Console.WriteLine(kitchenf.getPriceUS());
                    }
                    Console.WriteLine();


                }
                else if (ingChosen == "burrito" || ingChosen == "Burrito")
                {
                    burrito = US.CreateBurrito();
                    burrito.Display();
                    Console.WriteLine();
                    ingredientfs[1] = new Burritof();

                    Console.WriteLine(ingredientfs[1].GetType().Name + ": ");
                    foreach (Kitchenf kitchenf in ingredientfs[1].Kitchenfs)
                    {
                        Console.Write(kitchenf.GetType().Name + " ");
                        Console.Write(kitchenf.getFillingUS() + " R");
                        Console.WriteLine(kitchenf.getPriceUS());
                    }
                    Console.WriteLine();

                }

                //taco = US.CreateTaco();
                //taco.Display();


                //burrito = US.CreateBurrito();
                //burrito.Display();
            }
            Console.WriteLine();


            //Ingredientf[] ingredientfs = new Ingredientf[2];

            /////////////////////
            //if (ingChosen == "taco")
            //{
            //    ingredientfs[0] = new Tacof();


            //    Console.WriteLine(ingredientfs[0].GetType().Name + ": ");
            //    foreach (Kitchenf kitchenf in ingredientfs[0].Kitchenfs)
            //    {
            //        Console.WriteLine(kitchenf.GetType().Name + " ");
            //    }
            //    Console.WriteLine();


            //}
            //else if (ingChosen == "burrito")
            //{
            //    ingredientfs[1] = new Burritof();

            //    Console.WriteLine(ingredientfs[1].GetType().Name + ": ");
            //    foreach (Kitchenf kitchenf in ingredientfs[1].Kitchenfs)
            //    {
            //        Console.WriteLine(kitchenf.GetType().Name + " ");
            //    }
            //    Console.WriteLine();
            
            //}
            ////////////////////////

            //ingredientfs[0] = new Tacof();
            //ingredientfs[1] = new Burritof();

            //foreach (Ingredientf ingredientf in ingredientfs)
            //{
            //    Console.WriteLine(ingredientf.GetType().Name + ": ");
            //    foreach(Kitchenf kitchenf in ingredientf.Kitchenfs)
            //    {
            //        Console.WriteLine(kitchenf.GetType().Name + " ");
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadLine();
        }
    }
}
