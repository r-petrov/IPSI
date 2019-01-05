namespace IPSI.Services.Models.InputModels.Company
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class CreateCompanyInputModel
    {
        [Required]
        public string Name { get; set; }

        public string Broker { get; set; }
    }
}
