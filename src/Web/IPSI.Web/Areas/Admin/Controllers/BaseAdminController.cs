namespace IPSI.Web.Areas.Admin.Controllers
{
    using IPSI.Web.Controllers;
    using Microsoft.AspNetCore.Mvc;

    [Area(nameof(Admin))]
    public class BaseAdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}