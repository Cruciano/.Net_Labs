using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab.Logic;

namespace lab
{
    public static class Lab2_Contstructor_Tester
    {
        public static void Run()
        {
            User user1 = new();
            Console.WriteLine("Defaut constructor was called");

            User user2 = new(1, "Vasya", "Pupkin", "password");
            Console.WriteLine("\nInitialize constructor was called");
            Console.WriteLine($"\nUser2 name: {user2.Name},\nUser2 surname: {user2.Surname}");

            User user3 = new(user2);
            Console.WriteLine("\nCopy constructor was called");
            Console.WriteLine($"\nUser3 name: {user3.Name},\nUser3 surname: {user3.Surname}");
        }
    }
}
