using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver
{
    public static class SequenceAnalysis
    {
        public static string Analyse(string input)
        {
            return string.Concat(input.Where(c => char.IsUpper(c)).OrderBy(c => c));
        }
    } 
}
