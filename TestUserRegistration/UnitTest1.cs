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
            string phnumber = "91 9887744556";
            CheckValidation lnamevalid = new CheckValidation(lname);
            string expected = "Valid";

            //Act
            string actual = lnamevalid.ValidPhoneNumber();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
