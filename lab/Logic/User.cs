using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.Logic
{
    class User : AbstractUser
    {
        public User():base()
        {
        }

        public User(int id, string name, string surname, string password):base(id, name, surname, password)
        {
        }

        public User(User user):base(user)
        {
        }


        public override bool CheckPass(string password)
        {
            return _password.Equals(password);
        }

        public override bool AnswerQuestion(int id, int answ_num)
        {
            if (id < 0 || id >= _currentTest.Length)
                throw new ArgumentException("id must be above zero and less than lenght of test");

            if (answ_num < 0 || answ_num >= _currentTest.GetItem(id).answers.Length)
                throw new ArgumentException("answ_num must be above zero and less than count of answers");

            Question question = _currentTest.GetItem(id);
            if (question.correctAnswer == answ_num)
            {
                TestResult += question.score;
                return true;
            }

            return false;
        }
    }
}
