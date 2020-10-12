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
            Assert.AreEqual("SAD", analyse.message);
        }
        [TestMethod]
        public void analyseHappyMood()
        {
            MoodAnalyse analyse = new MoodAnalyse("I am in Happy Mood");
            Assert.AreEqual("HAPPY", analyse.message);
        }




    }
}
