using System;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const string name = "======Лабораторна робота №1======\n" +
                               "=Виконав студент групи IТ-81    =\n" +
                               "=Сніжок Максим ІТ-8120          =\n" +
                               "=================================\n";

            /*Console.WriteLine(name);
            Tester tester = new();
            tester.Run();

            /*Console.WriteLine("=================================");
            Console.WriteLine("Lab2_Tester start:");
            Lab2_Contstructor_Tester.Run();

            Console.WriteLine("=================================");
            Console.WriteLine("Lab3_Tester start:");
            Lab3_Property_Tester.Run();

            Console.WriteLine("=================================");
            Console.WriteLine("Lab4_Tester start:");
            Lab4_Operator_Tester.Run();

            Console.WriteLine("=================================");
            Console.WriteLine("Lab5_Tester start:");
            Lab5_UpDownCasting_Tester.Run();*/

            Console.WriteLine("=================================");
            Console.WriteLine("Lab7_Tester start:");
            Lab7_Exceptions_Tester.Run();

            Console.ReadLine();
        }
    }
}
