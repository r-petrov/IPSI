namespace IPSI.Data.Models
{
    using System;

    using IPSI.Data.Common.Attributes;
    using IPSI.Data.Common.Models;

    public class Payment : BaseModel<int>
    {
        [MinValue(1)]
        public int PaymentNumber { get; set; }

        public DateTime MaturityDate { get; set; }

        public DateTime PaymentDate { get; set; }

        [MinValue(0)]
        public decimal GrossInsurancePremium { get; set; }

        [MinValue(0)]
        public decimal NetInsurancePremium { get; set; }

        [MinValue(0)]
        public decimal Commission { get; set; }

        [MinValue(0)]
        public decimal CommissionAmount => this.NetInsurancePremium * this.Commission;

        [MinValue(0)]
        public decimal DiscountOnCommission { get; set; }

        public int InsurancePolicyId { get; set; }

        public virtual Policy InsurancePolicy { get; set; }
    }
}
