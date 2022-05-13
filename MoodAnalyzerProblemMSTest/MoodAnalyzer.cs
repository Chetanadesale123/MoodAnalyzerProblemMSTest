namespace MoodAnalyzerProblemMSTest
{
    public class MoodAnalyzer
    {
        public string AnalyseMethod(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "sad";
            }
            return "happy";
        }
    }
}