using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;
namespace TestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidationforDetailsforHappy()
        {
            //Arrange
            string fname = "ABC";
            string lname = "Def";
            string email = "abc@gmail.com";
            string password = "abc1223@A";
            string phnumber = "91 9887744556";
            CheckValidation validDetails = new CheckValidation(fname, lname, email, password, phnumber);
            string expected = "HAPPY";

            //Act
            string actual = validDetails.DetailsValidation();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void ValidationforDetailsforSad()
        {
            //Arrange
            string fname = "";
            string lname = "";
            string email = "abc@gmail.com";
            string password = "abc1223@A";
            string phnumber = "91 9887744556";
            CheckValidation validDetails = new CheckValidation(fname, lname, email, password, phnumber);
            string expected = "SAD";

            //Act
            string actual = validDetails.DetailsValidation();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
