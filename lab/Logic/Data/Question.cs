using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
