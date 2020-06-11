using System.Net.Http;
using System.Threading.Tasks;
using DroneDelivery.Common.Models;

namespace DroneDelivery_after.Services
{
    public class DroneServiceCaller : IDroneScheduler
    {
        private readonly HttpClient httpClient;

        public static string FunctionCode { get; set; }

        public DroneServiceCaller(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetDroneIdAsync(Delivery deliveryRequest)
        {
            var result = await httpClient.PostAsJsonAsync(httpClient.BaseAddress, deliveryRequest);
            result.EnsureSuccessStatusCode();
            return await result.Content.ReadAsStringAsync();

        }

        public async Task<bool> ScheduleDeliveryAsync(Delivery deliveryRequest, string droneId)
        {
            var result = await httpClient.PostAsJsonAsync($"httpClient.BaseAddress/{ droneId }", deliveryRequest);
            result.EnsureSuccessStatusCode();
            return true;
        }
    }
}
