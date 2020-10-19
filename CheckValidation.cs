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
        public string VerifiedEmailList(List<string> emailList)
        {
            Regex regex = new Regex("^[a-z0-9-+]+([.][a-z0-9+-]+)?[@][a-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$");
            foreach (string email in emailList)
            {
                if (regex.IsMatch(email))
                {
                    return "HAPPY";
                }

                else
                {
                    return "SAD";
                }

            }
            return "SAD";
        }

        public string VerifiedEmailList(string email)
        {
            throw new NotImplementedException();
        }
    }
}
