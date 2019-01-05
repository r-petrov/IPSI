namespace IPSI.Services.Data.Contracts
{
    using System.Collections.Generic;

    using IPSI.Services.Models.ViewModels.Company;

    public interface ICompaniesService
    {
        CompanyListViewModel GetCompanyList();
    }
}
