using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturn_Client
{
    internal class ChangeResponse
    {
        public string saturnCode { get; set; }
        public string newPassword { get; set; }
        public string newLastName { get; set; }
        public string newFirstName { get; set; }
        public string newEmail { get; set; }
        public string newPhone { get; set; }
        public List<string> newRoles { get; set; }
    }
}
