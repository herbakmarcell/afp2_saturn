using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturn_Client
{
    public class ErrorResponse
    {
        public string type { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public ErrorDetails errors { get; set; }
        public string traceId { get; set; }
    }

    public class ErrorDetails
    {
        public string[] FirstName { get; set; }
        public string[] LastName { get; set; }
        public string[] Email { get; set; }
        public string[] PhoneNumber { get; set; }
        public string[] Password { get; set; }
        public string[] NewFirstName { get; set; }
        public string[] NewLastName { get; set; }
        public string[] NewEmail { get; set; }
        public string[] NewPhoneNumber { get; set; }
        public string[] NewPassword { get; set; }

        public object this[int index]
        {
            get 
            {
                if (FirstName != null)
                {
                    return FirstName[index];
                }
                if (LastName != null)
                {
                    return LastName[index];
                }
                if (Email != null)
                {
                    return Email[index];
                }
                if (PhoneNumber != null)
                {
                    return PhoneNumber[index];
                }
                if (Password != null)
                {
                    return Password[index];
                }
                if (NewFirstName != null)
                {
                    return NewFirstName[index];
                }
                if (NewLastName != null)
                {
                    return NewLastName[index];
                }
                if (NewEmail != null)
                {
                    return NewEmail[index];
                }
                if (NewPhoneNumber != null)
                {
                    return NewPhoneNumber[index];
                }
                if (NewPassword != null)
                {
                    return NewPassword[index];
                }
                return null;
            }
        }
    }
}
