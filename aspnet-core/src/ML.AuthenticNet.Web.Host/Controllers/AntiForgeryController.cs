using Microsoft.AspNetCore.Antiforgery;
using ML.AuthenticNet.Controllers;

namespace ML.AuthenticNet.Web.Host.Controllers
{
    public class AntiForgeryController : AuthenticNetControllerBase
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
