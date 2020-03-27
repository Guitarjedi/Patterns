using System;
using Builder.Models;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new MealBuilder();
            var burgerMeal = builder.PrepareBurgerMeal();
            Console.WriteLine("BurgerMeal : ");
            burgerMeal.ShowItems();
            Console.WriteLine(burgerMeal.GetCost());

            Console.WriteLine();
            var chickenMeal = builder.PrepareChickenMeal();
            Console.WriteLine("ChickenMeal : ");
            chickenMeal.ShowItems();
            Console.WriteLine(chickenMeal.GetCost());


            Console.ReadLine();
        }
    }
}
