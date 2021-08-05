using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using CreditInfo.CandidateExam.Core.Data;
using CreditInfo.CandidateExam.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CreditInfo.CandidateExam.Core.Managers
{
    public interface IIndividualContractManager
    {
        Task<IndividualContractModel> GetAsync(IdentificationNumbersModel model);
    }

    public class IndividualContractManager : IIndividualContractManager
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IndividualContractManager> _logger;

        public IndividualContractManager(ApplicationDbContext context, IMapper mapper, ILogger<IndividualContractManager> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IndividualContractModel> GetAsync(IdentificationNumbersModel model)
        {
            return await _context.IndividualContracts
                .AsNoTracking()
                .Where(t => t.Individual.IdentificationNumbers.NationalID == model.NationalID)
                .ProjectTo<IndividualContractModel>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
    }
}
