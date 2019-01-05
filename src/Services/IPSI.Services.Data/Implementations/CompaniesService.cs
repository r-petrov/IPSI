namespace IPSI.Services.Data.Implementations
{
    using System.Linq;

    using AutoMapper;
    using IPSI.Data.Common.Repositories;
    using IPSI.Data.Models;
    using IPSI.Services.Data.Contracts;
    using IPSI.Services.Mapping;
    using IPSI.Services.Models.InputModels.Company;
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

        public void CreateCompany(CreateCompanyInputModel inputModel)
        {
            var company = Mapper.Map<Company>(inputModel);
            this.companiesRepository.Add(company);
            var result = this.companiesRepository.SaveChangesAsync().GetAwaiter().GetResult();
        }
    }
}
