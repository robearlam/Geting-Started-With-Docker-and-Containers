using Feature.TeamList.Website.Controllers;
using Feature.TeamList.Website.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Feature.TeamList.Website.Services
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ITeamListRepository, TeamListRepository>();
            serviceCollection.AddTransient<TeamListController>();
        }
    }
}