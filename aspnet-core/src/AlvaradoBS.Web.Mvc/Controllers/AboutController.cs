using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AlvaradoBS.Controllers;

namespace AlvaradoBS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AlvaradoBSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
