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
    }
}
