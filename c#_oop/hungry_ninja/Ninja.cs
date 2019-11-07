using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Ninja{
        public List<Food> FoodHistory;
        
        private int calorieIntake;

        public int totalCalories{
            get{ return calorieIntake; }
        }

        public bool IsFull{
            get{
            if(this.totalCalories >= 1200){ return true; }
            else { return false; }
            }
        }

        public Ninja(){
            calorieIntake = 0;
            FoodHistory = new List<Food>(){};
        }

        public void Eat(Food item){
            if (calorieIntake < 1200){
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"You've ordered {item.Name}");
                if (item.IsSpicy == true){ Console.WriteLine("This food is spicy!"); }
                else { Console.WriteLine($"{item.Name} This food is not spicy!"); }
                if (item.IsSweet == true){ Console.WriteLine("This food is sweet!"); }
                else { Console.WriteLine($"{item.Name} This food is not sweet!"); }
                Console.WriteLine("-------------------------------------------------------");
            }
            else {
                // Console.WriteLine("You already ate:");
                for (int i = 0;i < FoodHistory.Count;i++){
                    Console.WriteLine($"You already ate: {FoodHistory[i].Name},");
                }
                Console.WriteLine("You cannot eat any more!");
            }
        }
        // int calories, string Name, bool isspicy, bool issweet
    }
}