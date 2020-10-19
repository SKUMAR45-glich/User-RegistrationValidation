using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class CheckValidation
    {
        public static string VerifyEmail()
        {
            List<string> emailList = new List<string>();
            emailList.Add("abc@yahoo.com");
            emailList.Add("abc-100@yahoo.com");
            emailList.Add("abc.100@yahoo.com");
            emailList.Add("abc111@yahoo.com");
            emailList.Add("abc-100@abc.net");
            emailList.Add("abc.100@abc.com.au");
            emailList.Add("abc@1.com");
            emailList.Add("abc@gmail.com.com");
            emailList.Add("abc+100@gmail.com");

            emailList.Add("abc");
            emailList.Add("abc@.com.my");
            emailList.Add("abc123@gmail.a");
            emailList.Add("abc123@.com");
            emailList.Add("abc123@.com.com");
            emailList.Add(".abc@abc.com");
            emailList.Add("abc()*@gmail.com");
            emailList.Add("abc@%*.com");
            emailList.Add("abc..2002@gmail.com");
            emailList.Add("abc.@gmail.com");
            emailList.Add("abc@abc@gmail.com");
            emailList.Add("abc@gmail.com.1a");
            emailList.Add("abc@gmail.com.aa.au");
            Regex regex = new Regex("^[a-z0-9-+]+([.][a-z0-9+-]+)?[@][a-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$");
            foreach (string email in emailList)
            {
                if (regex.IsMatch(email))
                {
                    return "VALID";
                }
                else
                {
                    return "INVALID";
                }
            }
            return "INVALID";

        }
    }
}
