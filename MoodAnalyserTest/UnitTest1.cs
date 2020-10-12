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
            MoodAnalyse analyse = new MoodAnalyse();
            string message = analyse.analyseMood("sad");
            Assert.AreEqual("SAD", message);
        }
        [TestMethod]
        public void analyseHappyMood()
        {
            MoodAnalyse analyse = new MoodAnalyse();
            string message = analyse.analyseMood("I am in happy mood");
            Assert.AreEqual("HAPPY", message);
        }


    }
}
