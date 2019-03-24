using GI.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GI.IService
{
    public interface IUserService : IServiceSupport
    {
        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="dto">用户信息</param>
        /// <returns>结果</returns>
        Task<Result> Add(UserDTO dto);

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="UserId">用户id</param>
        /// <returns>结果</returns>
        Task<Result> DelUser(Guid UserId);

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="UserId">用户id</param>
        /// <returns>结果</returns>
        Task<Result> GetUserInfoById(Guid UserId);

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="name">筛选名字</param>
        /// <param name="currentIndex">分页页码</param>
        /// <param name="pageSize">分页页大小</param>
        /// <returns>结果</returns>
        Task<Result> GetUserList(string name, int currentIndex, int pageSize);

        /// <summary>
        /// 获取用户权限
        /// </summary>
        /// <param name="UserId">用户id</param>
        /// <returns>结果</returns>
        Task<Result> GetUserRoles(Guid UserId);
    }
}
