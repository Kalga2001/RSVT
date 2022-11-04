using Interview.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Interview
{
    public class User
    {
        public Guid UserId { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
        ErrorMessage = "Characters are not allowed.")]
        public string FirstName { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
        ErrorMessage = "Characters are not allowed.")]
        public string LastName { get; set; }
        public Status Status { get; set; }

    }
}
