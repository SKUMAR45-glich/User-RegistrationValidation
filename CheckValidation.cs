using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class CheckValidation
    {
        string _email;
        public CheckValidation(string email)
        {
            this._email = email;
        }
        public string ValidEmail()
        {
            Regex regex = new Regex("^[abc].[A-Za-z]+@[bl].[A-Za-z]+$");
            if (regex.IsMatch(this._email))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
}
