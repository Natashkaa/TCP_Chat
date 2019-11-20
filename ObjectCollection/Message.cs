using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCollection
{
    [Serializable]
    public class Message
    {
        public string Type { get; } = "message";
        public string Content { get; set; }
        public string Sender { get; set; }
    }
}
