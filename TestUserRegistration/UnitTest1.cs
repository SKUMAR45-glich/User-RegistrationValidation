using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;
namespace TestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("abc@gmail.com")]
        [DataRow("abc.be@gmail.co.in")]
        [DataRow("abc@gmail.co.in")]
        [DataRow("abc161@gmail.com")]
        public void ValidationforDetailsforHappy(string email)
        {
            CheckValidation validEmailList = new CheckValidation();
            string expected = "HAPPY";

            //Act
            string actual = validEmailList.VerifiedEmailList(email);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abcd.@gmail.com")]
        [DataRow("abcd@ef@gmail.co.in")]
        [DataRow("se@gmail.co.in.uk")]
        [DataRow("abc161@.gmail.com")]
        public void ValidationforValidEmailID(string email)
        {
            //Arrange
            CheckValidation validEmailList = new CheckValidation();
            string expected = "SAD";

            //Act
            string actual = validEmailList.VerifiedEmailList(email);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
