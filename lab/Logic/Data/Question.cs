using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lab.Logic
{
    class Question
    {
        public string question;
        public string[] answers;
        public int correctAnswer;
        public int score; 

        public Question(string question, string[] answers, int correctAnswer, int score)
        {
            this.question = question;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
            this.score = score;
        }

        public string GetCombinedAnswers()
        {
            int i = 0;
            Func<string, string, string> func = delegate (string current, string next)
            {
                i++;
                return current + i.ToString() + ". " + (next + "\n");
            };

            return answers.Aggregate("", func);
        }
    }
}
