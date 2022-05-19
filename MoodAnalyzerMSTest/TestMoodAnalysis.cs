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
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyzer();
            object obj = MoodAnalyserFactory.CreateMoodAnalysis("MoodAnalyzerProblemMSTest.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstuctor()
        {
            object expected = new MoodAnalyzer("happpy");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerProblemMSTest.MoodAnalyzer", "MoodAnalyzer","happy");
            expected.Equals(obj);
        }
        [TestMethod]
        public void GivenhappyMoodShouldReturnhappy()
        {
            string expected = "happy";
            string mood = MoodAnalyserFactory.InvokeAnalyseMood("happy", "AnalyseMethod");
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        public void Given_happyMessage_WithReflector_Should_Returnhappy()
        {
            string result = MoodAnalyserFactory.SetField("happy", "message");
            Assert.AreEqual("happy", result);
        }
    }
}