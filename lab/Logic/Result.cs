using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.Logic
{
    public class Result
    {
        public string userName;
        public int NumberOfAnswers;
        public int Score;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Result)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(userName, Score, NumberOfAnswers);
        }

        public static Result operator +(Result result, int score)
        {
            result.Score += score;
            return result;
        }

        public static Result operator -(Result result, int score)
        {
            result.Score -= score;
            return result;
        }

        public static Result operator ++(Result result)
        {
            result.Score++;
            return result;
        }

        public static Result operator --(Result result)
        {
            result.Score--;
            return result;
        }

        public static bool operator >(Result result1, Result result2)
        {            
            return result1.Score > result2.Score;
        }

        public static bool operator <(Result result1, Result result2)
        {
            return result1.Score < result2.Score;
        }

        public static bool operator >=(Result result1, Result result2)
        {
            return result1.Score >= result2.Score;
        }

        public static bool operator <=(Result result1, Result result2)
        {
            return result1.Score <= result2.Score;
        }

        public static bool operator ==(Result result1, Result result2)
        {
            return result1.Score == result2.Score;
        }

        public static bool operator !=(Result result1, Result result2)
        {
            return result1.Score < result2.Score;
        }
    }
}
