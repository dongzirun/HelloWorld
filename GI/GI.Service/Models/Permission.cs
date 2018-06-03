using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Service.Models
{
    public class Permission
    {
        public Guid Id { get; set; }
        public string PermissionName { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDel { get; set; }
       // public List<Role> Roles { get; set; }
    }
}
