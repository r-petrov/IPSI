namespace IPSI.Services.Data.Contracts
{
    using System.Collections.Generic;

    using IPSI.Data.Models;

    public interface ICompaniesService
    {
        IEnumerable<Company> GetCompanies();
    }
}
