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
        public CheckValidation(string fname, string lname, string email, string password, string phnumber)
        {
            this._fname = fname;
            this._lname = lname;
            this._email = email;
            this._password = password;
            this._phnumber = phnumber;
        }
        public string DetailsValidation()
        {
            int flag = 0;
            Regex fname = new Regex("^[A-Z][a-zA-Z]{3,}$");
            Regex lname = new Regex("^[A-Z][a-zA-Z]{3,}$");
            Regex email = new Regex("^[a-z0-9A-Z+-]+([.][a-z0-9A-Z]+)?[@][a-z0-9A-Z]+[.][a-z]{2,3}([.][a-z]{2,})?$");
            Regex password = new Regex("(?=.*[A-Z])(?=.*[0-9])(?=.?[#?!@$%^&*-])[A-Za-z].{8,}$");
            Regex phnumber = new Regex("^[91 ]+[0-9]{10}$");
            if (fname.IsMatch(this._fname))
            {
                if (lname.IsMatch(this._lname))
                {
                    if (email.IsMatch(this._email))
                    {
                        if (password.IsMatch(this._password))
                        {
                            if (phnumber.IsMatch(this._phnumber))
                            {
                                flag = 1;
                            }
                        }
                    }
                }
            }
            if (flag == 1)
            {
                return "HAPPY";
            }
            else
            {
                return "SAD";
            }
        }
    }
}
