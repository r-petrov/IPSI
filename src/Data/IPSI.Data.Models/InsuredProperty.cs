using IPSI.Data.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace IPSI.Data.Models
{
    public class InsuredProperty : BaseModel<int>
    {
        [Required]
        public string Type { get; set; }

        public string Comment { get; set; }

        public int InsurancePolicyId { get; set; }

        public virtual InsurancePolicy InsurancePolicy { get; set; }
    }
}
