using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CreditInfo.CandidateExam.Core.Managers;
using CreditInfo.CandidateExam.Core.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CreditInfo.CandidateExam.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractsController : ControllerBase
    {
        private readonly IIndividualContractManager _individualContractManager;
        private readonly ILogger<ContractsController> _logger;

        public ContractsController(IIndividualContractManager individualContractManager, ILogger<ContractsController> logger)
        {
            _individualContractManager = individualContractManager;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IndividualContractModel>> Get(string nationalID)
        {
            var result = await _individualContractManager.GetAsync(new IdentificationNumbersModel(nationalID));

            if (result is null)
            {
                return NotFound();
            }

            return result;
        }
    }
}
