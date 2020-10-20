using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserValidation;
namespace TestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {

        
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
