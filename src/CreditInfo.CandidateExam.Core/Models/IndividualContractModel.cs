using System;

using CreditInfo.CandidateExam.Core.Enums;

namespace CreditInfo.CandidateExam.Core.Models
{
    public class IndividualContractModel
    {
        public DateTime CreatedDate { get; set; } 

        public RoleOfCustomer RoleOfCustomer { get; set; }

        public Guid ContractId { get; set; }

        public virtual ContractModel Contract { get; set; }

        public Guid IndividualId { get; set; }

        public virtual IndividualModel Individual { get; set; }
    }
}
