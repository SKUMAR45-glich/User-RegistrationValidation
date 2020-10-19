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
            string password = "STranger@6917";
            CheckValidation lnamevalid = new CheckValidation(password);
            string expected = "Valid";

            //Act
            string actual = lnamevalid.ValidPassword();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
