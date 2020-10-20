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
        
        [TestMethod]
        public void LambdaforValidFirstNames()
        {
            //Arrange
            LambdaList lambdaFirstName = new LambdaList();
            List<string> firstNameList = new List<string>() { "abc", "Abc", "Saurabh" };
            List<string> firstNameListExpected = new List<string>() { "abc", "Abc", "Saurabh" };

            //Act
            List<string> FirstNameListActual =lambdaFirstName.VerifiedFirstNames(firstNameList);

            //Assert
            Assert.AreEqual(true,CompareValueInObject.IsEqual(firstNameListExpected,FirstNameListActual));
            
        }
        
        [TestMethod]
        public void LambdaforValidLastName()
        {
            //Arrange
            LambdaList lambdaLastName = new LambdaList();
            List<string> lastNameList = new List<string>() { "abc", "Abc", "Saurabh" };
            List<string> lastNameListExpected = new List<string>() { "abc", "Abc", "Saurabh" };

            //Act
            List<string> lastNameListActual = lambdaLastName.VerifiedLastNames(lastNameList);

            //Assert
            Assert.AreEqual(true,CompareValueInObject.IsEqual(lastNameListExpected,lastNameListActual));
            
        }
        
        [TestMethod]
        public void LambdaforPassword()
        {
            //Arrange
            LambdaList lambdaPassword = new LambdaList();
            List<string> passwordList = new List<string>() { "@12bc", "Str@nger6917"};
            List<string> passwordListExpected = new List<string>() { "@12bc", "Str@nger6917"};

            //Act
            List<string> passwordListActual = lambdaPassword.VerifiedPasswords(passwordList);

            //Assert
            Assert.AreEqual(true,CompareValueInObject.IsEqual(passwordListExpected,passwordListActual));
            
        }
        
        [TestMethod]
        public void LambdaforEmail()
        {
            //Arrange
            LambdaList lambdaEmail = new LambdaList();
            List<string> emailList = new List<string>() { "abc@gmail.com", "saurabh.nit20@gmail.com"};
            List<string> emailListExpected = new List<string>() { "@12bc", "Str@nger6917"};

            //Act
            List<string> emailListActual = lambdaPassword.VerifiedEmailList(emailList);

            //Assert
            Assert.AreEqual(true,CompareValueInObject.IsEqual(emailListExpected,emailListActual));
            
        }
        
        

    }
}
