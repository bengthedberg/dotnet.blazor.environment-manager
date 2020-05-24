using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnvironmentManager.Core
{
    public interface IEnvironmentRepository
    {
        Task<IEnumerable<Environment>> GetAllEnvironmentsAsync();
        Task<Environment> GetEnvironmentByIdAsync(int environmentId);
    }
}
