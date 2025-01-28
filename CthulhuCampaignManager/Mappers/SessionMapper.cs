using CthulhuCampaignManager.Domain.Data;
using CthulhuCampaignManager.Models;

namespace CthulhuCampaignManager.Mappers
{
    public class SessionMapper
    {
        public static SessionEntity MapFromEntity(SessionEntity entity)
        {
            return new SessionEntity()
            {
                Id = entity.Id,
                CampaignId = entity.CampaignId,
                Date = entity.Date,
                Description = entity.Description
            };
        }

        public static SessionViewModel MapToEntity(SessionViewModel model)
        {
            return new SessionViewModel()
            {
                Id = model.Id,
                CampaignId = model.CampaignId,
                Date = model.Date,
                Description = model.Description
            };
        }
    }
}
