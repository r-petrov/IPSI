namespace IPSI.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using IPSI.Data.Common.Models;

    public class Customer : BaseModel<int>
    {
        private const int PINMaxLength = 15;

        public Customer()
        {
            this.InsurancePolicies = new HashSet<InsurancePolicy>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(PINMaxLength)]
        public string PIN { get; set; }

        public bool IsIndividual { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }

        // TODO make Email property non-required
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }

        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Address { get; set; }

        public virtual ICollection<InsurancePolicy> InsurancePolicies { get; set; }
    }
}
