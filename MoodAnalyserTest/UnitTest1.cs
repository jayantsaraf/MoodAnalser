using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
<<<<<<< HEAD
        public void analyseSadMood()
        {
            MoodAnalyse analyse = new MoodAnalyse();
            string message = analyse.analyseMood("Sad");
            Assert.AreEqual("SAD", message);
=======
        public void TestMethod1()
        {
>>>>>>> UC1_AnalyseMood
        }
    }
}
