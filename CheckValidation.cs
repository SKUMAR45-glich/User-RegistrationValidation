using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class CheckValidation
    {
        string _fname;
        public CheckValidation(string fname)
        {
            this._fname = fname;
        }
        public string ValidFirstName()
        {
            Regex regex = new Regex("^[A-Z][a-zA-Z]{3,}$");
            if (regex.IsMatch(this._fname))
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
