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
            string fname = "Abc";
            CheckValidation fnamevalid = new CheckValidation(fname);
            string expected = "Valid";

            //Act
            string actual = fnamevalid.ValidFirstName();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
