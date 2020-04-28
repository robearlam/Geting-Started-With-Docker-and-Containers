using Sitecore.XA.Foundation.Mvc.Models;
using System.Collections.Generic;

namespace Feature.TeamList.Website.Models
{
    public class TeamListModel : RenderingModelBase
    {
        public List<TeamMemberModel> Team { get; set; }
    }
}