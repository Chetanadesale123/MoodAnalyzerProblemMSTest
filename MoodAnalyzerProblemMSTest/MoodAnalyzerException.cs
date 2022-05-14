using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblemMSTest
{
    public class MoodAnalyzerException:Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD, EMPTY_MOOD,NO_SUCH_CLASS,NO_SUCH_METHOD
        }
        public ExceptionType exceptionType;
        public MoodAnalyzerException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}
