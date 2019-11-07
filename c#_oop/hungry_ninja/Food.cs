using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Food{
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int calories, bool isspicy, bool issweet){
            Name = name;
            Calories = calories;
            IsSpicy = isspicy;
            IsSweet = issweet;
        }
    }
}