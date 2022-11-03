using Interview.Models;
using System;
using System.Collections.Generic;

namespace Interview
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Status Status { get; set; }

    }
}
