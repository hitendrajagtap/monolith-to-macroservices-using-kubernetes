using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using DroneDelivery.Common.Models;

namespace DroneDelivery_after.Services
{
    public class PackageServiceCaller : IPackageProcessor
    {
        private readonly HttpClient httpClient;

        public static string FunctionCode { get; set; }

        public PackageServiceCaller(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<PackageGen> CreatePackageAsync(PackageInfo packageInfo)
        {
            var result = await httpClient.PostAsJsonAsync(httpClient.BaseAddress, packageInfo);
            result.EnsureSuccessStatusCode();

            return new PackageGen { Id = packageInfo.PackageId };
        }
    }
}
