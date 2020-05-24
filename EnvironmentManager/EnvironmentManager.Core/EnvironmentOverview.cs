using System.Collections.Generic;

namespace EnvironmentManager.Core
{
    public class EnvironmentOverview
    {
        IEnumerable<Environment> environments;

        public EnvironmentOverview() : this(new List<Environment>())
        {
        }

        public EnvironmentOverview(IEnumerable<Environment> environments)
        {
            this.environments = environments;
        }
    }
}
