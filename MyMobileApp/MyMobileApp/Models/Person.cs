using System;
using System.Collections.Generic;
using System.Text;

namespace MyMobileApp.Models
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
