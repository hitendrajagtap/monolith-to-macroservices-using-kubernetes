using System.Threading.Tasks;
using DroneDelivery.Common;
using DroneDelivery.Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PackageProcessor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PackageProcessorController : ControllerBase
    {
        private readonly ILogger<PackageProcessorController> _logger;

        public PackageProcessorController(ILogger<PackageProcessorController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public Task<PackageGen> CreateAsync(PackageInfo packageInfo)
        {
            //Uses common data store e.g. SQL Azure tables
            Utility.DoWork(100);
            return Task.FromResult(new PackageGen { Id = packageInfo.PackageId });
        }
    }
}
