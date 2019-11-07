using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet restaurant = new Buffet();
            Ninja Jamie = new Ninja();
            Jamie.Eat(restaurant.Serve());
            Jamie.Eat(restaurant.Serve());
            Jamie.Eat(restaurant.Serve());
        }
    }
}