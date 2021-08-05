using System;
using System.Collections.Generic;

using CreditInfo.CandidateExam.Core.Enums;

namespace CreditInfo.CandidateExam.Core.Entities
{
    public class Individual
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public string CustomerCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public IdentificationNumbers IdentificationNumbers { get; set; }

        public virtual ICollection<IndividualContract> IndividualContracts { get; set; } = new HashSet<IndividualContract>();
    }
}
