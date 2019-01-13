namespace IPSI.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using IPSI.Data.Common.Models;

    public class Company : BaseModel<int>
    {
        public Company()
        {
            this.Insurances = new HashSet<CompanyInsurance>();
        }

        [Required]
        public string Name { get; set; }

        public string Logo { get; set; }

        public string Notes { get; set; }

        public virtual ICollection<CompanyInsurance> Insurances { get; set; }
    }
}
