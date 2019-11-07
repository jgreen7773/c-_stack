using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(3);
            Names();
        }

        public static int[] RandomArray(){
            int min = 5;
            int max = 25;
            int sum = 0;
            int[] array = new int[10];
            Random randNum = new Random();
            for (int i = 0;i < array.Length;i++){
                array[i] = randNum.Next(min, max);
                sum = sum + i;
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
            Console.WriteLine(array);
            return array;
        }

        public static string TossCoin(){
            Console.WriteLine("Tossing Coin!");
            int min = 0;
            int max = 15;
            string result = null;
            Random randNum = new Random();
            if (randNum.Next(min, max) > 8){
                result = "Heads!";
                Console.WriteLine(result);
                return result;
            }
            else{
                result = "Tails!";
                Console.WriteLine(result);
                return result;
            }
        }

        public static string TossMultipleCoins(int y){
            Console.WriteLine($"Tossing {y} Coins!");
            for (int i = 0;i < y;i++){
                TossCoin();
            }
            return TossCoin();
        }

        public static List<string> Names(){
            // int min = 0;
            // int max = 5;
            Random randNum = new Random();
            // string[] randNames = new string[5];
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            int i = names.Count;
            while (i > 0){
                i--;
                if (i <= 4){
                int shuffleIndex = randNum.Next(i + 1);
                names[i] = names[shuffleIndex];
                if (names[i].Length > 5){
                    System.Console.WriteLine(names[i]);
                }
                }
            }
            return names;
        }
    }
}
