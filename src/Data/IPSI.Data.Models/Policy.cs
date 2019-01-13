namespace IPSI.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using IPSI.Data.Common.Attributes;
    using IPSI.Data.Common.Models;
    using IPSI.Data.Models.Enums;

    public class Policy : BaseModel<int>, IValidatableObject
    {
        public Policy()
        {
            this.Payments = new HashSet<Payment>();
            this.Damages = new HashSet<Damage>();
        }

        [Required]
        public string PolicyNumber { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public PolicyStatuses Status { get; set; }

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

        public int InsuredPropertyId { get; set; }

        public virtual InsuredProperty InsuredProperty { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<Damage> Damages { get; set; }

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
