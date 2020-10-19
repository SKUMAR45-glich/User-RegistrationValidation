using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;
namespace TestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow("Abc")]
        [DataRow("ABC")]
        [DataRow("Saurabh")]
        public void validityFirstName(string fName)
        {
            //Arrange
            CheckValidation checkValidation = new CheckValidation();
            bool expected = true;

            //Act
             bool actual = checkValidation.VerifyFirstName(fName);

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        [DataRow("Ab")]
        [DataRow("abc")]
        [DataRow("@bcde")]

        public void invalidityFirstName(string fName)
        {
            //Arrange
            CheckValidation checkValidation = new CheckValidation();
            string expected = "Wrong First Name";

            string actual;
            //Act
            try
            {
                actual = checkValidation.VerifyFirstName(fName).ToString();
            }
            catch (ValidationException e)
            {
                actual = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [DataRow("Abc")]
        [DataRow("ABC")]
        [DataRow("Saurabh")]
        public void validityLastName(string lName)
        {
            //Arrange
            CheckValidation checkValidation = new CheckValidation();
            bool expected = true;

            //Act
            bool actual = checkValidation.VerifyLastName(lName);

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        [DataRow("Ab")]
        [DataRow("abc")]
        [DataRow("@bcde")]

        public void invalidityLastName(string lName)
        {
            //Arrange
            CheckValidation checkValidation = new CheckValidation();
            string expected = "Wrong Last Name";

            string actual;
            //Act
            try
            {
                actual = checkValidation.VerifyLastName(lName).ToString();
            }
            catch (ValidationException e)
            {
                actual = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        [DataRow("abc@gmail.com")]
        [DataRow("abc.cg@gmail.co.in")]
        [DataRow("saurabh.nit20@gmail.com")]
        public void ValidEmailName(string email)
        {
            //Arrange
            CheckValidation checkValidation = new CheckValidation();
            bool expected = true;

            //Act
            bool actual = checkValidation.VerifyEmail(email);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("ab@c@gmail.com")]
        [DataRow("abc200.cg@gmail.co.in")]
        [DataRow("saurabh.nit20@gmail.com72")]
        public void InvalidityEmailName(string email)
        {
            //Arrange
            CheckValidation checkValidation = new CheckValidation();
            string expected = "Wrong EmailId";

            string actual;
            //Act
            try
            {
                actual = checkValidation.VerifyEmail(email).ToString();
            }
            catch (ValidationException e)
            {
                actual = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        [DataRow("Str@nger6917")]
        [DataRow("125@23141sdf")]
        [DataRow("2580#12er")]
        public void ValidPassword(string password)
        {
            //Arrange
            CheckValidation checkValidation = new CheckValidation();
            bool expected = true;

            //Act
            bool actual = checkValidation.VerifyPassword(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
