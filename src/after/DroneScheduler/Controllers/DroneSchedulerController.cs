using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DroneDelivery.Common;
using DroneDelivery.Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DroneScheduler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DroneSchedulerController : ControllerBase
    {
        private readonly ILogger<DroneSchedulerController> _logger;

        public DroneSchedulerController(ILogger<DroneSchedulerController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public Task<string> GetDroneIdAsync(Delivery deliveryRequest)
        {
            //Access common data store e.g. SQL Azure
            Utility.DoWork(50);
            return Task.FromResult("test-drone-id");
        }

        [HttpPost("{droneId}")]
        public Task<bool> ScheduleDeliveryAsync(Delivery deliveryRequest)
        {
            //Access common datastore e.g. SQL Azure
            Utility.DoWork(50);
            return Task.FromResult(true);
        }
    }
}
