using DroneDelivery.Common.Models;
using System.Threading.Tasks;

namespace DroneDelivery_after.Services
{
    public interface IPackageProcessor
    {
        Task<PackageGen> CreatePackageAsync(PackageInfo packageInfo);
    }
}