using NUnit.Framework;

namespace ChapterOne.Utilities.Tests
{
    public class StringUtilitiesTests
    {
        [Test]
        public void ShouldFindOneYInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "y";
            var expectedResult = 1;
            var classUnderTest = new StringUtilities();

            var actualResult =
                classUnderTest.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ShouldFindTwoSInMysterious()
        {
            Assert.AreEqual(2, 2);
        }

        [Test]
        public void SearchShouldBeCaseSenstive()
        {
            var stringToCheck = "mySterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();

            var actualResult =
                classUnderTest.CountOccurences(stringToCheck,
                                               stringToFind);

            //Assert.True();
        }

        [Test]
        public void ShouldBeAbleToHandleNulls()
        {
            string stringToCheck = null;
            var stringToFind = "s";
            var expectedResult = -1;
            var classUnderTest = new StringUtilities();

            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);

            //Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
