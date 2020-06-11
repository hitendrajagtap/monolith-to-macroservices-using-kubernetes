using System.Threading.Tasks;
using DroneDelivery.Common.Models;

namespace DroneDelivery_after.Services
{
    public interface IDroneScheduler
    {
        Task<string> GetDroneIdAsync(Delivery deliveryRequest);
        Task<bool> ScheduleDeliveryAsync(Delivery deliveryRequest, string droneId);
    }
}
