using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        //Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        //add a constructor that takes in all four parameters, Name, Calories, IsSpicy, IsSweet

        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }
    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Ha Gow", 300, false, false);
                new Food("Xiao Long Bao", 500, false, false);
                new Food("Shao Mai", 600, false, false);
                new Food("Red Bean Bao", 200, false, true);
                new Food("Spareribs with Pepper Salt", 800, true, false);
                new Food("Hot Pot", 1000, true, false);
                new Food("Rendang", 900, false, false);
                new Food("Durian", 900, false, true);
                new Food("Sushi", 900, false, false);
                new Food("Matcha", 900, false, true);
            };
            public Food Serve()
            {
                Random rand = new Random();
                int randFood = rand.Next(Menu.Count);
                return Menu[randFood];
            }
        }
    }
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        private bool IsFull;
        public bool IsFull
        {
            get 
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                return false
            }
        }
     
        // build out the Eat method
        public void Eat(Food item)
        {
            if (isFull == false)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"The food eaten was {item.Name}.");
                if (item.IsSpicy){
                    Console.WriteLine$($"{item.Name} is spicy.");
                 }
                if (item.IsSweet){
                    Console.WriteLine$($"{item.Name} is sweet.");
                 }
            }
            else{ Console.WriteLine("This Ninja is full, he/she cannot eat anymore!"); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Buffet spread = new Buffet ();
            Ninja Michelle = new Ninja();

            while (Michelle.isFull != true)
            {
                Michelle.Eat(spread.Serve());
            }
        }
    }
}
