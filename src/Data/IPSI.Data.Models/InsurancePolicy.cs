using IPSI.Data.Common.Attributes;
using IPSI.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IPSI.Data.Models
{
    public class InsurancePolicy : BaseModel<int>, IValidatableObject
    {
        public InsurancePolicy()
        {
            this.Payments = new HashSet<Payment>();
            this.InsuredProperties = new HashSet<InsuredProperty>();
        }

        [Required]
        public string PolicyNumber { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [MinValue(1)]
        public int PaymentsCount { get; set; }

        [MinValue(1)]
        public int PaymentNumber { get; set; }

        [MinValue(0)]
        public decimal GrossInsurancePremium { get; set; }

        [MinValue(0)]
        public decimal PaidInsurancePremium { get; set; }

        public bool InsuredPropertyIncluded { get; set; }

        public int InsuranceId { get; set; }

        public virtual Insurance Insurance { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

        public virtual ICollection<InsuredProperty> InsuredProperties { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.IssueDate > this.StartDate)
            {
                yield return new ValidationResult($"{nameof(this.IssueDate)} should not be later than {nameof(this.StartDate)}.");
            }

            if (this.StartDate >= this.EndDate)
            {
                yield return new ValidationResult($"{nameof(this.StartDate)} should be earlier than {nameof(this.EndDate)}.");
            }
        }
    }
}
