using System.Dynamic;

namespace FizzBuzz_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int idx = 1; idx <= 30; idx++)
            {
                if ((idx % 3 == 0) && (idx % 5 == 0))
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if (idx % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (idx % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(idx);
                }
            }

            //Refactoring attempt using ternary
            Console.WriteLine("*********Refactoring attempt using ternary statements***********");
            
            for(int idx3 = 1; idx3 <= 30;idx3++)
            {
                bool isDivBy3 = (idx3 % 3 == 0) ? true : false;

                bool isDivBy5 = (idx3 % 5 == 0) ? true : false;

                bool isDivBy3n5 = (isDivBy3 && isDivBy5) ? true : false;

                if (isDivBy3n5)
                {
                    Console.WriteLine("FIZZBUZZ");
                    continue;
                }
                if (isDivBy3)
                {
                    Console.WriteLine("FIZZ");
                    continue;
                }
                if (isDivBy5)
                {
                    Console.WriteLine("BUZZ");
                    continue;
                }
                Console.WriteLine(idx3);
            }

            /*
            for (int idx2 = 1; idx2 <=30; idx2++)
            {
                if(idx2 % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else
                {
                    Console.WriteLine(idx2);
                }
                if (idx2 % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(idx2);
                }
            }
            */
        }
    }
}