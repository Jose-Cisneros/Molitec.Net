﻿using System;
using System.Collections.Generic;

namespace molitec.Web.Models
{
    public partial class AuthUserUserPermissions
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PermissionId { get; set; }
    }
}
