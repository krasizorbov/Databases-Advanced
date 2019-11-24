﻿namespace PrototypePattern
{
    using System;
    public class Sandwich : SandwichPrototype
    {
        private string meat;
        private string cheese;
        private string bread;
        private string veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            string ingredientList = GetIngredientsList();
            Console.WriteLine($"Cloning sandwich with ingredients: {ingredientList}");
            return this.MemberwiseClone() as SandwichPrototype;
        }
        private string GetIngredientsList()
        {
            return $"{this.bread}, {this.meat}, {this.cheese}, {this.veggies}";
        }
    }
}
