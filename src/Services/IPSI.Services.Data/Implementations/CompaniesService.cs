namespace IPSI.Services.Data.Implementations
{
    using System.Collections.Generic;
    using System.Linq;

    using IPSI.Data.Common.Repositories;
    using IPSI.Data.Models;
    using IPSI.Services.Data.Contracts;
    using IPSI.Services.Mapping;
    using IPSI.Services.Models.ViewModels.Company;

    public class CompaniesService : ICompaniesService
    {
        private readonly IRepository<Company> companiesRepository;

        public CompaniesService(IRepository<Company> companiesRepository)
        {
            this.companiesRepository = companiesRepository;
        }

        public CompanyListViewModel GetCompanyList()
        {
            var companies = this.companiesRepository
                .All()
                .OrderByDescending(c => c.CreatedOn)
                .To<CompanyViewModel>()
                .ToList();

            var companyListViewModel = new CompanyListViewModel()
            {
                Companies = companies,
            };

            return companyListViewModel;
        }
    }
}
