﻿using System;
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

        /// <summary>
        /// RolePermissionss对象集合
        /// </summary>
        public virtual List<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
