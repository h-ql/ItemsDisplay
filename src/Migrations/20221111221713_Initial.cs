using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ItemsDisplay.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Attribute = table.Column<string>(type: "TEXT", nullable: false),
                    AttackType = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImgURL = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "AttackType", "Attribute", "Description", "ImgURL", "Name" },
                values: new object[,]
                {
                    { 1, "Melee", "Strength", "Able to transform enemy attacks into self-healing, Abaddon can survive almost any assault. Shielding allies and launching his double-edged coil at a friend or foe, he is always ready to ride into the thick of battle.", "https://lh3.googleusercontent.com/2CYfQT9UPNNDUZteJfXzM-yBn9eIxdR_Dgw7hG6aG9iKCb_KTqzTOXMzYQCXzY7DPFfJkoBI8dmQMB6TIw9vL1gatEzk-SIip02j4FinBmNibF-HusTjbUh0veavNvLKF0jgbwmrag=w2400", "Abaddon" },
                    { 2, "Melee", "Strength", "Synthesizing extra resources from each and every kill, Alchemist has no trouble gathering the tools needed to destroy his foes. Ambushing enemies with corrosive acid and a host of unstable chemicals, he battles to ensure his greedy escapades can remain uninterrupted.", "https://lh3.googleusercontent.com/bLZS7hRhCDDvmBMkwxE-o_xZPcB_EqOM-WXwzPXOHOYVXS9WLEovCqcBOjAOziSBXiZMPA148K9xy641c8PrJ_UCiH5hDgqK2Vez_0rdCFatsmv4qnHCnLUHof0xyjfU1gcGK51oFQ=w2400", "Alchemist" },
                    { 3, "Ranged", "Intelligence", "Able to launch a powerful blast of damaging ice across the battlefield, Ancient Apparition threatens to shatter weakened enemies wherever they are. Slowing enemies as he enhances his allies' effectiveness in battle, he is a constant threat to his foes.", "https://lh3.googleusercontent.com/NEnrdtBkJJFCswj5htxDWR-EC7lozKAgTgV3QAtH6USldJ1FcpKsG4CwhgBUYVmWB-BxqhsH3iiXWlEMpSewdQ_SByMw3tND_WnSigDLrxisM1x3cko81ZVWebTq9oNnhfgKFYFPlw=w2400", "Ancient Apparition" },
                    { 4, "Melee", "Agility", "Should Anti-Mage have the opportunity to gather his full strength, few can stop his assaults. Draining mana from enemies with every strike or teleporting short distances to escape an ambush, cornering him is a challenge for any foe.", "https://lh3.googleusercontent.com/hxNLqoVUvqpYvZNyrINPVQQqr8DEHJJWdZjdpM89uqZnVodKiKcJIkhM7pnOhmc63wu01T_2RKGE9O1kSzxKkM4T8Ayj_cb7RgTghMypGCzPx7Gk_XFygxM6V8tvdkU6DHHm3qyeTQ=w2400", "Anti-Mage" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
