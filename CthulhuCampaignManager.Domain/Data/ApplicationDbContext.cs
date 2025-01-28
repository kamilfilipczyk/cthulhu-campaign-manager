using Microsoft.EntityFrameworkCore;
using System;

namespace CthulhuCampaignManager.Domain.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<PlayerCharacterEntity> PlayerCharacters { get; set; }
        public DbSet<SessionEntity> Sessions { get; set; }
        public DbSet<CampaignEntity> Campaigns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var exampleDate = new DateTime(2025, 1, 1);

            // Seed Campaigns
            modelBuilder.Entity<CampaignEntity>().HasData(
                new CampaignEntity
                {
                    Id = 1,
                    Title = "Cienie w Mroku",
                    Description = "Grupa śmiałków bada tajemnicze zjawiska w opuszczonym miasteczku w Nowej Anglii.",
                    CreationDate = exampleDate,
                    Status = Status.Ongoing
                },
                new CampaignEntity
                {
                    Id = 2,
                    Title = "Przebudzenie Starożytnych",
                    Description = "Poszukiwanie zakazanej wiedzy prowadzi do odkrycia nieznanych mocy, które mogą zmienić świat.",
                    CreationDate = exampleDate.AddDays(10),
                    Status = Status.Ongoing
                },
                new CampaignEntity
                {
                    Id = 3,
                    Title = "Zatraceni w Ciemności",
                    Description = "Grupa badaczy odkrywa niebezpieczne tajemnice w głębinach dżungli na Dalekim Wschodzie.",
                    CreationDate = exampleDate.AddDays(15),
                    Status = Status.Ongoing
                }
            );

            // Seed Player Characters (3 characters per campaign)
            modelBuilder.Entity<PlayerCharacterEntity>().HasData(
                // Campaign 1: Cienie w Mroku
                new PlayerCharacterEntity
                {
                    Id = 1,
                    Name = "Johnathan Harker",
                    Age = 35,
                    Profession = Profession.Detective,
                    Description = "Zdeterminowany detektyw, który ściga tajemnicze zbrodnie w małych miasteczkach.",
                    Status = Status.Ongoing,
                    CampaignId = 1
                },
                new PlayerCharacterEntity
                {
                    Id = 2,
                    Name = "Eleanor Griffith",
                    Age = 28,
                    Profession = Profession.Archeologist,
                    Description = "Młoda archeolog badająca tajemnicze ruiny, aby odkryć ich historię.",
                    Status = Status.Ongoing,
                    CampaignId = 1
                },
                new PlayerCharacterEntity
                {
                    Id = 3,
                    Name = "Harry Stone",
                    Age = 42,
                    Profession = Profession.PoliceOfficer,
                    Description = "Doświadczony oficer policji, który walczy z korupcją i przestępczością.",
                    Status = Status.Ongoing,
                    CampaignId = 1
                },

                // Campaign 2: Przebudzenie Starożytnych
                new PlayerCharacterEntity
                {
                    Id = 4,
                    Name = "Lydia Sykes",
                    Age = 38,
                    Profession = Profession.Archeologist,
                    Description = "Ekspertka w dziedzinie starożytnych cywilizacji, szukająca zapomnianych tajemnic.",
                    Status = Status.Ongoing,
                    CampaignId = 2
                },
                new PlayerCharacterEntity
                {
                    Id = 5,
                    Name = "Michał Kowalski",
                    Age = 33,
                    Profession = Profession.PoliceOfficer,
                    Description = "Detektyw w Polsce, badający sprawy związane z nieznanymi rytuałami.",
                    Status = Status.Ongoing,
                    CampaignId = 2
                },
                new PlayerCharacterEntity
                {
                    Id = 6,
                    Name = "Victor Hawke",
                    Age = 50,
                    Profession = Profession.Detective,
                    Description = "Weteran detektyw, który stawia czoła niewyjaśnionym zjawiskom.",
                    Status = Status.Ongoing,
                    CampaignId = 2
                },

                // Campaign 3: Zatraceni w Ciemności
                new PlayerCharacterEntity
                {
                    Id = 7,
                    Name = "Alice Hunter",
                    Age = 29,
                    Profession = Profession.Detective,
                    Description = "Ambitna detektywka badająca tajemnicze zaginięcia w tropikalnych lasach.",
                    Status = Status.Ongoing,
                    CampaignId = 3
                },
                new PlayerCharacterEntity
                {
                    Id = 8,
                    Name = "Samuel Adams",
                    Age = 40,
                    Profession = Profession.PoliceOfficer,
                    Description = "Oficer, który nie wierzy w legendy, ale staje się świadkiem nieznanych sił.",
                    Status = Status.Ongoing,
                    CampaignId = 3
                },
                new PlayerCharacterEntity
                {
                    Id = 9,
                    Name = "Edmund Hawthorne",
                    Age = 55,
                    Profession = Profession.Archeologist,
                    Description = "Profesor archeologii, który bada nieznane cywilizacje i wierzenia.",
                    Status = Status.Ongoing,
                    CampaignId = 3
                }
            );

            // Seed Sessions (3 sessions per campaign)
            modelBuilder.Entity<SessionEntity>().HasData(
                // Campaign 1: Cienie w Mroku
                new SessionEntity
                {
                    Id = 1,
                    CampaignId = 1,
                    Date = exampleDate,
                    Description = "Pierwsze spotkanie w miasteczku Arkham. Dochodzi do odkrycia mrocznej tajemnicy."
                },
                new SessionEntity
                {
                    Id = 2,
                    CampaignId = 1,
                    Date = exampleDate.AddDays(1),
                    Description = "Grupa bada sekrety w piwnicy starego domu. Nieoczekiwane spotkanie z nieznanymi siłami."
                },
                new SessionEntity
                {
                    Id = 3,
                    CampaignId = 1,
                    Date = exampleDate.AddDays(2),
                    Description = "Kolejna noc w Arkham. Grupa bada coraz bardziej niepokojące zjawiska w miasteczku."
                },

                // Campaign 2: Przebudzenie Starożytnych
                new SessionEntity
                {
                    Id = 4,
                    CampaignId = 2,
                    Date = exampleDate.AddDays(12),
                    Description = "Badacze odkrywają zapomniane ruiny w Egipcie. Wkrótce zbliżają się do przeklętego miejsca."
                },
                new SessionEntity
                {
                    Id = 5,
                    CampaignId = 2,
                    Date = exampleDate.AddDays(13),
                    Description = "Grupa stawia czoła pradawnym strażnikom, którzy bronią nieznanej mocy."
                },
                new SessionEntity
                {
                    Id = 6,
                    CampaignId = 2,
                    Date = exampleDate.AddDays(14),
                    Description = "Eksperymenty w laboratorium ujawniają zbyt dużo. Niewyjaśnione zjawiska zaczynają się nasilać."
                },

                // Campaign 3: Zatraceni w Ciemności
                new SessionEntity
                {
                    Id = 7,
                    CampaignId = 3,
                    Date = exampleDate.AddDays(16),
                    Description = "Grupa wyrusza na wyprawę do dżungli w celu znalezienia zaginionych badaczy."
                },
                new SessionEntity
                {
                    Id = 8,
                    CampaignId = 3,
                    Date = exampleDate.AddDays(17),
                    Description = "Badacze natrafiają na nieznane plemię i stają się świadkami tajemniczych rytuałów."
                },
                new SessionEntity
                {
                    Id = 9,
                    CampaignId = 3,
                    Date = exampleDate.AddDays(18),
                    Description = "Zespół zostaje otoczony przez nieznane siły. Nadchodzi czas decyzji o przetrwaniu."
                }
            );
        }
    }
}
