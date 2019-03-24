using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Service.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 用户对应的角色集合
        /// </summary>
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
