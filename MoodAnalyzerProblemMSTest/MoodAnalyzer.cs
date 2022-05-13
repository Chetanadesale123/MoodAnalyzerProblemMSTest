namespace MoodAnalyzerProblemMSTest
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMethod()
        {
            if (message.ToLower().Contains("sad"))
            {
                return "sad";
            }
            return "happy";
        }
    }
}