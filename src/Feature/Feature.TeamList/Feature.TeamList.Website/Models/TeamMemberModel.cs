using Sitecore.Data.Items;

namespace Feature.TeamList.Website.Models
{
    public class TeamMemberModel
    {
        public Item Item { get; set; }

        public TeamMemberModel(Item castItem)
        {
            Item = castItem;
        }
    }
}