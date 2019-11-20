using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCollection
{
    [Serializable]
    public class User
    {
        public int Id { get; set; } = 0;
        public string Type { get; } = "user";
        public string Name { get; set; }
        public string MailLog { get; set; }
        public string MailPas { get; set; }
        public bool NeedDelete { get; set; } = false;
    }
}
