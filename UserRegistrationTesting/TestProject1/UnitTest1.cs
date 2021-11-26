using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void ValidFirstNameOfUser()
            {
                //AAA method
                //Arrange
                string name = "Konika";
                string expected = "invalid";
                //creating object of moodanalyzer class and passing message
                //RegularExpression regularExpression = new RegularExpression(name);

                //Act
                string actual = UserRegistration.FirstNameValid(name);

                //Assert
                //comparing actual and expected value
                Assert.AreEqual(expected, actual);
            }
    }
}