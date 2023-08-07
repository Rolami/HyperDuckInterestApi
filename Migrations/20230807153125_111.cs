using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HyperDuckInterestApi.Migrations
{
    /// <inheritdoc />
    public partial class _111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InterestLinks",
                columns: table => new
                {
                    InterestLinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkDescription = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
                    InterestURL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestLinks", x => x.InterestLinkId);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    InterestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.InterestId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "InterestLists",
                columns: table => new
                {
                    InterestListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fk_PersonId = table.Column<int>(type: "int", nullable: false),
                    Fk_InterestId = table.Column<int>(type: "int", nullable: false),
                    Fk_InterestLinkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestLists", x => x.InterestListId);
                    table.ForeignKey(
                        name: "FK_InterestLists_InterestLinks_Fk_InterestLinkId",
                        column: x => x.Fk_InterestLinkId,
                        principalTable: "InterestLinks",
                        principalColumn: "InterestLinkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterestLists_Interests_Fk_InterestId",
                        column: x => x.Fk_InterestId,
                        principalTable: "Interests",
                        principalColumn: "InterestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterestLists_Persons_Fk_PersonId",
                        column: x => x.Fk_PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "InterestLinks",
                columns: new[] { "InterestLinkId", "InterestURL", "LinkDescription" },
                values: new object[,]
                {
                    { 1, "http://youtube.com", "Praesent eu nulla at sem molestie" },
                    { 2, "http://walmart.com", "at," },
                    { 3, "https://guardian.co.uk", "urna, nec luctus" },
                    { 4, "https://netflix.com", "ipsum ac mi eleifend" },
                    { 5, "https://google.com", "augue ut" },
                    { 6, "https://bbc.co.uk", "ante ipsum primis in faucibus orci" },
                    { 7, "http://baidu.com", "per conubia nostra, per" },
                    { 8, "https://ebay.com", "Proin velit. Sed malesuada augue ut lacus." },
                    { 9, "http://reddit.com", "Integer urna. Vivamus molestie" },
                    { 10, "https://reddit.com", "dolor sit amet, consectetuer" },
                    { 11, "http://cnn.com", "Aliquam fringilla cursus purus. Nullam scelerisque" },
                    { 12, "https://instagram.com", "Donec consectetuer" },
                    { 13, "http://zoom.us", "magna. Sed eu eros. Nam consequat dolor vitae dolor." },
                    { 14, "http://cnn.com", "gravida sit amet, dapibus id, blandit" },
                    { 15, "https://baidu.com", "mus. Donec dignissim magna a tortor." }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "InterestId", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "The act of fishing", "Fishing" },
                    { 2, "The art of preparing food", "Cooking" },
                    { 3, "Exploring nature on foot", "Hiking" },
                    { 4, "Capturing moments through a lens", "Photography" },
                    { 5, "Growing and nurturing plants", "Gardening" },
                    { 6, "Immersing oneself in books", "Reading" },
                    { 7, "Expressing creativity through art", "Painting" },
                    { 8, "Creating music with strings", "Playing guitar" },
                    { 9, "Connecting mind, body, and spirit", "Yoga" },
                    { 10, "Exploring new places and cultures", "Traveling" },
                    { 11, "Exercising through jogging or sprints", "Running" },
                    { 12, "Expressing emotions through movement", "Dancing" },
                    { 13, "Strategic board game for two players", "Playing chess" },
                    { 14, "Putting thoughts into words", "Writing" },
                    { 15, "Finding inner peace and mindfulness", "Meditation" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Owen", "Marsh", "0725-11 71 34" },
                    { 2, "Cheyenne", "Willis", "0730-24 18 39" },
                    { 3, "Justin", "Ortiz", "0715-83 45 79" },
                    { 4, "Declan", "Burns", "0715-07 88 73" },
                    { 5, "Otto", "Clements", "0795-86 28 17" },
                    { 6, "Yardley", "Webb", "0795-65 65 88" },
                    { 7, "Octavius", "Flores", "0738-18 40 65" },
                    { 8, "Kermit", "Maxwell", "0767-83 35 84" },
                    { 9, "Garrison", "Bryant", "0739-76 66 19" },
                    { 10, "Keane", "Rasmussen", "0724-13 64 81" },
                    { 11, "Scarlet", "Keller", "0712-37 27 00" },
                    { 12, "Trevor", "West", "0751-22 72 78" },
                    { 13, "Curran", "Pruitt", "0759-76 21 08" },
                    { 14, "Dorian", "Hines", "0791-59 25 44" },
                    { 15, "Kieran", "Chapman", "0710-67 68 13" }
                });

            migrationBuilder.InsertData(
                table: "InterestLists",
                columns: new[] { "InterestListId", "Fk_InterestId", "Fk_InterestLinkId", "Fk_PersonId" },
                values: new object[,]
                {
                    { 1, 1, 1, 15 },
                    { 2, 2, 2, 14 },
                    { 3, 3, 3, 13 },
                    { 4, 4, 4, 12 },
                    { 5, 5, 5, 11 },
                    { 6, 6, 6, 10 },
                    { 7, 7, 7, 9 },
                    { 8, 8, 8, 8 },
                    { 9, 9, 9, 7 },
                    { 10, 10, 10, 6 },
                    { 11, 11, 11, 5 },
                    { 12, 12, 12, 4 },
                    { 13, 13, 13, 3 },
                    { 14, 14, 14, 2 },
                    { 15, 15, 15, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InterestLists_Fk_InterestId",
                table: "InterestLists",
                column: "Fk_InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestLists_Fk_InterestLinkId",
                table: "InterestLists",
                column: "Fk_InterestLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestLists_Fk_PersonId",
                table: "InterestLists",
                column: "Fk_PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterestLists");

            migrationBuilder.DropTable(
                name: "InterestLinks");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
