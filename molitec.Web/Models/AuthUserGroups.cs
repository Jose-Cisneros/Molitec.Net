using System;
using System.Collections.Generic;

namespace molitec.Web.Models
{
    public partial class AuthUserGroups
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
    }
}
