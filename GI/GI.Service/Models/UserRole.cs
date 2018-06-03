    using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Service.Models
{
    /// <summary>
    /// 用户角色表
    /// </summary>
    public class UserRole
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 后台用户对象
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        public Guid RoleId { get; set; }

        /// <summary>
        /// 角色对象
        /// </summary>
        public Role Role { get; set; }
    }
}
