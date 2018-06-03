using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DTO
{
    public class UserQueryDTO
    {
        public UserDTO[] UserResult { get; set; }
        public int TotalCount { get; set; }
    }
}
