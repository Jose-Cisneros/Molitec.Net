using System;
using System.Collections.Generic;

namespace molitec.Web.Models
{
    public partial class AuthPermission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ContentTypeId { get; set; }
        public string Codename { get; set; }
    }
}
