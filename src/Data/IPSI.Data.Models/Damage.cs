namespace IPSI.Data.Models
{
    using System;

    using IPSI.Data.Common.Models;

    public class Damage : BaseModel<int>
    {
        public string Type { get; set; }

        public decimal Amount { get; set; }

        public DateTime OccurenceDate { get; set; }

        public bool IsTotal { get; set; }

        public string Note { get; set; }
    }
}
