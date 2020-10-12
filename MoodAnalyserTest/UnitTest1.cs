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
        



    }
}
