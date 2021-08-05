using System;

using CreditInfo.CandidateExam.Core.Enums;

namespace CreditInfo.CandidateExam.Core.Models
{
    public class IndividualModel
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CustomerCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public IdentificationNumbersModel IdentificationNumbers { get; set; }
    }
}
