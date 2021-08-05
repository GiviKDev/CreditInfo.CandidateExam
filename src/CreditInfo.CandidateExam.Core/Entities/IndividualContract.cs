using System;

using CreditInfo.CandidateExam.Core.Enums;

namespace CreditInfo.CandidateExam.Core.Entities
{
    public class IndividualContract
    {
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public RoleOfCustomer RoleOfCustomer { get; set; }

        public Guid ContractId { get; set; }

        public virtual Contract Contract { get; set; }

        public Guid IndividualId { get; set; }

        public virtual Individual Individual { get; set; }
    }
}
