using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.Logic
{
    abstract class AbstractUser
    {
        protected string _password;
        protected Test _currentTest;


        public AbstractUser()
        {

        }

        public AbstractUser(int id, string name, string surname, string password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            _password = password;
            TestResult = new();
        }

        public AbstractUser(AbstractUser user)
        {
            Id = user.Id;
            Name = user.Name;
            Surname = user.Surname;
            _password = user._password;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public Result TestResult { get; protected set; }
        public Test CurrentTest
        {
            get
            {
                return _currentTest;
            }
            set
            {
                _currentTest = value;
            }
        }

        public abstract bool CheckPass(string password);

        public abstract bool AnswerQuestion(int id, int answ_num);
    }
}
