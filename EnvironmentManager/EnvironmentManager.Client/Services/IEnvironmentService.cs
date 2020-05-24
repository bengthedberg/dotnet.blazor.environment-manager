using EnvironmentManager.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnvironmentManager.Client.Services
{
    public interface IEnvironmentService
    {
        Task<IEnumerable<Environment>> GetEnvironmentsAsync();
        Task<Environment> GetEnvironmentAsync(int id);
    }
}
