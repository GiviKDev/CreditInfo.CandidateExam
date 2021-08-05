namespace CreditInfo.CandidateExam.Core.Models
{
    public class IdentificationNumbersModel
    {
        public string NationalID { get; set; }

        public IdentificationNumbersModel() { }

        public IdentificationNumbersModel(string nationalID) => NationalID = nationalID;
    }
}
