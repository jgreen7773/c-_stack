using System;
using System.Collections.Generic;

namespace Basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(256);
            PrintOdds(256);
            PrintSum(256);
            LoopArray(new int[] {1,3,4,7,8,21,22,35,44,77,85});
            FindMax(new int[] {-33,-25,-12,-5,-3,0,1,3,4,7,8,21,22,35,44,77,85});
            Average(new int[] {2,10,3});
            OddArray();
            GreaterThanY(new int[] {-33,-25,-12,-5,-3,0,1,3,4,7,8,21,22,35,44,77,85}, 33);
            SquareArrayValues(new int[] {2,10,3,8,12,5,7});
            EliminateNegatives(new int[] {-33,-25,-12,-5,-3,0,1,3,4,7,8,21,22,35,44,77,85});
            MinMaxAverage(new int[] {-33,-25,-12,-5,-3,0,1,3,4,7,8,21,22,35,44,77,85});
            ShiftValues(new int[] {-33,-25,-12,-5,-3,0,1,3,4,7,8,21,22,35,44,77,85});
            NumToString(new int[] {-33,-25,-12,-5,-3,0,1,3,4,7,8,21,22,35,44,77,85});
            Sigma(5);
        }

        public static void PrintNumbers(int y){
            Console.WriteLine("Print Numbers Start ----------------");
            for (int i = 1;i < y;i++){
                Console.WriteLine(i);
            }
            Console.WriteLine("Print Numbers End ------------------");
        }

        public static void PrintOdds(int y){
            Console.WriteLine("Print Odds Start -------------------");
            for (int i = 1;i < y;i++){
                if (i%2==1){
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Print Odds End ---------------------");
        }

        public static void PrintSum(int y){
            Console.WriteLine("Print Sum Start --------------------");
            int sum = 0;
            for (int i = 1;i < y;i++){
                sum = sum + i;
                Console.WriteLine($"New number: {i}, Sum: {sum}");
            }
            Console.WriteLine("Print Sum Start --------------------");
        }

        public static void LoopArray(int[] numbers){
            Console.WriteLine("LoopArray Start --------------------");
            for (int i = 0;i < numbers.Length;i++){
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("LoopArray End ----------------------");
        }

        public static int FindMax(int[] numbers){
            Console.WriteLine("FindMax Start ----------------------");
            int max = 0;
            for (int i = 0;i < numbers.Length;i++){
                if (numbers[i] > max){
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine("FindMax End ------------------------");
            return max;
        }

// i
        public static int Average(int[] arr){
            Console.WriteLine("Average Start ----------------------");
            int sum = 0;
            for (int i = 0;i < arr.Length; i++){
                sum = sum + i;
            }
            int avg = sum/arr.Length;
            Console.WriteLine(avg);
            Console.WriteLine("Average End ------------------------");
            return avg;
        }

        public static int[] OddArray(){
            Console.WriteLine("OddArray Start ---------------------");
            int[] oddarr = new int[256];
            for(int i = 0;i < 256;i++){
                if (i%2==1){
                    Console.WriteLine(i);
                    oddarr[i] = i;
                }
            }
            Console.WriteLine("OddArray End ------------------------");
            return oddarr;
        }

        public static int GreaterThanY(int[] numbers, int y){
            int counter = 0;
            Console.WriteLine("GreaterThanY Start ------------------");
            for(int i = 0;i < numbers.Length;i++){
                if (numbers[i] > y){
                    counter += 1;
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine("GreaterThanY End --------------------");
            return counter;
        }

// i
        public static void SquareArrayValues(int[] numbers){
            int mult = 0;
            Console.WriteLine("SquareArrayValues Start -------------");
            for (int i = 0;i < numbers.Length;i++){
                // mult = i;
                mult = (numbers[i])*(numbers[i]);
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
            Console.WriteLine("SquareArrayValues End ---------------");
        }

// i
        public static void EliminateNegatives(int[] numbers){
            Console.WriteLine("EliminateNegatives Start ------------");
            for (int i = 0;i < numbers.Length;i++){
                if (i < 0){
                    numbers[i] = 0;
                }
            }
            // foreach (var item in numbers){
            //     Console.WriteLine(item.ToString());
            // }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
            Console.WriteLine("EliminateNegatives End --------------");

        }
// i?
        public static void MinMaxAverage(int[] numbers){
            int max = 0;
            int min = 0;
            int avg = 0;
            int sum = 0;
            Console.WriteLine("MinMaxAverage Start -----------------");
            for (int i = 0;i < numbers.Length;i++){
                sum = sum + i;
                avg = sum/numbers.Length;
                if (numbers[i] > max){
                    max = numbers[i];
                }
                if (numbers[i] < min){
                    min = numbers[i];
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(avg);
            Console.WriteLine("MinMaxAverage End -------------------");
        }

public static void ShiftValues(int[] numbers){
            Console.WriteLine("ShiftValues Start -------------------");
            for (int i = 0;i < numbers.Length;i++){
                // int zero = 0;
                if (numbers[i] == numbers[0]){
                    // numbers[i] = zero;
                }
                else{
                    numbers[i-1] = numbers[i];
                    // numbers[numbers.Length-1] = 0;
                }
                if (numbers[i] == numbers[numbers.Length-1]){
                    numbers[numbers.Length-1] = 0;
                    break;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
            Console.WriteLine("ShiftValues End ---------------------");
        }

public static object[] NumToString(int[] numbers){
            Console.WriteLine("NumToString Start -------------------");
            // int convertnum = 0;
            object[] ObjectArray = new object[numbers.Length];
            numbers.CopyTo(ObjectArray, 0);
            for (int i = 0;i < numbers.Length;i++){
                if (numbers[i] < 0){
                    ObjectArray[i] = "Dojo";
                }
                else{}
            }
            Console.WriteLine("[{0}]", string.Join(", ", ObjectArray));
            Console.WriteLine("NumToString End ---------------------");
            return ObjectArray;
}

        public static int Sigma(int limit){
            Console.WriteLine("Sigma Start -------------------------");
            int answer = 0;
            for (int i = 0; i < limit+1; i++){
                answer = answer + i;
            }
            // int answer = limit*(limit+1)/2;
            Console.WriteLine(answer);
            Console.WriteLine("Sigma End ---------------------------");
            return answer;
        }
    }
}
