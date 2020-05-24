using EnvironmentManager.Core;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvironmentManager.Client.Services
{
    public class EnvironmentServiceMock : IEnvironmentService
    {
        private List<Environment> e = new List<Environment>()
            {
                new Environment()
                {
                    EnvironmentId = 1,
                    Name = "EnvironmentA",
                    Description = "Development",
                    Owner = Group.Finance
                },
                new Environment()
                {
                    EnvironmentId = 2,
                    Name = "EnvironmentX",
                    Description = "Integration",
                    Owner = Group.ProductA
                },
                new Environment()
                {
                    EnvironmentId = 2,
                    Name = "EnvironmentY",
                    Description = "User Acceptance Testing",
                    Owner = Group.ProductA
                },
                new Environment()
                {
                    EnvironmentId = 2,
                    Name = "EnvironmentZ",
                    Description = "Production",
                    Owner = Group.ProductB
                }
            };

        public async Task<Environment> GetEnvironmentAsync(int id)
        {
            return await Task.FromResult<Environment>(e.FirstOrDefault(e => e.EnvironmentId == id));
        }

        public async Task<IEnumerable<Environment>> GetEnvironmentsAsync()
        {

            return await Task.FromResult<IEnumerable<Environment>>(e);
        }

    }
}
