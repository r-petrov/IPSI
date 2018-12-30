using IPSI.Data.Common.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IPSI.Data.Models
{
    public class Insurance : BaseModel<int>
    {
        public Insurance()
        {
            this.Companies = new HashSet<CompanyInsurance>();
            this.InsurancePolicies = new HashSet<InsurancePolicy>();
        }

        [Required]
        public string Type { get; set; }

        public virtual ICollection<CompanyInsurance> Companies { get; set; }

        public virtual ICollection<InsurancePolicy> InsurancePolicies { get; set; }
    }
}
