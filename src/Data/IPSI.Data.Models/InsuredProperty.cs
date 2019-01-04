namespace IPSI.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using IPSI.Data.Common.Models;

    public class InsuredProperty : BaseModel<int>
    {
        [Required]
        public string Type { get; set; }

        public string Comment { get; set; }

        public int InsurancePolicyId { get; set; }

        public virtual InsurancePolicy InsurancePolicy { get; set; }
    }
}
