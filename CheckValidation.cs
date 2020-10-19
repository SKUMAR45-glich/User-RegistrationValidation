using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class CheckValidation
    {
        string _fname;
        string _lname;
        string _email;
        string _password;
        string _phnumber;
        public CheckValidation()
        {
            this._fname = "";
            this._lname = "";
            this._email = "";
            this._password = "";
            this._phnumber = "";
        }
        public string VerifyFirstName(string fname)
        {
            Regex regex = new Regex("^[A-Z][a-zA-Z]{3,}$");
            if (regex.IsMatch(fname))
            {
                return "HAPPY";
            }
            else
            {
                throw new ValidationException(ValidationException.InvalidType.Invalid_FName, "Invalid First Name");
            }
        }

        public string VerifyLastName(string lname)
        {
            Regex regex = new Regex("^[A-Z][a-zA-Z]{3,}$");
            if (regex.IsMatch(lname))
            {
                return "SAD";
            }
            else
            {
                throw new ValidationException(ValidationException.InvalidType.Invalid_LName, "Invalid Last Name");
            }
        }

        public string VerifyEmailId(string email)
        {
            Regex regex = new Regex("^[abc]+.+[A-Za-z]+@+[bl]+.+[A-Za-z]+$");
            if (regex.IsMatch(email))
            {
                return "HAPPY";
            }
            else
            {
                throw new ValidationException(ValidationException.InvalidType.Invalid_Email, "Invalid EmailID");
            }
        }
        public string VerifyPhoneNumber(string phno)
        {
            Regex regex = new Regex("^[91 ]+[0-9]{10}$");
            if (regex.IsMatch(phno))
            {
                return "HAPPY";
            }
            else
            {
                throw new ValidationException(ValidationException.InvalidType.Invalid_PhNumber, "Invalid Phone Number");
            }
        }
        public string VerifyPassword(string password)
        {
            Regex regex = new Regex("(?=.*[A-Z])(?=.*[0-9])(?=.?[#?!@$%^&*-])[A-Za-z].{8,}$");
            if (regex.IsMatch(password))
            {
                return "HAPPY";
            }
            else
            {
                throw new ValidationException(ValidationException.InvalidType.Invalid_Password, "Invalid Password");
            }
        }
    }
}
