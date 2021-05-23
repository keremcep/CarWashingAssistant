using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using CarWashingAssistant.Controllers;

namespace CarWashingAssistant.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CarWashingAssistantControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
