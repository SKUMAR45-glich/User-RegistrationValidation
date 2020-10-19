using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class CheckValidation
    {
        string _lname;
        public CheckValidation(string lname)
        {
            this._lname = lname;
        }
        public string ValidLastName()
        {
            Regex regex = new Regex("^[A-Z][a-zA-Z]{3,}$");
            if (regex.IsMatch(this._lname))
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
