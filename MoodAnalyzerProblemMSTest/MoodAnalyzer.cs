namespace MoodAnalyzerProblemMSTest
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer()
        {

        }
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMethod()
        {
            try
            {
                if (message == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MOOD, "Message is Null");
                }
                if (message.Equals(""))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "Message is Empty");
                }
                if (message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (MoodAnalyzerException ex)
            {
                return ex.Message;
            }
        }
    }
}