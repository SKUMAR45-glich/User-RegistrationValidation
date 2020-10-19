using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class CheckValidation
    {
        public string FirstName = "^[A-Z][a-z A-Z]{2,}$";
        public string LastName = "^[A-Z][a-z A-Z]{2,}$";
        public string Email  = "^[a-z0-9A-Z]+([-.+_][a-z0-9+-]+)*@[a-z0-9A-Z]+[.][a-z]{2,3}([.][a-z]{2,})?$";
        public string PhoneNumber  = "^[0-9]{2}[ ][1-9][0-9]{9}$";
        public string Password = "((?=^.*[0-9].*$)(?=^.*[A-Z].*$)(?=^[a-zA-Z0-9]*[!@#$%&*+_]{1}[a-zA-Z0-9]*$).{8,})";

        public bool VerifyFirstName(string fName)
        {
            if (Regex.IsMatch(fName, FirstName))
                return true;
            else
            {
                
                throw new ValidationException(ValidationException.InvalidType.Invalid_FName,"Wrong First Name");
            }
        }

        public bool VerifyLastName(string lName)
        {

            if (Regex.IsMatch(lName, LastName))
                return true;
            else
            {
                throw new ValidationException(ValidationException.InvalidType.Invalid_LName, "Wrong Last Name");
            }
        }

        public bool VerifyEmail(string eMail)
        {

            if (Regex.IsMatch(eMail, Email))
                return true;
            else
            {
                throw new ValidationException(ValidationException.InvalidType.Invalid_FName, "Wrong EmailID");
            }
        }

        public bool VerifyPhNumber(string phNum)
        {
            if (Regex.IsMatch(phNum, PhoneNumber))
                return true;
            else
            {
                throw new ValidationException(ValidationException.InvalidType.Invalid_FName, "Wrong Phone Number");
            }
        }

        public bool VerifyPassword(string pass)
        {
            if (Regex.IsMatch(pass, Password))
                return true;
            else
            {
                 throw new ValidationException(ValidationException.InvalidType.Invalid_FName, "Wrong EmailID");
            }
        }
    }
}
