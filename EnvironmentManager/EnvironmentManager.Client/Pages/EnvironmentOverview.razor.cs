using EnvironmentManager.Client.Services;
using EnvironmentManager.Core;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvironmentManager.Client.Pages
{
    public partial class EnvironmentOverview
    {
        [Inject]
        private IEnvironmentService environmentOverview { get; set; }

        private IEnumerable<Environment> environments;

        protected override async Task OnInitializedAsync()
        {
            environments = (await environmentOverview.GetEnvironmentsAsync()).ToList();
        }
    }
}
