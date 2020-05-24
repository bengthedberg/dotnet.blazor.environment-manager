using EnvironmentManager.Client.Services;
using EnvironmentManager.Core;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace EnvironmentManager.Client.Pages
{
    public partial class EnvironmentDetail
    {
        [Inject]
        private IEnvironmentService environmentOverview { get; set; }
        [Parameter]
        public string EnvironmentId { get; set; }

        private Environment environment;

        protected override async Task OnInitializedAsync()
        {
            environment = await environmentOverview.GetEnvironmentAsync(int.Parse(EnvironmentId));
        }
    }
}
