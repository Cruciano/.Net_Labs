using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab.Logic;

namespace lab
{
    public class Tester
    {
        private User _currentUser;
        private TestSystem _system;
        private UserManager _userManager;

        public void Run()
        {
            _userManager = new();
            _userManager.Notify += DisplayMessage;

            Console.WriteLine("Введіть ім'я");
            string name = Console.ReadLine();

            Console.WriteLine("Введіть прізвище");
            string surname = Console.ReadLine();

            Console.WriteLine("Введіть пароль");
            string password = Console.ReadLine();

            int id = _userManager.CreateUser(name, surname, password);
            _userManager.AuthorizeUser(id, password);
            _currentUser = _userManager.GetAuthorizedUser();

            _system = new(_currentUser);

            int themeId = ChooseTheme();
            Test test = ChooseTest(themeId);
            PassTest(test);

            Console.WriteLine("Результат:");
            Console.WriteLine(_system.GetResult().Score);
        }

        private void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        private int ChooseTheme()
        {
            IEnumerable<string> themeNames = _system.GetThemeNames();

            Console.WriteLine();
            Console.WriteLine("Виберіть тему:");
            int j = 1;
            foreach (var theme in themeNames)
            {
                Console.WriteLine(j.ToString() + ". " + theme);
                j++;
            }
            return int.Parse(Console.ReadLine());
        }

        private Test ChooseTest(int themeId)
        {
            IEnumerable<string> testNames = _system.GetTestNames(themeId - 1);

            Console.WriteLine();
            Console.WriteLine("Виберіть теcт:");
            int j = 1;
            foreach (var testname in testNames)
            {
                Console.WriteLine(j.ToString() + ". " + testname);
                j++;
            }
            int testId = int.Parse(Console.ReadLine());

            return _system.GetTest(themeId - 1, testId - 1);
        } 

        private void PrintQuestion(Question q)
        {
            Console.WriteLine(q.question);
            Console.WriteLine(q.GetCombinedAnswers());
        }

        private void PassTest(Test test)
        {
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine("Питання " + (i + 1).ToString());
                PrintQuestion(test.GetItem(i));

                int answnum = int.Parse(Console.ReadLine());

                _system.AnswerQuestion(i, answnum - 1);
            }
        }
    }
}
