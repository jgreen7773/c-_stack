using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Buffet{
        public List<Food> Menu;

        public Buffet(){

            Menu = new List<Food>(){
                new Food("Cheese Stacked Salad", 333, false, false),
                new Food("Peaches and Cream", 777, false, true),
                new Food("Kielbasa Sausage w/ Biscuit Blanket", 555, true, false),
                new Food("Roast Beef Hogie w/ Auh Zu dip", 1211, false, false),
                new Food("Green Chicken Curry w/ Rice", 888, true, false),
                new Food("Gyoza w/ Soy Sauce and Mustard dip", 444, false, false),
                new Food("Turkey Veggie Panini w/ Egg Sauce", 777, false, true),
            };
        }

        public Food Serve(){
            int min = 0;
            int max = Menu.Count-1;
            Random randNum = new Random();
            int randomSelector = randNum.Next(min, max);
            return Menu[randomSelector];
            }
    }
}
