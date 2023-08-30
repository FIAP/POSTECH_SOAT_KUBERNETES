using KubernetesRESTful.Infra;
using Microsoft.AspNetCore.Mvc;

namespace KubernetesRESTful.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KubernetesController : ControllerBase
    {


        private readonly ILogger<KubernetesController> _logger;
        private readonly KubernetesLib _kubernetesLib;

        public KubernetesController(ILogger<KubernetesController> logger, KubernetesLib kubernetesLib)
        {
            _logger = logger;
            _kubernetesLib = kubernetesLib;
        }

        [HttpGet("BuscarEventos")]
        public IActionResult Get()
        {
            return Ok(_kubernetesLib.GetEvents());
        }

        [HttpGet("BuscarDescricaoDePod")]
        public IActionResult Get(string podName)
        {
            return Ok(_kubernetesLib.GetPodDescription(podName));
        }

        [HttpGet("BuscarPods")]
        public IActionResult GetPods()
        {
            return Ok(_kubernetesLib.GetPods());
        }

        [HttpGet("BuscarServices")]
        public IActionResult GetServices()
        {
            return Ok(_kubernetesLib.GetServices());
        }

        [HttpGet("BuscarNomeDeContainers")]
        public IActionResult GetContainerName(string podName)
        {
            return Ok(_kubernetesLib.GetContainerName(podName));
        }

        [HttpGet("BuscarServiceDetails")]
        public IActionResult GetPodServiceDetails(string serviceName)
        {
            return Ok(_kubernetesLib.GetPodServiceDetails(serviceName));
        }

    }
}