using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class CheckValidation
    {
        string _password;
        public CheckValidation(string password)
        {
            this._password = password;
        }
        public string ValidPassword()
        {
            Regex regex = new Regex("(?=.*[A-Z])(?=.*[0-9])(?=.?[#?!@$%^&*-])(A-Za_z0-9){8,}$");
            if (regex.IsMatch(this._password))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
    }
}
