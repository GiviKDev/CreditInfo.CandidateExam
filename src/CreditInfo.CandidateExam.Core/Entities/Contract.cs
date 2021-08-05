using System;
using System.Collections.Generic;

using CreditInfo.CandidateExam.Core.Enums;

namespace CreditInfo.CandidateExam.Core.Entities
{
    public class Contract
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public string ContractCode { get; set; }

        public PhaseOfContract PhaseOfContract { get; set; }

        public Amount OriginalAmount { get; set; }

        public Amount InstallmentAmount { get; set; }

        public Amount CurrentBalance { get; set; }

        public Amount OverdueBalance { get; set; }

        public DateTime DateOfLastPayment { get; set; }

        public DateTime NextPaymentDate { get; set; }

        public DateTime DateAccountOpened { get; set; }

        public DateTime RealEndDate { get; set; }

        public virtual ICollection<Individual> Individuals { get; set; } = new HashSet<Individual>();

        public virtual ICollection<SubjectRole> SubjectRoles { get; set; } = new HashSet<SubjectRole>();
    }
}
