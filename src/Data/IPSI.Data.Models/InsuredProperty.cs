namespace IPSI.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using IPSI.Data.Common.Models;

    public class InsuredProperty : BaseModel<int>
    {
        public InsuredProperty()
        {
            this.Policies = new HashSet<Policy>();
        }

        [Required]
        public string Type { get; set; }

        public string Notes { get; set; }

        public int InsurancePolicyId { get; set; }

        public virtual ICollection<Policy> Policies { get; set; }
    }
}
