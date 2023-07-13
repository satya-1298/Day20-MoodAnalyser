using MoodAnalyser_Demo;
namespace MoodAnalyser_Test
{
    public class MoodTest
    {

        AnalyseMood mood = new AnalyseMood();
        [Test]
        //Test Case 1
        public void GivenSadMood_ShouldReturnSad()
        {
            string result = mood.MoodAnalyse("I am in Sad Mood");
            Assert.AreEqual(result, "Sad");

        }
        [Test]
        //Test Case 2
        public void GivenMood_ShouldReturnHappyIfNotSad()
        {
            string result = mood.MoodAnalyse("I am in Any Mood");
            Assert.AreEqual(result, "Happy");

        }

    }
}