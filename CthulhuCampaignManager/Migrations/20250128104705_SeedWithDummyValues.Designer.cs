﻿// <auto-generated />
using System;
using CthulhuCampaignManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CthulhuCampaignManager.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250128104705_SeedWithDummyValues")]
    partial class SeedWithDummyValues
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("CthulhuCampaignManager.Data.CampaignEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("CampaignId");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("Creation_date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Campaigns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Grupa śmiałków bada tajemnicze zjawiska w opuszczonym miasteczku w Nowej Anglii.",
                            Status = 0,
                            Title = "Cienie w Mroku"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Poszukiwanie zakazanej wiedzy prowadzi do odkrycia nieznanych mocy, które mogą zmienić świat.",
                            Status = 0,
                            Title = "Przebudzenie Starożytnych"
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Grupa badaczy odkrywa niebezpieczne tajemnice w głębinach dżungli na Dalekim Wschodzie.",
                            Status = 0,
                            Title = "Zatraceni w Ciemności"
                        });
                });

            modelBuilder.Entity("CthulhuCampaignManager.Data.PlayerCharacterEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("PlayerCharacterId");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CampaignId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Profession")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.ToTable("PlayerCharacters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 35,
                            CampaignId = 1,
                            Description = "Zdeterminowany detektyw, który ściga tajemnicze zbrodnie w małych miasteczkach.",
                            Name = "Johnathan Harker",
                            Profession = 0,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 28,
                            CampaignId = 1,
                            Description = "Młoda archeolog badająca tajemnicze ruiny, aby odkryć ich historię.",
                            Name = "Eleanor Griffith",
                            Profession = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 42,
                            CampaignId = 1,
                            Description = "Doświadczony oficer policji, który walczy z korupcją i przestępczością.",
                            Name = "Harry Stone",
                            Profession = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            Age = 38,
                            CampaignId = 2,
                            Description = "Ekspertka w dziedzinie starożytnych cywilizacji, szukająca zapomnianych tajemnic.",
                            Name = "Lydia Sykes",
                            Profession = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            Age = 33,
                            CampaignId = 2,
                            Description = "Detektyw w Polsce, badający sprawy związane z nieznanymi rytuałami.",
                            Name = "Michał Kowalski",
                            Profession = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            Age = 50,
                            CampaignId = 2,
                            Description = "Weteran detektyw, który stawia czoła niewyjaśnionym zjawiskom.",
                            Name = "Victor Hawke",
                            Profession = 0,
                            Status = 0
                        },
                        new
                        {
                            Id = 7,
                            Age = 29,
                            CampaignId = 3,
                            Description = "Ambitna detektywka badająca tajemnicze zaginięcia w tropikalnych lasach.",
                            Name = "Alice Hunter",
                            Profession = 0,
                            Status = 0
                        },
                        new
                        {
                            Id = 8,
                            Age = 40,
                            CampaignId = 3,
                            Description = "Oficer, który nie wierzy w legendy, ale staje się świadkiem nieznanych sił.",
                            Name = "Samuel Adams",
                            Profession = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 9,
                            Age = 55,
                            CampaignId = 3,
                            Description = "Profesor archeologii, który bada nieznane cywilizacje i wierzenia.",
                            Name = "Edmund Hawthorne",
                            Profession = 2,
                            Status = 0
                        });
                });

            modelBuilder.Entity("CthulhuCampaignManager.Data.SessionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("SessionId");

                    b.Property<int>("CampaignId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CampaignId = 1,
                            Date = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pierwsze spotkanie w miasteczku Arkham. Dochodzi do odkrycia mrocznej tajemnicy."
                        },
                        new
                        {
                            Id = 2,
                            CampaignId = 1,
                            Date = new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Grupa bada sekrety w piwnicy starego domu. Nieoczekiwane spotkanie z nieznanymi siłami."
                        },
                        new
                        {
                            Id = 3,
                            CampaignId = 1,
                            Date = new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Kolejna noc w Arkham. Grupa bada coraz bardziej niepokojące zjawiska w miasteczku."
                        },
                        new
                        {
                            Id = 4,
                            CampaignId = 2,
                            Date = new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Badacze odkrywają zapomniane ruiny w Egipcie. Wkrótce zbliżają się do przeklętego miejsca."
                        },
                        new
                        {
                            Id = 5,
                            CampaignId = 2,
                            Date = new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Grupa stawia czoła pradawnym strażnikom, którzy bronią nieznanej mocy."
                        },
                        new
                        {
                            Id = 6,
                            CampaignId = 2,
                            Date = new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Eksperymenty w laboratorium ujawniają zbyt dużo. Niewyjaśnione zjawiska zaczynają się nasilać."
                        },
                        new
                        {
                            Id = 7,
                            CampaignId = 3,
                            Date = new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Grupa wyrusza na wyprawę do dżungli w celu znalezienia zaginionych badaczy."
                        },
                        new
                        {
                            Id = 8,
                            CampaignId = 3,
                            Date = new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Badacze natrafiają na nieznane plemię i stają się świadkami tajemniczych rytuałów."
                        },
                        new
                        {
                            Id = 9,
                            CampaignId = 3,
                            Date = new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Zespół zostaje otoczony przez nieznane siły. Nadchodzi czas decyzji o przetrwaniu."
                        });
                });

            modelBuilder.Entity("CthulhuCampaignManager.Data.PlayerCharacterEntity", b =>
                {
                    b.HasOne("CthulhuCampaignManager.Data.CampaignEntity", "Campaign")
                        .WithMany("PlayerCharacters")
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");
                });

            modelBuilder.Entity("CthulhuCampaignManager.Data.SessionEntity", b =>
                {
                    b.HasOne("CthulhuCampaignManager.Data.CampaignEntity", "Campaign")
                        .WithMany("Sessions")
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");
                });

            modelBuilder.Entity("CthulhuCampaignManager.Data.CampaignEntity", b =>
                {
                    b.Navigation("PlayerCharacters");

                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
