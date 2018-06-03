using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GI.Web.Models;
using GI.IService;
using GI.DTO;
using CodeHelper;

namespace GI.Web.Controllers
{
    public class HomeController : Controller
    {
        public IUserService _userService { get; set; }
        public async Task<IActionResult> Index()
        {
            UserDTO user = new UserDTO();
            user.Account = "dongzirun";
            user.CreateTime = DateTime.Now;
            user.Email = "942217633@qq.com";
            user.IsDel = false;
            user.Password = CommonHelper.CalcMD5("abc123");
            user.Phone = "17688708658";
            user.UserId = Guid.NewGuid();
            user.UserName = "董子润";
            var res = await _userService.Add(user);
            var res2 = await _userService.GetUserInfoById(user.UserId);
            var res3 = await _userService.GetUserList(null, 1, 10);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
