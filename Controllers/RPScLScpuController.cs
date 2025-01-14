using Microsoft.AspNetCore.Mvc;
using Rock_Paper_Scissor_Lizard_Spock___CPU.Services;

namespace Rock_Paper_Scissor_Lizard_Spock___CPU.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPScLScpuController : ControllerBase
    {
        private readonly RPScLScpuService _cpuService;
        public RPScLScpuController(RPScLScpuService cpuService)
        {
            _cpuService = cpuService;
        }

        [HttpGet]
        public string GetCpuResponse()
        {
            return _cpuService.GetCpuResponse();
        }
    }
}