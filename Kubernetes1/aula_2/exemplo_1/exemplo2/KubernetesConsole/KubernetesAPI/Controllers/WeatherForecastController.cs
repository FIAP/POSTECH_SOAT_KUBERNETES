using Microsoft.AspNetCore.Mvc;

namespace KubernetesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KubernetesMonitoringController : ControllerBase
    {       

        private readonly ILogger<KubernetesMonitoringController> _logger;

        public KubernetesMonitoringController(ILogger<KubernetesMonitoringController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = new Infra.KubernetesAPI();
            return Ok(await result.GetPodsAsync());
        }
    }
}