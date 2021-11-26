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
        [TestMethod]
        public void ValidLastNameOfUser()
        {
            //AAA method
            //Arrange
            string lastName = "amir";
            string expected = "valid";

            //Act
            string actual = UserRegistration.LastNameNameValid(lastName);

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidEmailIdOfUser()
        {
            //AAA method
            //Arrange
            string emailId = "Konika1996@gmail.com ";
            string expected = "valid";

            //Act
            string actual = UserRegistration.EmailValid(emailId);

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidMobileNumOfUser()
        {
            //AAA method
            //Arrange
            string num = "91 7090897865 ";
            string expected = "invalid";
            //Act
            string actual = UserRegistration.MobileNumValid(num);

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidPasswordOfUser()
        {
            //AAA method
            //Arrange
            string password = " Konika@3456";
            string expected = "invalid";

            //Act
            string actual = UserRegistration.PasswordValid(password);

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
    }
}