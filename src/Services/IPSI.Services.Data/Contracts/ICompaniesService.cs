namespace IPSI.Services.Data.Contracts
{
    using System.Collections.Generic;
    using IPSI.Services.Models.InputModels.Company;
    using IPSI.Services.Models.ViewModels.Company;

    public interface ICompaniesService
    {
        CompanyListViewModel GetCompanyList();

        void CreateCompany(CreateCompanyInputModel inputModel);
    }
}
