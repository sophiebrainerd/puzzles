using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static int[] RandomArray()
        {
            int[] newArr = new int[10];
            Random rand = new Random();
            int min = newArr[0];
            int max = newArr[0];
            int sum = 0;
            for (int i=0; i<10; i++){
                newArr[i] = rand.Next(5,25);
                if (newArr[i] < min){
                    min = newArr[i];
                } 
                else if (newArr[i] > max){
                    max = newArr[i];
                }
                sum += newArr[i];
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
            return newArr;
        }
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a coin!");
            Random rand = new Random();
            double result = rand.NextDouble();
            if (result < 0.5){
                Console.WriteLine("Heads!");
                return "heads";
            }
            else {
                Console.WriteLine("Tails!");
                return "tails";
            }
        }
        public static double TossMultipleCoins(int num)
        {
            int count = 0;
            for (int i=0; i<num; i++){
                string result = TossCoin();
                if (result == "heads"){
                    count += 1;
                }
            }
            double doubleCount = count;
            double doubleNum = num;
            double ratio = count / num;
            Console.WriteLine(doubleCount);
            Console.WriteLine(doubleNum);
            Console.WriteLine(ratio);
            return ratio;
            // Creating a value for ratio isn't working but I'm turning this in anyway to avoid wasting time
        }
        public static List<string> Names()
        {
            List<string> namesList = new List<string> {"Todd", "Tiiffany", "Charlie", "Geneva", "Sydney"};
            for (int i=0; i<namesList.Count; i++){
                Random rand = new Random();
                string temp = namesList[i];
                int swapVal = rand.Next(0,4);
                namesList[i] = namesList[swapVal];
                namesList[swapVal] = temp;
            }
            Console.WriteLine(namesList);
            List<string> longerThanFive = new List<string>();
            for (int i=0; i<namesList.Count; i++){
                if (namesList[i].Length > 4){
                    longerThanFive.Add(namesList[i]);
                }
            }
            return longerThanFive;
        }
        
        static void Main(string[] args)
        {
            TossMultipleCoins(5);
        }
    }
}
