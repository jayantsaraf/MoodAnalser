using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]

        public void analyseSadMood()
        {
            MoodAnalyse analyse = new MoodAnalyse("SAD");
            string mood = analyse.analyseMood();
            Assert.AreEqual("SAD", mood);
        }
        [TestMethod]
        public void analyseHappyMood()
        {
            MoodAnalyse analyse = new MoodAnalyse("I am in Happy Mood");
            string mood = analyse.analyseMood();
            Assert.AreEqual("HAPPY", mood);
        }
        [TestMethod]
        public void returnForNull()
        {
            MoodAnalyse analyse = new MoodAnalyse();
            string mood = analyse.analyseMood();
            Assert.AreEqual("HAPPY", mood);
        }
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()////checking empty mood
        {
            try
            {
                string message = string.Empty;
                MoodAnalyse mood = new MoodAnalyse(message);
                string moodStr = mood.analyseMood();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string mood = moodAnalyse.analyseMood();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        [TestMethod]
        public void GivenMoodANalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyse(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyse", "MoodAnalyse");
            Assert.AreEqual(expected.GetType(), obj.GetType());
        }
        [TestMethod]
        public void GivenMoodANalyserClassName_ShouldReturnWrongClassException()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyse(message);
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("abc.abc", "abc");
                Assert.AreEqual(expected.GetType(), obj.GetType());
            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual("No Such Class Found", e.Message);
            }
            
        }
        [TestMethod]
        public void GivenMoodANalyserClassName_ShouldReturnWrongConstructorException()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyse(message);
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyse", "abc");
                Assert.AreEqual(expected.GetType(), obj.GetType());
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("No such method", e.Message);
            }

        }

    }
}
