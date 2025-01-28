using CthulhuCampaignManager.Domain.Data;
using CthulhuCampaignManager.Models;

namespace CthulhuCampaignManager.Mappers
{
    public class PlayerCharacterMapper
    {
        public static PlayerCharacterEntity MapFromEntity(PlayerCharacterEntity entity)
        {
            return new PlayerCharacterEntity()
            {
                Id = entity.Id,
                Name = entity.Name,
                Age = entity.Age,
                Profession = entity.Profession,
                Description = entity.Description,
                Status = entity.Status,
                CampaignId = entity.CampaignId
            };
        }

        public static PlayerCharacterViewModel MapToEntity(PlayerCharacterViewModel model)
        {
            return new PlayerCharacterViewModel()
            {
                Id = model.Id,
                Name = model.Name,
                Age = model.Age,
                Profession = model.Profession,
                Description = model.Description,
                Status = model.Status,
                CampaignId = model.CampaignId
            };
        }
    }
}
