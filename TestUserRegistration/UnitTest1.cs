using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;
namespace TestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            //Arrange
            //string email = "abc@yahoo.com";
            CheckValidation lnamevalid = new CheckValidation();
            string expected = "Valid";

            //Act
            string actual = CheckValidation.VerifyEmail();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
