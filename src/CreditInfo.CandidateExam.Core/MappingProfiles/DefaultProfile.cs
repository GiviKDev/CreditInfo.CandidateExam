
using AutoMapper;

using CreditInfo.CandidateExam.Core.Entities;
using CreditInfo.CandidateExam.Core.Models;

namespace CreditInfo.CandidateExam.Core.MappingProfiles
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            CreateMap<Amount, AmountModel>().ReverseMap();

            CreateMap<Contract, ContractModel>().ReverseMap();

            CreateMap<IdentificationNumbers, IdentificationNumbersModel>().ReverseMap();

            CreateMap<Individual, IndividualModel>().ReverseMap();

            CreateMap<IndividualContract, IndividualContractModel>().ReverseMap();
        }
    }
}
