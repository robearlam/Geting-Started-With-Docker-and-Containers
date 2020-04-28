using Feature.TeamList.Website.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace Feature.TeamList.Website.Repositories
{
    public class TeamListRepository : ModelRepository, ITeamListRepository
    {
        public override IRenderingModelBase GetModel()
        {
            var model = new TeamListModel
            {
                Team = GetCastList()
            };

            return model;
        }

        private List<TeamMemberModel> GetCastList()
        {
            if (Rendering.DataSourceItem != null)
            {
                return Rendering.DataSourceItem.Children.Select(x => new TeamMemberModel(x)).ToList();
            }
            return new List<TeamMemberModel>();
        }
    }
}