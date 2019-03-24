using System;
using System.ComponentModel.DataAnnotations;

namespace GI.DTO
{
    public class UserDTO
    {
        [Required]
        public Guid UserId { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }
        [Display(Name = "账号")]
        public string Account { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
