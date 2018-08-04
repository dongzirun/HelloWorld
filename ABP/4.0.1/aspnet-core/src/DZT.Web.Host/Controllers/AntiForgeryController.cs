using Microsoft.AspNetCore.Antiforgery;
using DZT.Controllers;

namespace DZT.Web.Host.Controllers
{
    public class AntiForgeryController : DZTControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
