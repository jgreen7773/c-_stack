using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<object> boxing = new List<object>();

            boxing.Add(7);
            boxing.Add(28);
            boxing.Add(-1);
            boxing.Add(true);
            boxing.Add("chair");

            for (int i = 0; i < boxing.Count; i++){
                Console.WriteLine($"{i} = {boxing[i]}");
            }

            foreach (object x in boxing){
                if (x is int){
                    sum = sum + Convert.ToInt32(x);
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
