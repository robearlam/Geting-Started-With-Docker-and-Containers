using Feature.TeamList.Website.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace Feature.TeamList.Website.Controllers
{
    public class TeamListController : StandardController
    {
        private readonly ITeamListRepository _repository;

        public TeamListController(ITeamListRepository repository)
        {
            _repository = repository;
        }

        protected override object GetModel()
        {
            return _repository.GetModel();
        }
    }
}