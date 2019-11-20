using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCollection
{
    public class UsersCollection
    {
        public string Type { get; } = "users";
        public List<User> Data { get; set; } = new List<User>();
    }
}
