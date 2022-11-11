using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ItemsDisplay.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "AttackType", "Attribute", "Description", "ImgURL", "Name" },
                values: new object[,]
                {
                    { 5, "Ranged", "Agility", "A splintered fragment of the same primordial power as the Ancients themselves, Zet the Arc Warden has pledged to see the clash between Radiant and Dire finally end. Assault lone enemies with fluxing energy, or distort space to generate a protective field around allies. Summon a Spark Wraith to patrol an area for enemies to infuse with harmful magic, then create a double of Zet, items and all, to overwhelm your foes.", "https://lh3.googleusercontent.com/PpOVTM88AYFgImSba_yF5UOF2hS75Cue-9dx9bWcjhDZgBeoPAwMBNH2XQW6CBeezHQ2fY9zfFFnnpbcHoEmmrTBO-wWzfvJQC3o7muh2OjLIx33TTVQKmdvIS5y9cosJnLO8Sm-nQ=w2400", "Arc Warden" },
                    { 6, "Melee", "Strength", "One after another, Axe cuts down his foes. Marching ahead of his team, he locks his enemies in battle then counters their blows with a deadly spin of his weapon. Slamming his culling blade through a weakened enemy, he is always charging onward.", "https://lh3.googleusercontent.com/oUTnwEbx0xPlPVRBikCWZD0-Ba0wup0exk0LVn1g3tjja-cZ3o9OutuOopGbanP01ACqbaxDZy5TpoFWpE-IkSwhVpyFzgrgRekcnUtaJIUm-zj7ghvghbhidO_uE9Z7Xt_zuIbcFw=w2400", "Axe" },
                    { 7, "Ranged", "Intelligence", "Bane brings terror to his enemies with his arsenal of disabling abilities. Whether trapping a foe within a contagious nightmare, or gripping an enemy in place, he gives allies all the time they need to slay their enemy.", "https://lh3.googleusercontent.com/JZWgMILBfdrO3K2-fy1f3ebg80L1prQ10H9D2lGYv5W0s88zgX21Mvc6Hwk8r_f10X8cCU1pkGW-XU1IB7fr3OyNbxbxJ_tmwwfvCfTTkxhusipJYM_UFdjt6ODQBUPUJ4eDPS8VUA=w2400", "Bane" },
                    { 8, "Ranged", "Intelligence", "Once he takes to the skies, Batrider can strike from any direction. Snatching a foe with his lasso, he soars above the treetops, pulling his prey through a trail of flame as he drags them before his merciless allies.", "https://lh3.googleusercontent.com/fkeYPDMsqvczU9bE_mDh7NfCG5lnIKHxgGa83KLnztLzJKCw2CC4D_4xp1NAzC66wFGZcQOFCyjtq_tfHKNj-dCdPwHdjdA8togr53YANrfAJlZ9xIjaptB9zK4xArV3tvbJpkxREw=w2400", "Batrider" },
                    { 9, "Melee", "Strength", "Summoning a poison-spitting boar and a scouting hawk to aid his hunt, Beastmaster never stalks the battlefield unprepared. Chopping through the forest with his axes, his stunning roar opens the way for his allies to devastate enemies.", "https://lh3.googleusercontent.com/ytZUKh7bpb4dR6Lx3nj146B7rqwNsoZ0oecd4kDFZUtV4LtVPJ0vjWdmWUn9pgx7ua8J9V1RjL03Ip8t-RvkRVUT-3vqCHummu-Kq_HJ909FFuOMOHeIZVcwy1AljF5h6u5o2ntM0Q=w2400", "Beastmaster" },
                    { 10, "Melee", "Agility", "Bloodseeker forces difficult decisions on his enemies. Able to drive his foes to a retreat by bathing a large area with a damaging ritual, his gruesome ultimate asks his opponents to hold still, or die.", "https://lh3.googleusercontent.com/EhxOIuZUNPJHxA2s_9yQjlqaCgWnFrLpEurNLvr_3xJpgoXCph30X53HKSKYkwRBQxwjqhTAgTsUtOL6t93op54LEM8FnkMB3_nSf0vMJZS_IUCBRORCbv6ohka88Dt46SfPE-6ilQ=w2400", "Bloodseeker" },
                    { 11, "Melee", "Agility", "Sneaking invisibly at the heels of his enemies, Bounty Hunter is always keeping track of his foes. Whenever one of his targets falls in battle, he and his allies stand to make quite a profit.", "https://lh3.googleusercontent.com/qVj6cvcuFt-wox9nlg9iJwsQbaLj5ld-ICe6c70aw0lDs9z3lIGul7O7XRSMXzppone9gZnhMDivA9LaVjH1UwYPMaGdWtuStqs3iaZlMvULBGDZImMmEoYuT3ftFL5ravkFYnu-CA=w2400", "Bounty Hunter" },
                    { 12, "Melee", "Strength", "A fearsome fighter in any situation, Brewmaster can turn the tide of battle by splitting into three elemental spirits, each with their own unique abilities. When not divided, he brings drunken chaos to his foes with slowing claps and powerful swings of his staff.", "https://lh3.googleusercontent.com/JWgYxAT_EWqRs2JJrTbG-EVPT82bevxjK7Kd1SNS86_o1RjkJ6G5NzDGHswSit6VtvL-oRedv_2V7OefIxoe24KlLNGOkbOZFLHJ71oV2QRVCpLmO6V19l5_037FXDDTNDf0ISBkkQ=w2400", "Brewmaster" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
