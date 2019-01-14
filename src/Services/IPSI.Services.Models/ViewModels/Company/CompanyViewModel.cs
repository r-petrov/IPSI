namespace IPSI.Services.Models.ViewModels.Company
{
    using IPSI.Data.Models;
    using IPSI.Services.Mapping;

    public class CompanyViewModel : IMapFrom<Company>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public string Broker { get; set; }
    }
}
