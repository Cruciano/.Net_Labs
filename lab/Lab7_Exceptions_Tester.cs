using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab.Logic;
using lab.Logic.Exceptions;

namespace lab
{
    public static class Lab7_Exceptions_Tester
    {
        public static void Run()
        {
            UserManager userManager = new();

            try
            {
                userManager.CreateUser("", "", "");
            }
            catch (RegistrationException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                userManager.AuthorizeUser(0, "");
            }
            catch (AuthorizeException e)
            {
                Console.WriteLine(e.Message);
            }

            FilterExceptions(10, 10);
            FilterExceptions(10, 5);

            int[] array = new int[10];
            try
            {
                int i = array[11];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Validate(-10);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            userManager = null;

            //userManager.CreateUser("aaa", "aaa", "aaa");
            
        }

        private static void FilterExceptions(int firstLenght, int secondLenght)
        {
            int[] firstArray = new int[firstLenght];
            int[] secondArray = new int[secondLenght];

            try
            {
                firstArray.Divide(secondArray);
            }
            catch (InvalidOperationException e) when (e.Message.Contains("Arrays"))
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static int[] Divide(this int[] first, int[] second)
        {
            if (first.Length != second.Length)
                throw new InvalidOperationException("Arrays should be same lenght");

            var result = new int[first.Length];
            for (int i = 0; i < first.Length; i++)
            {
                if (second[i] == 0)
                    throw new DivideByZeroException($"Element {i} is 0");
                result[i] = first[i] / second[i];
            }

            return result;
        }

        private static void Validate(int a)
        {
            if(a < 0)
                throw new ArgumentOutOfRangeException("'a' should be positiv");
        }
    }
}
