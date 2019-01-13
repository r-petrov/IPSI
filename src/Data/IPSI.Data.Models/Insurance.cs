namespace IPSI.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using IPSI.Data.Common.Models;

    public class Insurance : BaseModel<int>
    {
        public Insurance()
        {
            this.Companies = new HashSet<CompanyInsurance>();
            this.InsurancePolicies = new HashSet<Policy>();
        }

        [Required]
        public string Type { get; set; }

        public virtual ICollection<CompanyInsurance> Companies { get; set; }

        public virtual ICollection<Policy> InsurancePolicies { get; set; }
    }
}
