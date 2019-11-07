using System;

namespace Fundamentals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoop(256);
            ForLoopSelect(101);
        }

        public static int ForLoop(int y){
            int result = 0;
            for (int x = 0;x < y;x++){
                result = x;
                Console.WriteLine(result);
            }
            return result;
        }

        public static int ForLoopSelect(int z){
            string three = "Fizz";
            int result = 0;
            string five = "Buzz";
            string both = "FizzBuzz";
            for (int j = 0; j < z; j++){
                Console.WriteLine(j);
                if (j%3==0){
                    result = j;
                    Console.WriteLine(three);
                    if (j%5==0){
                        Console.WriteLine(five);
                    }
                }
                if (j%3==0 || j%5==0){
                    Console.WriteLine(both);
                }
            }
            return result;
        }
    }
}
