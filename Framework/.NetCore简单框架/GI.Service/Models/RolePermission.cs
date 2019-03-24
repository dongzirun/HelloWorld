using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Service.Models
{
    /// <summary>
    /// 角色-权限多对多关联表
    /// </summary>
    public class RolePermission
    {
        /// <summary>
        /// 角色Id
        /// </summary>
        public Guid RoleId { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// 权限Id
        /// </summary>
        public Guid PermissionId { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        public Permission Permission { get; set; }
    }
}
