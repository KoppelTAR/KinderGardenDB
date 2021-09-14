using System;
using System.Collections.Generic;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Kindergarden
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }

    }
}