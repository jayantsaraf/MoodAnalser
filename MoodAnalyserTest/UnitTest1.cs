using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalyzeSadMood()
        {
            //Arrange
            MoodAnalyse analyser = new MoodAnalyse("Sad mood");
            //Act
            string mood = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("Sad", mood);
        }
        [TestMethod]
        public void AnalyzeHappyMood()
        {
            //Arrange
            MoodAnalyse analyser = new MoodAnalyse("Happy mood");
            //Act
            string mood = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("Happy", mood);
        }
        [TestMethod]
        public void MoodAnalyser_Should_Return_Happy_For_Invalid_Input()
        {
            //Arrange
            MoodAnalyse analyser = new MoodAnalyse();
            //Act
            string mood = analyser.AnalyseMood();
            //Assert
            Assert.AreEqual("Happy", mood);
        }
    }
}