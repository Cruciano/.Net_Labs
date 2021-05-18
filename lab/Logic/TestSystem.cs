using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.Logic
{
    class TestSystem
    {
        private User _user;
        private Store _store;

        public TestSystem(User user)
        {
            _user = user;
            userManager = new();
            _store = new();
        }

        public UserManager userManager { get; }

        public IEnumerable<string> GetThemeNames()
        {
            return _store.GetThemeNames();
        }

        public IEnumerable<string> GetTestNames(int themeId)
        {
            return _store.GetTestNames(themeId);
        }

        public Test GetTest(int themeId, int testId)
        {
            Test test = _store.GetTest(themeId, testId);
            _user.CurrentTest = test;
            return  test;
        }

        public bool AnswerQuestion(int questionId, int answerNum)
        {
            return _user.AnswerQuestion(questionId, answerNum);
        }

        public Result GetResult()
        {
            return _user.TestResult;
        }
    }
}
