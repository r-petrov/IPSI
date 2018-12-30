using IPSI.Data.Common.Models;

namespace IPSI.Data.Models
{
    public class CompanyInsurance : BaseModel<int>
    {
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public int InsuranceId { get; set; }

        public virtual Insurance Insurance { get; set; }
    }
}
