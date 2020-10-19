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
            string lname = "Def";
            CheckValidation lnamevalid = new CheckValidation(lname);
            string expected = "Valid";

            //Act
            string actual = lnamevalid.ValidLastName();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
