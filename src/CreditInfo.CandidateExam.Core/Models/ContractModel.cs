using System;

using CreditInfo.CandidateExam.Core.Enums;

namespace CreditInfo.CandidateExam.Core.Models
{
    public class ContractModel
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ContractCode { get; set; }

        public PhaseOfContract PhaseOfContract { get; set; }

        public AmountModel OriginalAmount { get; set; }

        public AmountModel InstallmentAmount { get; set; }

        public AmountModel CurrentBalance { get; set; }

        public AmountModel OverdueBalance { get; set; }

        public DateTime DateOfLastPayment { get; set; }

        public DateTime NextPaymentDate { get; set; }

        public DateTime DateAccountOpened { get; set; }

        public DateTime RealEndDate { get; set; }
    }
}
