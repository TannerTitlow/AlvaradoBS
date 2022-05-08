using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AlvaradoBS.Controllers;

namespace AlvaradoBS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AlvaradoBSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
