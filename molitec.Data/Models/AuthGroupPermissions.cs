﻿using System;
using System.Collections.Generic;

namespace molitec.Data.Models
{
    public partial class AuthGroupPermissions
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int PermissionId { get; set; }
    }
}
