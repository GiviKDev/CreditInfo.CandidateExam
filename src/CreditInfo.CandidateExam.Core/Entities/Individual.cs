using System;

using CreditInfo.CandidateExam.Core.Enums;

namespace CreditInfo.CandidateExam.Core.Entities
{
    public class Individual
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public string CustomerCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public IdentificationNumbers IdentificationNumbers { get; set; }

        public Guid ContractId { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
