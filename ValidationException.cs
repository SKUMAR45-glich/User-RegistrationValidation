using System;
using System.Collections.Generic;
using System.Text;

namespace UserValidation
{
    public class ValidationException : Exception
    {
        public enum InvalidType
        {

            Invalid_FName,
            Invalid_LName,
            Invalid_Email,
            Invalid_PhNumber,
            Invalid_Password
        }

        private readonly InvalidType invalid;

        public ValidationException(InvalidType type, string message) : base(message)
        {
            invalid = type;
        }
    }
}
