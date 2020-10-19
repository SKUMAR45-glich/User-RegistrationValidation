using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class LambdaList
    {
        CheckValidation checkValidation = new CheckValidation();

        public List<string> VerifiedFirstNames(List<string> fNameList)
        {
            //returns valid first names in the list
            return fNameList.FindAll(fName => Regex.IsMatch(fName, checkValidation.FirstName));
        }

        public List<string> VerifiedLastNames(List<string> lNameList)
        {
            //returns valid last names in the list
            return lNameList.FindAll(lName => Regex.IsMatch(lName, checkValidation.LastName));
        }

        public List<string> VerifiedEmailList(List<string> emailList)
        {
            //return valid mail ids in list
            return emailList.FindAll(email => Regex.IsMatch(email, checkValidation.Email));
        }

        public List<string> VerifiedPhoneNumber(List<string> phNumList)
        {
            //returns valid phone number list
            return phNumList.FindAll(phNum => Regex.IsMatch(phNum, checkValidation.PhoneNumber));
        }

        public List<string> VerifiedPasswords(List<string> passwords)
        {
            //returns valid password lists
            return passwords.FindAll(password => Regex.IsMatch(password, checkValidation.Password));
        }
    }
}
