using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Credentials
    {
        public string Password { get; set; }
        public string UserName { get; set; }
        public bool RememberMe { get; set; }

    }
}
