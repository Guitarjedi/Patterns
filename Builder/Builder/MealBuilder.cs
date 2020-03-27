using System;
using System.Collections.Generic;
using System.Text;
using Builder.Models;

namespace Builder
{
    public class MealBuilder
    {
        public Meal PrepareBurgerMeal()
        {
            var meal = new Meal();
            meal.AddItem(new Cola());
            meal.AddItem(new Hamburger());

            return meal;
        }
        public Meal PrepareChickenMeal()
        {
            var meal = new Meal();
            meal.AddItem(new Water());
            meal.AddItem(new ChickenBurger());

            return meal;
        }
    }
}
