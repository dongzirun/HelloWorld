using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Service.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreateTime { get; set; }
       // public List<User> users { get; set; }

       // public List<Permission> Permissions { get; set; }

    }
}
