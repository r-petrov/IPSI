namespace IPSI.Services.Models.InputModels.Company
{
    using System.ComponentModel.DataAnnotations;

    using IPSI.Data.Models;
    using IPSI.Services.Mapping;

    public class CreateCompanyInputModel : IMapTo<Company>
    {
        [Required]
        public string Name { get; set; }

        public string Broker { get; set; }
    }
}
