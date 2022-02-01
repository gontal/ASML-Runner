using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public static class SumOfNumbers
    {
        private static int firstNumber = 3;
        private static int secondNumber = 5;

        private static long GetNumberOfElements(long limit, long multipleValue)
        {
            return (limit - 1) / multipleValue;
        }
        private static long GetSumOfRange(long limit, long multipleValue)
        {
            var range = GetNumberOfElements(limit, multipleValue);
            return range * (range + 1) / 2 * multipleValue;
        }
        public static long GetSumOfNumbers(long limit)
        {
            return GetSumOfRange(limit, firstNumber) +
                   GetSumOfRange(limit, secondNumber) -
                   GetSumOfRange(limit, firstNumber * secondNumber);

            //naive approach
            //return Enumerable.Range(0, limit).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
        }
    }
}
