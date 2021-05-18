using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab.Logic;

namespace lab
{
    public static class Lab3_Property_Tester
    {
        public static void Run()
        {
            User user1 = new(1, "Vasya", "Pupkin", "password");
            Console.WriteLine($"\nProperty get name: {user1.Name}");
            Console.WriteLine($"\nProperty get surname: {user1.Surname}");

            Store store = new();
            user1.CurrentTest = store.GetTest(1, 1);
            Console.WriteLine("Property set has called");
        }
    }
}

