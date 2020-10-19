using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;
namespace TestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void validityFirstName()
        {
            string actual;
            try
            {
                string name = "Abc";
                CheckValidation customExceptionforInvalidDetails = new CheckValidation();
                actual = customExceptionforInvalidDetails.VerifyFirstName(name);


            }

            catch (ValidationException exception)
            {
                actual = exception.Message;
            }

            Assert.AreEqual("Invalid First Name", actual);

        }

        public void validityLastName()
        {
            string actual;
            try
            {
                string name = "Def";
                CheckValidation customExceptionforInvalidDetails = new CheckValidation();
                actual = customExceptionforInvalidDetails.VerifyLastName(name);


            }

            catch (ValidationException exception)
            {
                actual = exception.Message;
            }

            Assert.AreEqual("Invalid Last Name", actual);

        }

        public void validityEmailID()
        {
            string actual;
            try
            {
                string email = "abc@gmail.com";
                CheckValidation customExceptionforInvalidDetails = new CheckValidation();
                actual = customExceptionforInvalidDetails.VerifyEmailId(email);


            }

            catch (ValidationException exception)
            {
                actual = exception.Message;
            }

            Assert.AreEqual("Invalid MailID", actual);

        }

        public void validityPassword()
        {
            string actual;
            try
            {
                string password = "Stranger@6917";
                CheckValidation customExceptionforInvalidDetails = new CheckValidation();
                actual = customExceptionforInvalidDetails.VerifyPassword(password);


            }

            catch (ValidationException exception)
            {
                actual = exception.Message;
            }

            Assert.AreEqual("Invalid Password", actual);

        }


        public void validityPhoneNumber()
        {
            string actual;
            try
            {
                string phno = "91 9088880216";
                CustomExceptionforInvalidDetails customExceptionforInvalidDetails = new CustomExceptionforInvalidDetails();
                actual = customExceptionforInvalidDetails.VerifyPhoneNumber(phno);


            }

            catch (ValidationException exception)
            {
                actual = exception.Message;
            }

            Assert.AreEqual("Invalid First Name", actual);

        }

    }
}
