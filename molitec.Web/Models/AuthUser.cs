using System;
using System.Collections.Generic;

namespace molitec.Web.Models
{
    public partial class AuthUser
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public byte IsSuperuser { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte IsStaff { get; set; }
        public byte IsActive { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
