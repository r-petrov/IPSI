namespace IPSI.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using IPSI.Data.Common.Models;

    // TODO: Add property Logo
    public class Company : BaseModel<int>
    {
        public Company()
        {
            this.Insurances = new HashSet<CompanyInsurance>();
        }

        [Required]
        public string Name { get; set; }

        public string Broker { get; set; }

        public virtual ICollection<CompanyInsurance> Insurances { get; set; }
    }
}
