using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CreditInfo.CandidateExam.Core.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CreditInfo.CandidateExam.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractsController : ControllerBase
    {
        private readonly ILogger<ContractsController> _logger;

        public ContractsController(ILogger<ContractsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IndividualContractModel> Get(Guid id)
        {
            return await Task.FromResult(new IndividualContractModel());
        }
    }
}
