using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblemMSTest;
namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class TestMoodAnalysis
    {
        [TestMethod]
        [DataRow("I am in a sad Mood ")]
        public void GivenStringInput_WhenTestMoodAnalysis_shouldReturnSad(string message)
        {
            MoodAnalyzer moodAnalysis = new MoodAnalyzer(message);
            string mood = moodAnalysis.AnalyseMethod();
            Assert.AreEqual(mood, "sad");
        }
        [TestMethod]
        [DataRow("I am in a happy Mood")]
        public void GivenStringInput_WhenTestMoodAnalysis_shouldReturnHappy(string message)
        {
            MoodAnalyzer moodAnalysis = new MoodAnalyzer(message);
            string mood = moodAnalysis.AnalyseMethod();
            Assert.AreEqual(mood, "happy");
        }
        [TestMethod]
        [DataRow("null")]
        public void GivenNullInput_WhenTestMoodAnalysis_shouldThrowMoodAnalysisException(string message)
        {
            try
            {
                MoodAnalyzer moodAnalysis = new MoodAnalyzer(null);
                string mood = moodAnalysis.AnalyseMethod();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is null");
            }
        }
        [TestMethod]
        [DataRow("")]
        public void GivenEmptyInput_WhenTestMoodAnalysis_shouldThrowMoodAnalysisException(string message)
        {
            try
            {
                MoodAnalyzer moodAnalysis = new MoodAnalyzer("");
                string mood = moodAnalysis.AnalyseMethod();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is Empty");
            }
        }
    }
}