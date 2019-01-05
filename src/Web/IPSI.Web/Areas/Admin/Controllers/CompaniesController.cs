namespace IPSI.Web.Areas.Admin.Controllers
{
    using IPSI.Common;
    using IPSI.Services.Data.Contracts;
    using IPSI.Services.Models.InputModels.Company;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    public class CompaniesController : BaseAdminController
    {
        private readonly ICompaniesService companiesService;

        public CompaniesController(ICompaniesService companiesService)
        {
            this.companiesService = companiesService;
        }

        // GET: Companies
        [HttpGet]
        public ActionResult All()
        {
            var companyListViewModel = this.companiesService.GetCompanyList();

            return this.View(companyListViewModel);
        }

        // GET: Companies/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Companies/Create
        [HttpGet]
        public ActionResult Create()
        {
            return this.View();
        }

        // POST: Companies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCompanyInputModel inputModel)
        {
            // TODO: Add insert logic here

            return this.RedirectToAction(nameof(All));
        }

        // GET: Companies/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Companies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Companies/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Companies/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}