using System;

namespace ProblemSolver
{
    public class Runner
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Problem Solver Application!\n" +
                                   "Please select the option:\n" +
                                   "1.Sum Of Multiple\n" +
                                   "2.Sequence Analysis");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        {
                            Console.WriteLine("Please input a number for the limit:");
                            var input = Console.ReadLine();
                            int number;
                            Int32.TryParse(input, out number);

                            Console.WriteLine("Your value is:");
                            Console.WriteLine(SumOfNumbers.GetSumOfNumbers(number));
                            Console.ReadLine();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Please input a string:");
                            var input = Console.ReadLine();

                            Console.WriteLine("Your sorted upper-case symbols are the following:");
                            Console.WriteLine(SequenceAnalysis.Analyse(input));
                            Console.ReadLine();
                            break;
                        }
                }
            }
        }
    }
}
