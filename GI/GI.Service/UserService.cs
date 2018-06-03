using AutoMapper;
using GI.DTO;
using GI.IService;
using GI.Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI.Service
{
    class UserService : IUserService
    {
        public GIContext _ctx { get; set; }


        public async Task<Result> Add(UserDTO dto)
        {
            Result res = new Result(false, "fail");
            User user = Mapper.Map<UserDTO, User>(dto);


            if (_ctx.User.AsNoTracking().Any(u => u.Phone == user.Phone))
            {
                res.Msg = "用户手机号已存在";
                return res;
            }
            if (_ctx.User.AsNoTracking().Any(u => u.Email == user.Email))
            {
                res.Msg = "用户邮箱已存在";
                return res;
            }
            if (_ctx.User.AsNoTracking().Any(u => u.Account == user.Account))
            {
                res.Msg = "用户登陆账号已存在";
                return res;
            }

            await _ctx.User.AddAsync(user);
            if (await _ctx.SaveChangesAsync() > 0)
            {
                res.Res = true;
                res.Msg = "sucess";
            }

            return res;
        }

        public async Task<Result> DelUser(Guid id)
        {
            Result res = new Result(false, "fail");
            var entity = _ctx.User.FirstOrDefault(s => s.UserId == id && s.IsDel == false);
            if (entity != null)
            {
                entity.IsDel = true;
                if (await _ctx.SaveChangesAsync() > 0)
                {
                    res.Res = true;
                    res.Msg = "success";
                }
            }
            return res;
        }

        public async Task<Result> GetById(Guid id)
        {
            Result res = new Result(false, "fail");
            var entity = await _ctx.User.AsNoTracking()
                .FirstOrDefaultAsync(s => s.UserId == id && s.IsDel == false);
            if (entity != null)
            {
                res.Res = true;
                res.Msg = "success";
                res.Data = Mapper.Map<User, UserDTO>(entity);
            }
            return res;
        }

        public async Task<Result> GetUserList(string name, int currentIndex, int pageSize)
        {

            Result res = new Result(true, "success");

            var data = _ctx.User.Where(s => s.IsDel == false);
            if (!string.IsNullOrEmpty(name))
            {
                data = data.Where(n => n.UserName.Contains(name));
            }
            UserQueryDTO sr = new UserQueryDTO();
            sr.TotalCount = data.Count();
            data = data.OrderByDescending(d => d.CreateTime).Skip((currentIndex - 1) * pageSize).Take(pageSize);
            List<User> list = await data.ToListAsync();
            sr.UserResult = Mapper.Map<List<User>, List<UserDTO>>(list).ToArray();
            res.Data = sr;
            return res;
        }

        public async Task<Result> UpdateUser(UserDTO dto)
        {
            Result res = new Result(false, "fail");

            var data = _ctx.User.FirstOrDefault(s => s.UserId == dto.UserId);
            if (data != null)
            {

            }
            if (await _ctx.SaveChangesAsync() > 0)
            {
                res.Res = true;
            }
            return res;
        }
    }
}
