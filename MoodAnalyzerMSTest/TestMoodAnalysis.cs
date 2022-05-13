using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblemMSTest;
namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class TestMoodAnalysis
    {
        [TestMethod]
        public void GivenStringInput_WhenTestAnalyzeMood_shouldReturnSad()
        {
            MoodAnalyzer moodAnalysis = new MoodAnalyzer();
            string mood = moodAnalysis.AnalyseMethod("I am in a sad mood");
            Assert.AreEqual(mood, "sad");
        }
        [TestMethod]
        public void GivenStringInput_WhenTestAnalyzeMood_shouldReturnHappy()
        {
            MoodAnalyzer moodAnalysis = new MoodAnalyzer();
            string mood = moodAnalysis.AnalyseMethod("I am in a happy mood");
            Assert.AreEqual(mood, "happy");
        }
    }
}