using System.Threading.Tasks;
using DroneDelivery.Common.Models;

namespace DroneDelivery_after.Services
{
    public interface IRequestProcessor
    {
        Task<bool> ProcessDeliveryRequestAsync(Delivery deliveryRequest);
    }
}
