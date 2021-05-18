using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab.Logic;

namespace lab
{
    public static class Lab5_UpDownCasting_Tester
    {
        public static void Run()
        {
            Theme theme1 = new("test theme");
            Storage<Test> storage1 = theme1;
            Console.WriteLine("Upcast done");

           /* Storage<Test> storage2 = new("test storage");
            Theme theme2 = (Theme)storage2;
            Console.WriteLine("Downcast done");*/
        }
    }
}
