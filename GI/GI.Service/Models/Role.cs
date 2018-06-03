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

        /// <summary>
        /// UserRole对象集合
        /// </summary>
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();

        /// <summary>
        /// RolePermissionss对象集合
        /// </summary>
        public List<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
