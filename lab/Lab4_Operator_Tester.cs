using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab.Logic;

namespace lab
{
    public static class Lab4_Operator_Tester
    {
        public static void Run()
        {
            Result resultFirst = new();
            Result resultSecond = new();

            resultFirst.Score = 66;
            resultSecond.Score = 56;

            Console.WriteLine("Operator +");
            Console.WriteLine("Result before call:");
            Console.WriteLine(resultFirst.Score);
            resultFirst += 123;
            Console.WriteLine("Result after call:");
            Console.WriteLine(resultFirst.Score);

            Console.WriteLine("Operator ++");
            Console.WriteLine("Result before call:");
            Console.WriteLine(resultSecond.Score);
            resultSecond++;
            Console.WriteLine("Result after call:");
            Console.WriteLine(resultSecond.Score);

            Console.WriteLine("Operator >");
            Console.WriteLine("Results before call:");
            Console.WriteLine(resultFirst.Score);
            Console.WriteLine(resultSecond.Score);
            Console.WriteLine("Operator call:");
            Console.WriteLine(resultFirst.Score > resultSecond.Score);

            resultFirst.Score = resultSecond.Score;

            Console.WriteLine("Operator ==");
            Console.WriteLine("Results before call:");
            Console.WriteLine(resultFirst.Score);
            Console.WriteLine(resultSecond.Score);
            Console.WriteLine("Operator call:");
            Console.WriteLine(resultFirst.Score == resultSecond.Score);
        }
    }
}
