using System;
using System.Linq;

namespace GitTraining.GetWordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            long count = GetWordCount(args[0]);
            Console.WriteLine(String.Format("There are {0} words", count));
        }

        static long GetWordCount(string text) {
            return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
