using System;

namespace fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 100; i++){
                if (i % 3 == 0){
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                if (i % 15 == 0){
                    Console.WriteLine("FizzBuzz");
                }
            }
            int j = 1;
            while (j <= 100){
                if (j % 3 == 0){
                    Console.WriteLine("Fizz");
                }
                if (j % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                if (j % 15 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                j = j + 1;
            }
        }
    }
}
