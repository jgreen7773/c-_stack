using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numbers = {0,1,2,3,4,5,6,7,8,9};
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] conditions = {true, false, true, false, true, false, true, false, true, false};
            List<string> icecreamflavors = new List<string>();

            icecreamflavors.Add("chocolate");
            icecreamflavors.Add("vanilla");
            icecreamflavors.Add("strawberry");
            icecreamflavors.Add("banana");
            icecreamflavors.Add("cherry");
            icecreamflavors.Add("peanutbutter-blackberry");
            icecreamflavors.Add("coconut-butterscotch");
            for (int i = 0; i < icecreamflavors.Count; i++){
                Console.WriteLine($"{i} = {icecreamflavors[i]}");
            }
            Console.WriteLine(icecreamflavors[2]);
            icecreamflavors.RemoveAt(2);
            for (int i = 0; i < icecreamflavors.Count; i++){
                Console.WriteLine($"{i} = {icecreamflavors[i]}");
            }

            // Create a dictionary that will store both string keys as well as string values
            // Add key/value pairs to this dictionary where:
                // each key is a name from your names array
                // each value is a randomly selected flavor from the icecreamflavors list
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            Dictionary<string,string> favoriteflavors = new Dictionary<string,string>();

            favoriteflavors.Add("Tim", "coconut-butterscotch");
            favoriteflavors.Add("Martin", "strawberry");
            favoriteflavors.Add("Nikki", "peanutbutter-blackberry");
            favoriteflavors.Add("Sara", "cherry");
            foreach (KeyValuePair<string,string> entry in favoriteflavors){
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

            
        }
    }
}
