using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SadMoodCheck()
        {
            //Arrange
            MoodAnalyse analyser = new MoodAnalyse("I am in a Sad mood");
            //Act
            string mood = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("Sad", mood);
        }
        [TestMethod]
        public void HappyMoodCheck()
        {
            //Arrange
            MoodAnalyse analyser = new MoodAnalyse("I am in a Happy mood");
            //Act
            string mood = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("Happy", mood);
        }
    }
}