using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Shared.Services
{
    public class PersistentData
    {
        public string Name { get; set; }
        public int Role { get; set; }
        public bool Logged { get; set; }

        public string Email { get; set; }
    }
}
