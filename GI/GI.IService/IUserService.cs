using GI.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GI.IService
{
    public interface IUserService
    {
        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="dto">用户信息</param>
        /// <returns>结果</returns>
        Task<Result> Add(UserDTO dto);
    }
}
