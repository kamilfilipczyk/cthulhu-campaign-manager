using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CthulhuCampaignManager.Migrations
{
    /// <inheritdoc />
    public partial class SeedWithDummyValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Campaigns",
                columns: new[] { "CampaignId", "Creation_date", "Description", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupa śmiałków bada tajemnicze zjawiska w opuszczonym miasteczku w Nowej Anglii.", 0, "Cienie w Mroku" },
                    { 2, new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poszukiwanie zakazanej wiedzy prowadzi do odkrycia nieznanych mocy, które mogą zmienić świat.", 0, "Przebudzenie Starożytnych" },
                    { 3, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupa badaczy odkrywa niebezpieczne tajemnice w głębinach dżungli na Dalekim Wschodzie.", 0, "Zatraceni w Ciemności" }
                });

            migrationBuilder.InsertData(
                table: "PlayerCharacters",
                columns: new[] { "PlayerCharacterId", "Age", "CampaignId", "Description", "Name", "Profession", "Status" },
                values: new object[,]
                {
                    { 1, 35, 1, "Zdeterminowany detektyw, który ściga tajemnicze zbrodnie w małych miasteczkach.", "Johnathan Harker", 0, 0 },
                    { 2, 28, 1, "Młoda archeolog badająca tajemnicze ruiny, aby odkryć ich historię.", "Eleanor Griffith", 2, 0 },
                    { 3, 42, 1, "Doświadczony oficer policji, który walczy z korupcją i przestępczością.", "Harry Stone", 1, 0 },
                    { 4, 38, 2, "Ekspertka w dziedzinie starożytnych cywilizacji, szukająca zapomnianych tajemnic.", "Lydia Sykes", 2, 0 },
                    { 5, 33, 2, "Detektyw w Polsce, badający sprawy związane z nieznanymi rytuałami.", "Michał Kowalski", 1, 0 },
                    { 6, 50, 2, "Weteran detektyw, który stawia czoła niewyjaśnionym zjawiskom.", "Victor Hawke", 0, 0 },
                    { 7, 29, 3, "Ambitna detektywka badająca tajemnicze zaginięcia w tropikalnych lasach.", "Alice Hunter", 0, 0 },
                    { 8, 40, 3, "Oficer, który nie wierzy w legendy, ale staje się świadkiem nieznanych sił.", "Samuel Adams", 1, 0 },
                    { 9, 55, 3, "Profesor archeologii, który bada nieznane cywilizacje i wierzenia.", "Edmund Hawthorne", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "SessionId", "CampaignId", "Date", "Description" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pierwsze spotkanie w miasteczku Arkham. Dochodzi do odkrycia mrocznej tajemnicy." },
                    { 2, 1, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupa bada sekrety w piwnicy starego domu. Nieoczekiwane spotkanie z nieznanymi siłami." },
                    { 3, 1, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kolejna noc w Arkham. Grupa bada coraz bardziej niepokojące zjawiska w miasteczku." },
                    { 4, 2, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Badacze odkrywają zapomniane ruiny w Egipcie. Wkrótce zbliżają się do przeklętego miejsca." },
                    { 5, 2, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupa stawia czoła pradawnym strażnikom, którzy bronią nieznanej mocy." },
                    { 6, 2, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eksperymenty w laboratorium ujawniają zbyt dużo. Niewyjaśnione zjawiska zaczynają się nasilać." },
                    { 7, 3, new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupa wyrusza na wyprawę do dżungli w celu znalezienia zaginionych badaczy." },
                    { 8, 3, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Badacze natrafiają na nieznane plemię i stają się świadkami tajemniczych rytuałów." },
                    { 9, 3, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zespół zostaje otoczony przez nieznane siły. Nadchodzi czas decyzji o przetrwaniu." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayerCharacters",
                keyColumn: "PlayerCharacterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlayerCharacters",
                keyColumn: "PlayerCharacterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlayerCharacters",
                keyColumn: "PlayerCharacterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlayerCharacters",
                keyColumn: "PlayerCharacterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PlayerCharacters",
                keyColumn: "PlayerCharacterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PlayerCharacters",
                keyColumn: "PlayerCharacterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PlayerCharacters",
                keyColumn: "PlayerCharacterId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PlayerCharacters",
                keyColumn: "PlayerCharacterId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PlayerCharacters",
                keyColumn: "PlayerCharacterId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Campaigns",
                keyColumn: "CampaignId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Campaigns",
                keyColumn: "CampaignId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Campaigns",
                keyColumn: "CampaignId",
                keyValue: 3);
        }
    }
}
