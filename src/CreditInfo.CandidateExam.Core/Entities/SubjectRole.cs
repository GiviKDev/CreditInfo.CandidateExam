using System;

using CreditInfo.CandidateExam.Core.Enums;

namespace CreditInfo.CandidateExam.Core.Entities
{
    public class SubjectRole
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public string CustomerCode { get; set; }

        public RoleOfCustomer RoleOfCustomer { get; set; }

        public Guid ContractId { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
