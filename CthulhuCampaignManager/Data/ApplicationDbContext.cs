using Microsoft.EntityFrameworkCore;

namespace CthulhuCampaignManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<PlayerCharacterEntity> PlayerCharacters { get; set; }
        public DbSet<SessionEntity> Sessions { get; set; }
        public DbSet<CampaignEntity> Campaigns { get; set; }
    }
}
