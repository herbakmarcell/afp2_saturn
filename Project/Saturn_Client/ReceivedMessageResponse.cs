using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturn_Client
{
    public class ReceivedMessageResponse
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string content { get; set; }
        public string sender { get; set; }
        public List<string> receivers { get; set; }
    }
}
