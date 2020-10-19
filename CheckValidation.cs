using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class CheckValidation
    {
        string _phnumber;
        public CheckValidation(string phnumber)
        {
            this._phnumber = phnumber;
        }
        public string ValidPhoneNumber()
        {
            Regex regex = new Regex("^[91 ]+[0-9]{10}$");
            if (regex.IsMatch(this._phnumber))
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
