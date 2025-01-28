using CthulhuCampaignManager.Domain.Data;
using CthulhuCampaignManager.Models;

namespace CthulhuCampaignManager.Mappers
{
    public class CampaignMapper
    {
        public static CampaignViewModel MapFromEntity(CampaignEntity entity)
        {
            return new CampaignViewModel()
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                CreationDate = entity.CreationDate,
                Status = entity.Status
            };
        }

        public static CampaignEntity MapToEntity(CampaignViewModel model)
        {
            return new CampaignEntity()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                CreationDate = model.CreationDate,
                Status = model.Status
            };
        }
    }
}
