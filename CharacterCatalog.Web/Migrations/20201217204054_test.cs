using Microsoft.EntityFrameworkCore.Migrations;

namespace CharacterCatalog.Web.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    SpeciesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.SpeciesId);
                });

            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SpeciesId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Character_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "SpeciesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Name" },
                values: new object[] { 1, "Human" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Name" },
                values: new object[] { 2, "Alien" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Name" },
                values: new object[] { 3, "Humanoid" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Name" },
                values: new object[] { 4, "unknown" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Name" },
                values: new object[] { 5, "Poopybutthole" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Name" },
                values: new object[] { 6, "Mythological Creature" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Name" },
                values: new object[] { 7, "Animal" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Name" },
                values: new object[] { 8, "Robot" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Name" },
                values: new object[] { 9, "Cronenberg" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Name" },
                values: new object[] { 10, "Disease" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Name" },
                values: new object[] { 11, "Planet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 1, 3, "Rick Sanchez", "https://rickandmortyapi.com/api/character/avatar/1.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 492, 2, "Varrix", "https://rickandmortyapi.com/api/character/avatar/492.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 494, 3, "Crystal Poacher", "https://rickandmortyapi.com/api/character/avatar/494.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 495, 3, "Crystal Poacher", "https://rickandmortyapi.com/api/character/avatar/495.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 496, 3, "Crystal Poacher", "https://rickandmortyapi.com/api/character/avatar/496.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 502, 3, "Revolio Clockberg Jr.", "https://rickandmortyapi.com/api/character/avatar/502.jpeg", 2, 2, "Gear-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 525, 3, "Glootie", "https://rickandmortyapi.com/api/character/avatar/525.jpeg", 2, 0, "Monogatron" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 527, 3, "Mothership Intern", "https://rickandmortyapi.com/api/character/avatar/527.jpeg", 2, 0, "Monogatron" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 528, 3, "Monogatron Leader", "https://rickandmortyapi.com/api/character/avatar/528.jpeg", 2, 0, "Monogatron" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 529, 3, "Lizard", "https://rickandmortyapi.com/api/character/avatar/529.jpeg", 2, 2, "Lizard" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 531, 3, "Tony", "https://rickandmortyapi.com/api/character/avatar/531.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 532, 0, "Tony’s Wife", "https://rickandmortyapi.com/api/character/avatar/532.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 533, 0, "Monogatron Queen", "https://rickandmortyapi.com/api/character/avatar/533.jpeg", 2, 0, "Monogatron" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 534, 3, "Tony's Dad", "https://rickandmortyapi.com/api/character/avatar/534.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 541, 0, "Secretary at Tony's", "https://rickandmortyapi.com/api/character/avatar/541.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 543, 3, "Vermigurber", "https://rickandmortyapi.com/api/character/avatar/543.jpeg", 2, 0, "Fly" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 544, 3, "Miles Knightly", "https://rickandmortyapi.com/api/character/avatar/544.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 545, 0, "Heist-Con Receptionist", "https://rickandmortyapi.com/api/character/avatar/545.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 480, 3, "Purple Morty", "https://rickandmortyapi.com/api/character/avatar/480.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 547, 3, "Glar", "https://rickandmortyapi.com/api/character/avatar/547.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 470, 3, "Alien Spa Employee", "https://rickandmortyapi.com/api/character/avatar/470.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 468, 3, "Morphizer-XE Customer Support", "https://rickandmortyapi.com/api/character/avatar/468.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 411, 3, "Alien Mexican Armada", "https://rickandmortyapi.com/api/character/avatar/411.jpeg", 2, 1, "Mexican" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 419, 0, "Plutonian Hostess", "https://rickandmortyapi.com/api/character/avatar/419.jpeg", 2, 0, "Plutonian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 420, 3, "Plutonian Host", "https://rickandmortyapi.com/api/character/avatar/420.jpeg", 2, 0, "Plutonian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 421, 0, "Rich Plutonian", "https://rickandmortyapi.com/api/character/avatar/421.jpeg", 2, 0, "Plutonian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 422, 3, "Rich Plutonian", "https://rickandmortyapi.com/api/character/avatar/422.jpeg", 2, 0, "Plutonian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 435, 2, "Pripudlian", "https://rickandmortyapi.com/api/character/avatar/435.jpeg", 2, 0, "Pripudlian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 436, 2, "Giant Testicle Monster", "https://rickandmortyapi.com/api/character/avatar/436.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 445, 0, "Jerryboree Keeper", "https://rickandmortyapi.com/api/character/avatar/445.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 446, 3, "Jerryboree Receptionist", "https://rickandmortyapi.com/api/character/avatar/446.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 447, 3, "Anchor Gear", "https://rickandmortyapi.com/api/character/avatar/447.jpeg", 2, 0, "Gear-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 448, 3, "Gear Cop", "https://rickandmortyapi.com/api/character/avatar/448.jpeg", 2, 2, "Gear-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 454, 2, "Arbolian Mentirososian", "https://rickandmortyapi.com/api/character/avatar/454.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 455, 0, "St. Gloopy Noops Nurse", "https://rickandmortyapi.com/api/character/avatar/455.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 456, 3, "Nano Doctor", "https://rickandmortyapi.com/api/character/avatar/456.jpeg", 2, 0, "Nano Alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 459, 3, "Butthole Ice Cream Guy", "https://rickandmortyapi.com/api/character/avatar/459.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 460, 3, "Traflorkian Journalist", "https://rickandmortyapi.com/api/character/avatar/460.jpeg", 2, 0, "Traflorkian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 467, 3, "Morphizer-XE Customer Support", "https://rickandmortyapi.com/api/character/avatar/467.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 469, 3, "Morphizer-XE Customer Support", "https://rickandmortyapi.com/api/character/avatar/469.jpeg", 2, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 395, 2, "Greebybobe", "https://rickandmortyapi.com/api/character/avatar/395.jpeg", 2, 0, "Greebybobe" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 549, 3, "Snake Arms", "https://rickandmortyapi.com/api/character/avatar/549.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 552, 0, "Key Catcher", "https://rickandmortyapi.com/api/character/avatar/552.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 644, 3, "Old Glorzo", "https://rickandmortyapi.com/api/character/avatar/644.jpeg", 2, 2, "Glorzo" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 645, 3, "Shane", "https://rickandmortyapi.com/api/character/avatar/645.jpeg", 2, 1, "Glorzo" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 646, 3, "Steve", "https://rickandmortyapi.com/api/character/avatar/646.jpeg", 2, 2, "Glorzo" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 647, 3, "Troy", "https://rickandmortyapi.com/api/character/avatar/647.jpeg", 2, 2, "Glorzo" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 648, 3, "Crystal Dealers Boss", "https://rickandmortyapi.com/api/character/avatar/648.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 649, 3, "Crystal Dealer", "https://rickandmortyapi.com/api/character/avatar/649.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 650, 3, "Crystal Dealer", "https://rickandmortyapi.com/api/character/avatar/650.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 651, 3, "Crystal Dealer", "https://rickandmortyapi.com/api/character/avatar/651.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 668, 0, "Defiance Squanchette", "https://rickandmortyapi.com/api/character/avatar/668.jpeg", 2, 0, "Cat-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 669, 3, "Defiance Doctor", "https://rickandmortyapi.com/api/character/avatar/669.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 670, 3, "New Improved Galactic Federation Guard", "https://rickandmortyapi.com/api/character/avatar/670.jpeg", 2, 2, "Gromflomite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 671, 3, "New Improved Galactic Federation Guard", "https://rickandmortyapi.com/api/character/avatar/671.jpeg", 2, 2, "Gromflomite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 21, 3, "Aqua Morty", "https://rickandmortyapi.com/api/character/avatar/21.jpeg", 3, 1, "Fish-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 22, 3, "Aqua Rick", "https://rickandmortyapi.com/api/character/avatar/22.jpeg", 3, 1, "Fish-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 65, 3, "Chris", "https://rickandmortyapi.com/api/character/avatar/65.jpeg", 3, 0, "Microverse inhabitant" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 70, 3, "Concerto", "https://rickandmortyapi.com/api/character/avatar/70.jpeg", 3, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 85, 3, "Cyclops Morty", "https://rickandmortyapi.com/api/character/avatar/85.jpeg", 3, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 643, 3, "Council of Glorzos Member", "https://rickandmortyapi.com/api/character/avatar/643.jpeg", 2, 2, "Glorzo" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 551, 3, "Monitor Lord", "https://rickandmortyapi.com/api/character/avatar/551.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 642, 3, "Council of Glorzos Member", "https://rickandmortyapi.com/api/character/avatar/642.jpeg", 2, 2, "Glorzo" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 640, 3, "Angry Glorzo", "https://rickandmortyapi.com/api/character/avatar/640.jpeg", 2, 2, "Glorzo" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 553, 0, "The Shapeshiftress", "https://rickandmortyapi.com/api/character/avatar/553.jpeg", 2, 0, "Shapeshifter" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 559, 3, "Gramuflackian Anchorman", "https://rickandmortyapi.com/api/character/avatar/559.jpeg", 2, 2, "Gramuflackian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 560, 3, "Gramuflackian General", "https://rickandmortyapi.com/api/character/avatar/560.jpeg", 2, 2, "Gramuflackian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 570, 3, "Chachi", "https://rickandmortyapi.com/api/character/avatar/570.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 592, 3, "Phoenixperson", "https://rickandmortyapi.com/api/character/avatar/592.jpeg", 2, 0, "Cyborg" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 595, 3, "Floaty Non-Gasm Brotherhood Member", "https://rickandmortyapi.com/api/character/avatar/595.jpeg", 2, 2, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 596, 0, "Floaty Non-Gasm Brotherhood Member Friend", "https://rickandmortyapi.com/api/character/avatar/596.jpeg", 2, 2, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 599, 3, "Birdperson", "https://rickandmortyapi.com/api/character/avatar/599.jpeg", 2, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 600, 0, "Cats Fan", "https://rickandmortyapi.com/api/character/avatar/600.jpeg", 2, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 601, 3, "Christmas Storyteller", "https://rickandmortyapi.com/api/character/avatar/601.jpeg", 2, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 606, 3, "Goomby", "https://rickandmortyapi.com/api/character/avatar/606.jpeg", 2, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 607, 0, "Hairspray Fan", "https://rickandmortyapi.com/api/character/avatar/607.jpeg", 2, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 615, 3, "Musical Fan", "https://rickandmortyapi.com/api/character/avatar/615.jpeg", 2, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 616, 3, "Phantom of the Opera Fan", "https://rickandmortyapi.com/api/character/avatar/616.jpeg", 2, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 617, 3, "Phoenixperson", "https://rickandmortyapi.com/api/character/avatar/617.jpeg", 2, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 623, 3, "Shrek The Musical Fan", "https://rickandmortyapi.com/api/character/avatar/623.jpeg", 2, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 639, 3, "Uncle Nibbles", "https://rickandmortyapi.com/api/character/avatar/639.jpeg", 2, 2, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 641, 3, "Bruce", "https://rickandmortyapi.com/api/character/avatar/641.jpeg", 2, 2, "Glorzo" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 86, 3, "Cyclops Rick", "https://rickandmortyapi.com/api/character/avatar/86.jpeg", 3, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 391, 3, "Uncle Steve", "https://rickandmortyapi.com/api/character/avatar/391.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 386, 0, "Zarbadar Gloonch", "https://rickandmortyapi.com/api/character/avatar/386.jpeg", 2, 2, "Drumbloxian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 158, 2, "Hookah Alien", "https://rickandmortyapi.com/api/character/avatar/158.jpeg", 2, 0, "Tuskfish" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 161, 0, "Hydrogen-F", "https://rickandmortyapi.com/api/character/avatar/161.jpeg", 2, 0, "Alphabetrian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 162, 3, "Ice-T", "https://rickandmortyapi.com/api/character/avatar/162.jpeg", 2, 0, "Alphabetrian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 168, 0, "Jackie", "https://rickandmortyapi.com/api/character/avatar/168.jpeg", 2, 0, "Gazorpian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 184, 3, "Jon", "https://rickandmortyapi.com/api/character/avatar/184.jpeg", 2, 0, "Gazorpian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 188, 0, "Karen Entity", "https://rickandmortyapi.com/api/character/avatar/188.jpeg", 2, 0, "Unknown-nippled alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 190, 0, "Keara", "https://rickandmortyapi.com/api/character/avatar/190.jpeg", 2, 0, "Krootabulan" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 191, 3, "Kevin", "https://rickandmortyapi.com/api/character/avatar/191.jpeg", 2, 2, "Zigerion" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 192, 3, "King Flippy Nips", "https://rickandmortyapi.com/api/character/avatar/192.jpeg", 2, 0, "Plutonian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 194, 2, "Kozbian", "https://rickandmortyapi.com/api/character/avatar/194.jpeg", 2, 0, "Tentacle alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 196, 3, "Krombopulos Michael", "https://rickandmortyapi.com/api/character/avatar/196.jpeg", 2, 2, "Gromflomite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 199, 2, "Larva Alien", "https://rickandmortyapi.com/api/character/avatar/199.jpeg", 2, 0, "Larva alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 202, 3, "Lighthouse Keeper", "https://rickandmortyapi.com/api/character/avatar/202.jpeg", 2, 2, "Cat-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 203, 3, "Lil B", "https://rickandmortyapi.com/api/character/avatar/203.jpeg", 2, 2, "Snail alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 204, 0, "Lisa", "https://rickandmortyapi.com/api/character/avatar/204.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 207, 3, "Loggins", "https://rickandmortyapi.com/api/character/avatar/207.jpeg", 2, 0, "Alligator-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 211, 0, "Ma-Sha", "https://rickandmortyapi.com/api/character/avatar/211.jpeg", 2, 0, "Gazorpian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 154, 3, "Hamurai", "https://rickandmortyapi.com/api/character/avatar/154.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 212, 3, "Magma-Q", "https://rickandmortyapi.com/api/character/avatar/212.jpeg", 2, 2, "Alphabetrian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 150, 3, "Cornvelious Daniel", "https://rickandmortyapi.com/api/character/avatar/150.jpeg", 2, 2, "Gromflomite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 146, 3, "Glexo Slim Slom", "https://rickandmortyapi.com/api/character/avatar/146.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 104, 2, "Doom-Nomitron", "https://rickandmortyapi.com/api/character/avatar/104.jpeg", 2, 2, "Shapeshifter" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 105, 3, "Dr. Glip-Glop", "https://rickandmortyapi.com/api/character/avatar/105.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 109, 3, "Duck With Muscles", "https://rickandmortyapi.com/api/character/avatar/109.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 121, 3, "Eyehole Man", "https://rickandmortyapi.com/api/character/avatar/121.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 122, 3, "Fart", "https://rickandmortyapi.com/api/character/avatar/122.jpeg", 2, 2, "Interdimensional gaseous being" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 125, 2, "Flansian", "https://rickandmortyapi.com/api/character/avatar/125.jpeg", 2, 0, "Flansian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 126, 2, "Fleeb", "https://rickandmortyapi.com/api/character/avatar/126.jpeg", 2, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 128, 3, "Frankenstein's Monster", "https://rickandmortyapi.com/api/character/avatar/128.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 130, 3, "Galactic Federation President", "https://rickandmortyapi.com/api/character/avatar/130.jpeg", 2, 2, "Gromflomite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 131, 3, "Gar Gloonch", "https://rickandmortyapi.com/api/character/avatar/131.jpeg", 2, 2, "Zombodian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 133, 3, "Garblovian", "https://rickandmortyapi.com/api/character/avatar/133.jpeg", 2, 0, "Garblovian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 134, 3, "Garmanarnar", "https://rickandmortyapi.com/api/character/avatar/134.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 136, 3, "Gazorpazorpfield", "https://rickandmortyapi.com/api/character/avatar/136.jpeg", 2, 0, "Gazorpian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 139, 3, "General Store Owner", "https://rickandmortyapi.com/api/character/avatar/139.jpeg", 2, 2, "Cat-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 141, 1, "Ghost in a Jar", "https://rickandmortyapi.com/api/character/avatar/141.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 142, 2, "Gibble Snake", "https://rickandmortyapi.com/api/character/avatar/142.jpeg", 2, 2, "Animal" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 144, 3, "Glenn", "https://rickandmortyapi.com/api/character/avatar/144.jpeg", 2, 2, "Gromflomite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 147, 3, "Gobo", "https://rickandmortyapi.com/api/character/avatar/147.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 390, 3, "Zick Zack", "https://rickandmortyapi.com/api/character/avatar/390.jpeg", 2, 2, "Floop Floopian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 213, 3, "Magnesium-J", "https://rickandmortyapi.com/api/character/avatar/213.jpeg", 2, 0, "Alphabetrian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 248, 0, "Mrs. Refrigerator", "https://rickandmortyapi.com/api/character/avatar/248.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 336, 3, "Steven Phillips", "https://rickandmortyapi.com/api/character/avatar/336.jpeg", 2, 0, "Unknown-nippled alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 337, 3, "Stu", "https://rickandmortyapi.com/api/character/avatar/337.jpeg", 2, 2, "Zigerion" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 351, 2, "Three Unknown Things", "https://rickandmortyapi.com/api/character/avatar/351.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 352, 0, "Tinkles", "https://rickandmortyapi.com/api/character/avatar/352.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 355, 3, "Todd Crystal", "https://rickandmortyapi.com/api/character/avatar/355.jpeg", 2, 0, "Unknown-nippled alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 362, 2, "Traflorkian", "https://rickandmortyapi.com/api/character/avatar/362.jpeg", 2, 0, "Traflorkian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 363, 3, "Trandor", "https://rickandmortyapi.com/api/character/avatar/363.jpeg", 2, 0, "Krootabulan" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 369, 3, "Tusked Assassin", "https://rickandmortyapi.com/api/character/avatar/369.jpeg", 2, 1, "Tuskfish" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 371, 3, "Tumblorkian", "https://rickandmortyapi.com/api/character/avatar/371.jpeg", 2, 0, "Tumblorkian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 372, 1, "Unity", "https://rickandmortyapi.com/api/character/avatar/372.jpeg", 2, 0, "Hivemind" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 376, 0, "Veronica Ann Bennet", "https://rickandmortyapi.com/api/character/avatar/376.jpeg", 2, 0, "Gazorpian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 377, 2, "Voltematron", "https://rickandmortyapi.com/api/character/avatar/377.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 379, 3, "Wedding Bartender", "https://rickandmortyapi.com/api/character/avatar/379.jpeg", 2, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 381, 0, "Woman Rick", "https://rickandmortyapi.com/api/character/avatar/381.jpeg", 2, 0, "Chair" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 382, 3, "Worldender", "https://rickandmortyapi.com/api/character/avatar/382.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 383, 3, "Yaarb", "https://rickandmortyapi.com/api/character/avatar/383.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 384, 3, "Yellow Headed Doctor", "https://rickandmortyapi.com/api/character/avatar/384.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 331, 3, "Squanchy", "https://rickandmortyapi.com/api/character/avatar/331.jpeg", 2, 1, "Cat-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 236, 3, "Mr. Beauregard", "https://rickandmortyapi.com/api/character/avatar/236.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 324, 3, "Sleepy Gary", "https://rickandmortyapi.com/api/character/avatar/324.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 320, 3, "Shnoopy Bloopers", "https://rickandmortyapi.com/api/character/avatar/320.jpeg", 2, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 253, 2, "Numbericon", "https://rickandmortyapi.com/api/character/avatar/253.jpeg", 2, 1, "Numbericon" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 258, 3, "Pawnshop Clerk", "https://rickandmortyapi.com/api/character/avatar/258.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 259, 3, "Pencilvester", "https://rickandmortyapi.com/api/character/avatar/259.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 262, 2, "Photography Raptor", "https://rickandmortyapi.com/api/character/avatar/262.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 263, 3, "Pibbles Bodyguard", "https://rickandmortyapi.com/api/character/avatar/263.jpeg", 2, 0, "Hairy alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 270, 3, "Prince Nebulon", "https://rickandmortyapi.com/api/character/avatar/270.jpeg", 2, 2, "Zigerion" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 273, 3, "Purge Planet Ruler", "https://rickandmortyapi.com/api/character/avatar/273.jpeg", 2, 2, "Cat-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 280, 3, "Reverse Giraffe", "https://rickandmortyapi.com/api/character/avatar/280.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 282, 3, "Revolio Clockberg Jr.", "https://rickandmortyapi.com/api/character/avatar/282.jpeg", 2, 1, "Gear-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 296, 3, "Risotto Groupon", "https://rickandmortyapi.com/api/character/avatar/296.jpeg", 2, 2, "Blue ape alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 297, 3, "Risotto's Tentacled Henchman", "https://rickandmortyapi.com/api/character/avatar/297.jpeg", 2, 2, "Tentacle alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 301, 3, "Ron Benson", "https://rickandmortyapi.com/api/character/avatar/301.jpeg", 2, 0, "Ring-nippled alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 307, 3, "Scroopy Noopers", "https://rickandmortyapi.com/api/character/avatar/307.jpeg", 2, 0, "Plutonian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 308, 3, "Scropon", "https://rickandmortyapi.com/api/character/avatar/308.jpeg", 2, 1, "Lobster-Alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 311, 3, "Shimshamian", "https://rickandmortyapi.com/api/character/avatar/311.jpeg", 2, 0, "Shimshamian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 312, 2, "Shlaammi", "https://rickandmortyapi.com/api/character/avatar/312.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 319, 3, "Shmooglite Runner", "https://rickandmortyapi.com/api/character/avatar/319.jpeg", 2, 1, "Animal" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 321, 3, "Shrimply Pibbles", "https://rickandmortyapi.com/api/character/avatar/321.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 90, 3, "Daron Jefferson", "https://rickandmortyapi.com/api/character/avatar/90.jpeg", 2, 0, "Cone-nippled alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 108, 3, "Dr. Xenon Bloom", "https://rickandmortyapi.com/api/character/avatar/108.jpeg", 3, 2, "Amoeba-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 152, 3, "Hammerhead Morty", "https://rickandmortyapi.com/api/character/avatar/152.jpeg", 3, 1, "Hammerhead-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 504, 3, "Fascist Shrimp Rick’s Clone", "https://rickandmortyapi.com/api/character/avatar/504.jpeg", 7, 2, "Shrimp" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 505, 3, "Fascist Shrimp Morty", "https://rickandmortyapi.com/api/character/avatar/505.jpeg", 7, 0, "Shrimp" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 506, 3, "Fascist Shrimp SS", "https://rickandmortyapi.com/api/character/avatar/506.jpeg", 7, 0, "Shrimp" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 507, 3, "Fascist Teddy Bear Rick", "https://rickandmortyapi.com/api/character/avatar/507.jpeg", 7, 0, "Teddy Bear" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 508, 3, "Fascist Teddy Bear Rick’s Clone", "https://rickandmortyapi.com/api/character/avatar/508.jpeg", 7, 2, "Teddy Bear" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 515, 3, "Caterpillar Mr. Goldenfold", "https://rickandmortyapi.com/api/character/avatar/515.jpeg", 7, 2, "Caterpillar" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 516, 3, "Wasp Rick", "https://rickandmortyapi.com/api/character/avatar/516.jpeg", 7, 0, "Wasp" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 517, 3, "Wasp Rick’s Clone", "https://rickandmortyapi.com/api/character/avatar/517.jpeg", 7, 1, "Wasp" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 518, 3, "Wasp Morty", "https://rickandmortyapi.com/api/character/avatar/518.jpeg", 7, 0, "Wasp" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 519, 0, "Wasp Summer", "https://rickandmortyapi.com/api/character/avatar/519.jpeg", 7, 0, "Wasp" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 520, 3, "Wasp Jerry", "https://rickandmortyapi.com/api/character/avatar/520.jpeg", 7, 0, "Wasp" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 521, 0, "Wasp Beth", "https://rickandmortyapi.com/api/character/avatar/521.jpeg", 7, 0, "Wasp" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 522, 2, "Caterpillar Mr. Goldenfold’s Larvae", "https://rickandmortyapi.com/api/character/avatar/522.jpeg", 7, 2, "Caterpillar" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 564, 3, "Talking Cat", "https://rickandmortyapi.com/api/character/avatar/564.jpeg", 7, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 571, 0, "Slippy", "https://rickandmortyapi.com/api/character/avatar/571.jpeg", 7, 0, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 573, 3, "Snake Hitler", "https://rickandmortyapi.com/api/character/avatar/573.jpeg", 7, 2, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 574, 3, "Snake Lincoln", "https://rickandmortyapi.com/api/character/avatar/574.jpeg", 7, 2, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 503, 3, "Fascist Shrimp Rick", "https://rickandmortyapi.com/api/character/avatar/503.jpeg", 7, 0, "Shrimp" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 576, 3, "Snake Linguist", "https://rickandmortyapi.com/api/character/avatar/576.jpeg", 7, 1, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 433, 2, "Doopidoo", "https://rickandmortyapi.com/api/character/avatar/433.jpeg", 7, 0, "Doopidoo" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 412, 2, "Giant Cat Monster", "https://rickandmortyapi.com/api/character/avatar/412.jpeg", 7, 1, "Giant Cat Monster" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 565, 3, "Debrah", "https://rickandmortyapi.com/api/character/avatar/565.jpeg", 6, 0, "Dragon" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 566, 3, "Debrah’s Partner", "https://rickandmortyapi.com/api/character/avatar/566.jpeg", 6, 0, "Dragon" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 567, 3, "Michael", "https://rickandmortyapi.com/api/character/avatar/567.jpeg", 6, 0, "Dragon" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 568, 3, "Slut Dragon", "https://rickandmortyapi.com/api/character/avatar/568.jpeg", 6, 0, "Dragon" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 569, 3, "Shadow Jacker", "https://rickandmortyapi.com/api/character/avatar/569.jpeg", 6, 0, "Dragon" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 663, 3, "Reggie", "https://rickandmortyapi.com/api/character/avatar/663.jpeg", 6, 2, "Zeus" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 46, 3, "Bill", "https://rickandmortyapi.com/api/character/avatar/46.jpeg", 7, 1, "Dog" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 81, 3, "Crocubot", "https://rickandmortyapi.com/api/character/avatar/81.jpeg", 7, 2, "Robot-Crocodile hybrid" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 153, 2, "Hamster In Butt", "https://rickandmortyapi.com/api/character/avatar/153.jpeg", 7, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 167, 2, "Izzy", "https://rickandmortyapi.com/api/character/avatar/167.jpeg", 7, 0, "Cat" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 226, 3, "Million Ants", "https://rickandmortyapi.com/api/character/avatar/226.jpeg", 7, 2, "Sentient ant colony" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 276, 2, "Rat Boss", "https://rickandmortyapi.com/api/character/avatar/276.jpeg", 7, 2, "Rat" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 309, 3, "Scrotian", "https://rickandmortyapi.com/api/character/avatar/309.jpeg", 7, 0, "Scrotian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 329, 3, "Snuffles (Snowball)", "https://rickandmortyapi.com/api/character/avatar/329.jpeg", 7, 0, "Dog" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 397, 3, "Fido", "https://rickandmortyapi.com/api/character/avatar/397.jpeg", 7, 0, "Dog" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 398, 3, "Accountant dog", "https://rickandmortyapi.com/api/character/avatar/398.jpeg", 7, 0, "Dog" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 406, 2, "Spiderweb teddy bear", "https://rickandmortyapi.com/api/character/avatar/406.jpeg", 7, 0, "Teddy Bear" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 423, 2, "Synthetic Laser Eels", "https://rickandmortyapi.com/api/character/avatar/423.jpeg", 7, 0, "Eel" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 562, 3, "Balthromaw", "https://rickandmortyapi.com/api/character/avatar/562.jpeg", 6, 0, "Dragon" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 578, 3, "Snake Soldier", "https://rickandmortyapi.com/api/character/avatar/578.jpeg", 7, 0, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 580, 3, "Secret Service Snake", "https://rickandmortyapi.com/api/character/avatar/580.jpeg", 7, 0, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 555, 1, "Randotron", "https://rickandmortyapi.com/api/character/avatar/555.jpeg", 8, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 572, 1, "Robot Snake", "https://rickandmortyapi.com/api/character/avatar/572.jpeg", 8, 1, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 575, 1, "Snake Resistance Robot", "https://rickandmortyapi.com/api/character/avatar/575.jpeg", 8, 2, "Human-Snake hybrid" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 577, 3, "Snake Terminator", "https://rickandmortyapi.com/api/character/avatar/577.jpeg", 8, 1, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 82, 3, "Cronenberg Rick", "https://rickandmortyapi.com/api/character/avatar/82.jpeg", 9, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 83, 3, "Cronenberg Morty", "https://rickandmortyapi.com/api/character/avatar/83.jpeg", 9, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 155, 3, "Harold", "https://rickandmortyapi.com/api/character/avatar/155.jpeg", 9, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 179, 0, "Jessica", "https://rickandmortyapi.com/api/character/avatar/179.jpeg", 9, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 239, 3, "Mr. Goldenfold", "https://rickandmortyapi.com/api/character/avatar/239.jpeg", 9, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 271, 3, "Principal Vagina", "https://rickandmortyapi.com/api/character/avatar/271.jpeg", 9, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 343, 0, "Tammy Guetermann", "https://rickandmortyapi.com/api/character/avatar/343.jpeg", 9, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 394, 3, "Davin", "https://rickandmortyapi.com/api/character/avatar/394.jpeg", 9, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 96, 2, "Tuberculosis", "https://rickandmortyapi.com/api/character/avatar/96.jpeg", 10, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 97, 2, "Gonorrhea", "https://rickandmortyapi.com/api/character/avatar/97.jpeg", 10, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 98, 2, "Hepatitis A", "https://rickandmortyapi.com/api/character/avatar/98.jpeg", 10, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 99, 2, "Hepatitis C", "https://rickandmortyapi.com/api/character/avatar/99.jpeg", 10, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 100, 2, "Bubonic Plague", "https://rickandmortyapi.com/api/character/avatar/100.jpeg", 10, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 554, 1, "Heistotron", "https://rickandmortyapi.com/api/character/avatar/554.jpeg", 8, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 579, 3, "Snake with Legs", "https://rickandmortyapi.com/api/character/avatar/579.jpeg", 7, 0, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 530, 1, "Deliverance", "https://rickandmortyapi.com/api/character/avatar/530.jpeg", 8, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 299, 3, "Robot Rick", "https://rickandmortyapi.com/api/character/avatar/299.jpeg", 8, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 581, 3, "Anchosnake", "https://rickandmortyapi.com/api/character/avatar/581.jpeg", 7, 0, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 582, 0, "Anchosnake", "https://rickandmortyapi.com/api/character/avatar/582.jpeg", 7, 0, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 583, 3, "80's snake", "https://rickandmortyapi.com/api/character/avatar/583.jpeg", 7, 1, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 587, 3, "Cavesnake", "https://rickandmortyapi.com/api/character/avatar/587.jpeg", 7, 2, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 589, 3, "Snake Reporter", "https://rickandmortyapi.com/api/character/avatar/589.jpeg", 7, 0, "Snake" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 598, 3, "Biblesaurus", "https://rickandmortyapi.com/api/character/avatar/598.jpeg", 7, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 604, 0, "Female Scorpion", "https://rickandmortyapi.com/api/character/avatar/604.jpeg", 7, 2, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 624, 3, "Snuffles", "https://rickandmortyapi.com/api/character/avatar/624.jpeg", 7, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 71, 2, "Conroy", "https://rickandmortyapi.com/api/character/avatar/71.jpeg", 8, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 102, 0, "Donna Gueterman", "https://rickandmortyapi.com/api/character/avatar/102.jpeg", 8, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 151, 0, "Gwendolyn", "https://rickandmortyapi.com/api/character/avatar/151.jpeg", 8, 1, "Gazorpian reproduction robot" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 217, 3, "Mechanical Morty", "https://rickandmortyapi.com/api/character/avatar/217.jpeg", 8, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 218, 3, "Mechanical Rick", "https://rickandmortyapi.com/api/character/avatar/218.jpeg", 8, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 219, 0, "Mechanical Summer", "https://rickandmortyapi.com/api/character/avatar/219.jpeg", 8, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 256, 3, "Pat Gueterman", "https://rickandmortyapi.com/api/character/avatar/256.jpeg", 8, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 261, 3, "Photography Cyborg", "https://rickandmortyapi.com/api/character/avatar/261.jpeg", 8, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 298, 3, "Robot Morty", "https://rickandmortyapi.com/api/character/avatar/298.jpeg", 8, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 471, 1, "Little Voltron", "https://rickandmortyapi.com/api/character/avatar/471.jpeg", 8, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 119, 3, "Evil Rick", "https://rickandmortyapi.com/api/character/avatar/119.jpeg", 3, 2, "Robot" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 556, 3, "Hephaestus", "https://rickandmortyapi.com/api/character/avatar/556.jpeg", 6, 0, "God" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 453, 3, "Vampire Master's Assistant", "https://rickandmortyapi.com/api/character/avatar/453.jpeg", 6, 0, "Vampire" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 404, 3, "Michael Jackson", "https://rickandmortyapi.com/api/character/avatar/404.jpeg", 3, 0, "Phone-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 424, 3, "Pizza-person", "https://rickandmortyapi.com/api/character/avatar/424.jpeg", 3, 0, "Pizza" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 425, 3, "Pizza-person", "https://rickandmortyapi.com/api/character/avatar/425.jpeg", 3, 0, "Pizza" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 427, 3, "Phone-person", "https://rickandmortyapi.com/api/character/avatar/427.jpeg", 3, 0, "Phone" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 428, 3, "Phone-person", "https://rickandmortyapi.com/api/character/avatar/428.jpeg", 3, 0, "Phone" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 429, 3, "Chair-person", "https://rickandmortyapi.com/api/character/avatar/429.jpeg", 3, 0, "Chair" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 430, 3, "Chair-person", "https://rickandmortyapi.com/api/character/avatar/430.jpeg", 3, 0, "Chair" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 431, 3, "Chair-homeless", "https://rickandmortyapi.com/api/character/avatar/431.jpeg", 3, 0, "Chair" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 432, 3, "Chair-waiter", "https://rickandmortyapi.com/api/character/avatar/432.jpeg", 3, 0, "Chair" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 497, 3, "Hologram Rick", "https://rickandmortyapi.com/api/character/avatar/497.jpeg", 3, 2, "Hologram" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 524, 3, "Kirkland Brand Mr. Meeseeks", "https://rickandmortyapi.com/api/character/avatar/524.jpeg", 3, 1, "Meeseeks" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 550, 3, "Double Microwawe", "https://rickandmortyapi.com/api/character/avatar/550.jpeg", 3, 0, "Cyborg" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 557, 0, "Ventriloquiver", "https://rickandmortyapi.com/api/character/avatar/557.jpeg", 3, 0, "Dummy" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 664, 1, "Ticktock", "https://rickandmortyapi.com/api/character/avatar/664.jpeg", 3, 1, "Clay-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 665, 1, "Florflock", "https://rickandmortyapi.com/api/character/avatar/665.jpeg", 3, 0, "Clay-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 666, 1, "Squeeb", "https://rickandmortyapi.com/api/character/avatar/666.jpeg", 3, 0, "Clay-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 25, 3, "Armothy", "https://rickandmortyapi.com/api/character/avatar/25.jpeg", 4, 2, "Self-aware arm" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 403, 3, "Corn detective", "https://rickandmortyapi.com/api/character/avatar/403.jpeg", 3, 2, "Corn-person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 157, 1, "Hole in the Wall Where the Men Can See it All", "https://rickandmortyapi.com/api/character/avatar/157.jpeg", 4, 1, "Hole" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 388, 3, "Zeep Xanflorp", "https://rickandmortyapi.com/api/character/avatar/388.jpeg", 3, 0, "Microverse inhabitant" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 367, 3, "Trunk Man", "https://rickandmortyapi.com/api/character/avatar/367.jpeg", 3, 0, "Trunk-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 197, 3, "Kyle", "https://rickandmortyapi.com/api/character/avatar/197.jpeg", 3, 2, "Miniverse inhabitant" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 198, 0, "Lady Katana", "https://rickandmortyapi.com/api/character/avatar/198.jpeg", 3, 2, "Cyborg" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 205, 3, "Little Dipper", "https://rickandmortyapi.com/api/character/avatar/205.jpeg", 3, 0, "Tinymouth" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 206, 3, "Lizard Morty", "https://rickandmortyapi.com/api/character/avatar/206.jpeg", 3, 0, "Lizard-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 225, 3, "Michael Thompson", "https://rickandmortyapi.com/api/character/avatar/225.jpeg", 3, 0, "Conjoined twin" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 230, 3, "Morty Jr.", "https://rickandmortyapi.com/api/character/avatar/230.jpeg", 3, 0, "Human Gazorpian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 242, 3, "Mr. Meeseeks", "https://rickandmortyapi.com/api/character/avatar/242.jpeg", 3, 1, "Meeseeks" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 243, 3, "Mr. Needful", "https://rickandmortyapi.com/api/character/avatar/243.jpeg", 3, 0, "The Devil" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 254, 3, "Octopus Man", "https://rickandmortyapi.com/api/character/avatar/254.jpeg", 3, 0, "Octopus-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 264, 3, "Pichael Thompson", "https://rickandmortyapi.com/api/character/avatar/264.jpeg", 3, 0, "Conjoined twin" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 269, 0, "Presidentress of The Mega Gargantuans", "https://rickandmortyapi.com/api/character/avatar/269.jpeg", 3, 0, "Mega Gargantuan" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 327, 3, "Slow Mobius", "https://rickandmortyapi.com/api/character/avatar/327.jpeg", 3, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 348, 3, "The President of the Miniverse", "https://rickandmortyapi.com/api/character/avatar/348.jpeg", 3, 2, "Miniverse inhabitant" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 360, 3, "Toxic Morty", "https://rickandmortyapi.com/api/character/avatar/360.jpeg", 3, 2, "Morty's toxic side" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 361, 3, "Toxic Rick", "https://rickandmortyapi.com/api/character/avatar/361.jpeg", 3, 2, "Rick's toxic side" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 364, 2, "Tree Person", "https://rickandmortyapi.com/api/character/avatar/364.jpeg", 3, 2, "Teenyverse inhabitant" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 366, 3, "Trunk Morty", "https://rickandmortyapi.com/api/character/avatar/366.jpeg", 3, 0, "Trunk-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 378, 3, "Wall Crawling Rick", "https://rickandmortyapi.com/api/character/avatar/378.jpeg", 3, 1, "Lizard-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 548, 3, "Truckula", "https://rickandmortyapi.com/api/character/avatar/548.jpeg", 6, 0, "Vampire" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 265, 3, "Pickle Rick", "https://rickandmortyapi.com/api/character/avatar/265.jpeg", 4, 0, "Pickle" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 313, 3, "Shleemypants", "https://rickandmortyapi.com/api/character/avatar/313.jpeg", 4, 0, "Omniscient being" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 178, 3, "Jerry's Mytholog", "https://rickandmortyapi.com/api/character/avatar/178.jpeg", 6, 2, "Mytholog" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 193, 3, "King Jellybean", "https://rickandmortyapi.com/api/character/avatar/193.jpeg", 6, 2, "Jellybean" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 221, 0, "Melissa", "https://rickandmortyapi.com/api/character/avatar/221.jpeg", 6, 0, "Monster" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 238, 3, "Mr. Booby Buyer", "https://rickandmortyapi.com/api/character/avatar/238.jpeg", 6, 0, "Boobie buyer reptilian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 304, 3, "Scary Brandon", "https://rickandmortyapi.com/api/character/avatar/304.jpeg", 6, 0, "Monster" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 305, 3, "Scary Glenn", "https://rickandmortyapi.com/api/character/avatar/305.jpeg", 6, 0, "Monster" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 306, 3, "Scary Terry", "https://rickandmortyapi.com/api/character/avatar/306.jpeg", 6, 0, "Monster" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 310, 3, "Self-Congratulatory Jerry", "https://rickandmortyapi.com/api/character/avatar/310.jpeg", 6, 1, "Mytholog" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 326, 3, "Slippery Stair", "https://rickandmortyapi.com/api/character/avatar/326.jpeg", 6, 0, "Slug" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 333, 1, "Stair Goblin", "https://rickandmortyapi.com/api/character/avatar/333.jpeg", 6, 0, "Stair goblin" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 358, 3, "Tophat Jones", "https://rickandmortyapi.com/api/character/avatar/358.jpeg", 6, 2, "Leprechaun" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 368, 3, "Truth Tortoise", "https://rickandmortyapi.com/api/character/avatar/368.jpeg", 6, 1, "Omniscient being" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 374, 3, "Vampire Master", "https://rickandmortyapi.com/api/character/avatar/374.jpeg", 6, 0, "Vampire" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 387, 0, "Zarbadar's Mytholog", "https://rickandmortyapi.com/api/character/avatar/387.jpeg", 6, 1, "Mytholog" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 396, 3, "Scary Teacher", "https://rickandmortyapi.com/api/character/avatar/396.jpeg", 6, 0, "Monster" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 399, 3, "Tiny-persons advocacy group lawyer", "https://rickandmortyapi.com/api/character/avatar/399.jpeg", 6, 0, "Giant" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 400, 3, "Giant Judge", "https://rickandmortyapi.com/api/character/avatar/400.jpeg", 6, 0, "Giant" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 163, 3, "Ideal Jerry", "https://rickandmortyapi.com/api/character/avatar/163.jpeg", 6, 2, "Mytholog" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 266, 1, "Piece of Toast", "https://rickandmortyapi.com/api/character/avatar/266.jpeg", 4, 0, "Bread" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 148, 0, "Goddess Beth", "https://rickandmortyapi.com/api/character/avatar/148.jpeg", 6, 1, "Goddess" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 93, 3, "Diablo Verde", "https://rickandmortyapi.com/api/character/avatar/93.jpeg", 6, 2, "Demon" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 523, 2, "Boglin", "https://rickandmortyapi.com/api/character/avatar/523.jpeg", 4, 1, "Toy" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 603, 1, "Crossy", "https://rickandmortyapi.com/api/character/avatar/603.jpeg", 4, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 611, 0, "Leah", "https://rickandmortyapi.com/api/character/avatar/611.jpeg", 4, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 614, 1, "Mr. Celery & Friends", "https://rickandmortyapi.com/api/character/avatar/614.jpeg", 4, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 627, 1, "The Concept of Time", "https://rickandmortyapi.com/api/character/avatar/627.jpeg", 4, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 30, 3, "Baby Poopybutthole", "https://rickandmortyapi.com/api/character/avatar/30.jpeg", 5, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 34, 3, "Benjamin", "https://rickandmortyapi.com/api/character/avatar/34.jpeg", 5, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 244, 3, "Mr. Poopybutthole", "https://rickandmortyapi.com/api/character/avatar/244.jpeg", 5, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 247, 0, "Mrs. Poopybutthole", "https://rickandmortyapi.com/api/character/avatar/247.jpeg", 5, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 252, 3, "Noob-Noob", "https://rickandmortyapi.com/api/character/avatar/252.jpeg", 5, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 334, 3, "Stealy", "https://rickandmortyapi.com/api/character/avatar/334.jpeg", 5, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 635, 3, "Darth Poopybutthole", "https://rickandmortyapi.com/api/character/avatar/635.jpeg", 5, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 40, 0, "Beth's Mytholog", "https://rickandmortyapi.com/api/character/avatar/40.jpeg", 6, 2, "Mytholog" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 41, 0, "Big Boobed Waitress", "https://rickandmortyapi.com/api/character/avatar/41.jpeg", 6, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 63, 3, "Centaur", "https://rickandmortyapi.com/api/character/avatar/63.jpeg", 6, 0, "Centaur" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 66, 3, "Coach Feratu (Balik Alistane)", "https://rickandmortyapi.com/api/character/avatar/66.jpeg", 6, 2, "Vampire" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 89, 3, "Dale", "https://rickandmortyapi.com/api/character/avatar/89.jpeg", 6, 2, "Giant" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 132, 3, "Gar's Mytholog", "https://rickandmortyapi.com/api/character/avatar/132.jpeg", 6, 2, "Mytholog" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 101, 2, "E. Coli", "https://rickandmortyapi.com/api/character/avatar/101.jpeg", 10, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 87, 0, "Cynthia", "https://rickandmortyapi.com/api/character/avatar/87.jpeg", 2, 2, "Zigerion" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 76, 3, "Cousin Nicky", "https://rickandmortyapi.com/api/character/avatar/76.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 223, 3, "Michael Jenkins", "https://rickandmortyapi.com/api/character/avatar/223.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 224, 3, "Michael McLick", "https://rickandmortyapi.com/api/character/avatar/224.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 227, 3, "Mitch", "https://rickandmortyapi.com/api/character/avatar/227.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 228, 3, "Mohawk Guy", "https://rickandmortyapi.com/api/character/avatar/228.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 229, 3, "Morty Mart Manager Morty", "https://rickandmortyapi.com/api/character/avatar/229.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 231, 3, "Morty Rick", "https://rickandmortyapi.com/api/character/avatar/231.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 232, 3, "Morty Smith", "https://rickandmortyapi.com/api/character/avatar/232.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 233, 3, "Morty K-22", "https://rickandmortyapi.com/api/character/avatar/233.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 234, 3, "Morty Smith", "https://rickandmortyapi.com/api/character/avatar/234.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 235, 3, "Mortytown Loco", "https://rickandmortyapi.com/api/character/avatar/235.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 237, 3, "Mr. Benson", "https://rickandmortyapi.com/api/character/avatar/237.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 240, 3, "Mr. Goldenfold", "https://rickandmortyapi.com/api/character/avatar/240.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 241, 3, "Mr. Marklovitz", "https://rickandmortyapi.com/api/character/avatar/241.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 245, 0, "Mrs. Lipkip", "https://rickandmortyapi.com/api/character/avatar/245.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 246, 0, "Mrs. Pancakes", "https://rickandmortyapi.com/api/character/avatar/246.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 249, 0, "Mrs. Sanchez", "https://rickandmortyapi.com/api/character/avatar/249.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 250, 0, "Mrs. Sullivan", "https://rickandmortyapi.com/api/character/avatar/250.jpeg", 1, 2, "Cat controlled dead lady" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 222, 3, "Michael Denny and the Denny Singers", "https://rickandmortyapi.com/api/character/avatar/222.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 251, 0, "Nancy", "https://rickandmortyapi.com/api/character/avatar/251.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 220, 3, "Mega Fruit Farmer Rick", "https://rickandmortyapi.com/api/character/avatar/220.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 215, 3, "Maximums Rickimus", "https://rickandmortyapi.com/api/character/avatar/215.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 176, 3, "Celebrity Jerry", "https://rickandmortyapi.com/api/character/avatar/176.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 177, 3, "Jerry Smith", "https://rickandmortyapi.com/api/character/avatar/177.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 180, 0, "Jessica", "https://rickandmortyapi.com/api/character/avatar/180.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 181, 0, "Jessica's Friend", "https://rickandmortyapi.com/api/character/avatar/181.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 182, 3, "Jim", "https://rickandmortyapi.com/api/character/avatar/182.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 183, 3, "Johnny Depp", "https://rickandmortyapi.com/api/character/avatar/183.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 185, 3, "Joseph Eli Lipkip", "https://rickandmortyapi.com/api/character/avatar/185.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 186, 0, "Joyce Smith", "https://rickandmortyapi.com/api/character/avatar/186.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 187, 3, "Juggling Rick", "https://rickandmortyapi.com/api/character/avatar/187.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 189, 0, "Katarina", "https://rickandmortyapi.com/api/character/avatar/189.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 195, 0, "Kristen Stewart", "https://rickandmortyapi.com/api/character/avatar/195.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 200, 3, "Lawyer Morty", "https://rickandmortyapi.com/api/character/avatar/200.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 201, 3, "Leonard Smith", "https://rickandmortyapi.com/api/character/avatar/201.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 208, 3, "Logic", "https://rickandmortyapi.com/api/character/avatar/208.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 209, 3, "Long Sleeved Morty", "https://rickandmortyapi.com/api/character/avatar/209.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 210, 0, "Lucy", "https://rickandmortyapi.com/api/character/avatar/210.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 214, 3, "Man Painted Silver Who Makes Robot Noises", "https://rickandmortyapi.com/api/character/avatar/214.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 216, 3, "MC Haps", "https://rickandmortyapi.com/api/character/avatar/216.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 175, 3, "Jerry Smith", "https://rickandmortyapi.com/api/character/avatar/175.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 255, 3, "Orthodox Jew", "https://rickandmortyapi.com/api/character/avatar/255.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 260, 3, "Phillip Jacobs", "https://rickandmortyapi.com/api/character/avatar/260.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 295, 3, "Riq IV", "https://rickandmortyapi.com/api/character/avatar/295.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 300, 3, "Roger", "https://rickandmortyapi.com/api/character/avatar/300.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 302, 3, "Ruben", "https://rickandmortyapi.com/api/character/avatar/302.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 303, 0, "Samantha", "https://rickandmortyapi.com/api/character/avatar/303.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 314, 0, "Shmlamantha Shmlicelli", "https://rickandmortyapi.com/api/character/avatar/314.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 315, 0, "Shmlangela Shmlobinson-Shmlower", "https://rickandmortyapi.com/api/character/avatar/315.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 316, 0, "Shmlona Shmlobinson", "https://rickandmortyapi.com/api/character/avatar/316.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 317, 3, "Shmlonathan Shmlower", "https://rickandmortyapi.com/api/character/avatar/317.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 318, 3, "Shmlony Shmlicelli", "https://rickandmortyapi.com/api/character/avatar/318.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 322, 3, "Simple Rick", "https://rickandmortyapi.com/api/character/avatar/322.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 323, 3, "Slaveowner", "https://rickandmortyapi.com/api/character/avatar/323.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 325, 3, "Slick Morty", "https://rickandmortyapi.com/api/character/avatar/325.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 328, 3, "Slow Rick", "https://rickandmortyapi.com/api/character/avatar/328.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 330, 3, "Solicitor Rick", "https://rickandmortyapi.com/api/character/avatar/330.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 332, 0, "Stacy", "https://rickandmortyapi.com/api/character/avatar/332.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 335, 3, "Steve", "https://rickandmortyapi.com/api/character/avatar/335.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 338, 0, "Summer Smith", "https://rickandmortyapi.com/api/character/avatar/338.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 294, 3, "Ricktiminus Sancheziminius", "https://rickandmortyapi.com/api/character/avatar/294.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 257, 3, "Paul Fleishman", "https://rickandmortyapi.com/api/character/avatar/257.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 293, 3, "Rick Sanchez", "https://rickandmortyapi.com/api/character/avatar/293.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 291, 3, "Rick J-22", "https://rickandmortyapi.com/api/character/avatar/291.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 267, 3, "Plumber Rick", "https://rickandmortyapi.com/api/character/avatar/267.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 268, 3, "Poncho", "https://rickandmortyapi.com/api/character/avatar/268.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 272, 3, "Principal Vagina", "https://rickandmortyapi.com/api/character/avatar/272.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 274, 3, "Quantum Rick", "https://rickandmortyapi.com/api/character/avatar/274.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 275, 3, "Randy Dicknose", "https://rickandmortyapi.com/api/character/avatar/275.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 277, 3, "Real Fake Doors Salesman", "https://rickandmortyapi.com/api/character/avatar/277.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 278, 3, "Regional Manager Rick", "https://rickandmortyapi.com/api/character/avatar/278.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 279, 3, "Regular Legs", "https://rickandmortyapi.com/api/character/avatar/279.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 281, 3, "Reverse Rick Outrage", "https://rickandmortyapi.com/api/character/avatar/281.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 283, 3, "Rick D. Sanchez III", "https://rickandmortyapi.com/api/character/avatar/283.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 284, 3, "Rick Guilt Rick", "https://rickandmortyapi.com/api/character/avatar/284.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 285, 3, "Rick Prime", "https://rickandmortyapi.com/api/character/avatar/285.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 286, 3, "Rick D-99", "https://rickandmortyapi.com/api/character/avatar/286.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 287, 3, "Rick D716", "https://rickandmortyapi.com/api/character/avatar/287.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 288, 3, "Rick D716-B", "https://rickandmortyapi.com/api/character/avatar/288.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 289, 3, "Rick D716-C", "https://rickandmortyapi.com/api/character/avatar/289.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 290, 3, "Rick Sanchez", "https://rickandmortyapi.com/api/character/avatar/290.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 292, 3, "Rick K-22", "https://rickandmortyapi.com/api/character/avatar/292.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 339, 0, "Summer Smith", "https://rickandmortyapi.com/api/character/avatar/339.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 174, 3, "Jerry 5-126", "https://rickandmortyapi.com/api/character/avatar/174.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 172, 3, "Jamey", "https://rickandmortyapi.com/api/character/avatar/172.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 43, 3, "Big Morty", "https://rickandmortyapi.com/api/character/avatar/43.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 44, 3, "Body Guard Morty", "https://rickandmortyapi.com/api/character/avatar/44.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 45, 3, "Bill", "https://rickandmortyapi.com/api/character/avatar/45.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 48, 3, "Black Rick", "https://rickandmortyapi.com/api/character/avatar/48.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 52, 3, "Blue Footprint Guy", "https://rickandmortyapi.com/api/character/avatar/52.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 53, 3, "Blue Shirt Morty", "https://rickandmortyapi.com/api/character/avatar/53.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 54, 3, "Bobby Moynihan", "https://rickandmortyapi.com/api/character/avatar/54.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 56, 3, "Bootleg Portal Chemist Rick", "https://rickandmortyapi.com/api/character/avatar/56.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 58, 3, "Brad", "https://rickandmortyapi.com/api/character/avatar/58.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 59, 3, "Brad Anderson", "https://rickandmortyapi.com/api/character/avatar/59.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 60, 0, "Calypso", "https://rickandmortyapi.com/api/character/avatar/60.jpeg", 1, 2, "Superhuman" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 61, 3, "Campaign Manager Morty", "https://rickandmortyapi.com/api/character/avatar/61.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 68, 3, "Colossus", "https://rickandmortyapi.com/api/character/avatar/68.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 69, 3, "Commander Rick", "https://rickandmortyapi.com/api/character/avatar/69.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 72, 3, "Cool Rick", "https://rickandmortyapi.com/api/character/avatar/72.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 73, 3, "Cop Morty", "https://rickandmortyapi.com/api/character/avatar/73.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 74, 3, "Cop Rick", "https://rickandmortyapi.com/api/character/avatar/74.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 42, 3, "Big Head Morty", "https://rickandmortyapi.com/api/character/avatar/42.jpeg", 1, 1, "Human with giant head" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 77, 3, "Cowboy Morty", "https://rickandmortyapi.com/api/character/avatar/77.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 39, 0, "Beth Smith", "https://rickandmortyapi.com/api/character/avatar/39.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 37, 0, "Beth Sanchez", "https://rickandmortyapi.com/api/character/avatar/37.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 2, 3, "Morty Smith", "https://rickandmortyapi.com/api/character/avatar/2.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 3, 0, "Summer Smith", "https://rickandmortyapi.com/api/character/avatar/3.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 4, 0, "Beth Smith", "https://rickandmortyapi.com/api/character/avatar/4.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 5, 3, "Jerry Smith", "https://rickandmortyapi.com/api/character/avatar/5.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 7, 3, "Abradolf Lincler", "https://rickandmortyapi.com/api/character/avatar/7.jpeg", 1, 1, "Genetic experiment" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 8, 3, "Adjudicator Rick", "https://rickandmortyapi.com/api/character/avatar/8.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 9, 3, "Agency Director", "https://rickandmortyapi.com/api/character/avatar/9.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 10, 3, "Alan Rails", "https://rickandmortyapi.com/api/character/avatar/10.jpeg", 1, 2, "Superhuman (Ghost trains summoner)" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 11, 3, "Albert Einstein", "https://rickandmortyapi.com/api/character/avatar/11.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 12, 3, "Alexander", "https://rickandmortyapi.com/api/character/avatar/12.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 17, 0, "Annie", "https://rickandmortyapi.com/api/character/avatar/17.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 18, 3, "Antenna Morty", "https://rickandmortyapi.com/api/character/avatar/18.jpeg", 1, 0, "Human with antennae" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 19, 3, "Antenna Rick", "https://rickandmortyapi.com/api/character/avatar/19.jpeg", 1, 1, "Human with antennae" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 20, 3, "Ants in my Eyes Johnson", "https://rickandmortyapi.com/api/character/avatar/20.jpeg", 1, 1, "Human with ants in his eyes" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 27, 3, "Artist Morty", "https://rickandmortyapi.com/api/character/avatar/27.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 28, 3, "Attila Starwar", "https://rickandmortyapi.com/api/character/avatar/28.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 29, 3, "Baby Legs", "https://rickandmortyapi.com/api/character/avatar/29.jpeg", 1, 0, "Human with baby legs" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 38, 0, "Beth Smith", "https://rickandmortyapi.com/api/character/avatar/38.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 173, 3, "Jan-Michael Vincent", "https://rickandmortyapi.com/api/character/avatar/173.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 78, 3, "Cowboy Rick", "https://rickandmortyapi.com/api/character/avatar/78.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 84, 3, "Cult Leader Morty", "https://rickandmortyapi.com/api/character/avatar/84.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 129, 0, "Fulgora", "https://rickandmortyapi.com/api/character/avatar/129.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 135, 3, "Garment District Rick", "https://rickandmortyapi.com/api/character/avatar/135.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 137, 3, "Gene", "https://rickandmortyapi.com/api/character/avatar/137.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 138, 3, "General Nathan", "https://rickandmortyapi.com/api/character/avatar/138.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 140, 3, "Genital Washer", "https://rickandmortyapi.com/api/character/avatar/140.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 143, 3, "Glasses Morty", "https://rickandmortyapi.com/api/character/avatar/143.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 145, 3, "Glenn", "https://rickandmortyapi.com/api/character/avatar/145.jpeg", 1, 0, "Eat shiter-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 149, 3, "Gordon Lunas", "https://rickandmortyapi.com/api/character/avatar/149.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 156, 3, "Hemorrhage", "https://rickandmortyapi.com/api/character/avatar/156.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 159, 3, "Hunter", "https://rickandmortyapi.com/api/character/avatar/159.jpeg", 1, 2, "Clone" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 160, 3, "Hunter's Father", "https://rickandmortyapi.com/api/character/avatar/160.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 164, 3, "Insurance Rick", "https://rickandmortyapi.com/api/character/avatar/164.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 165, 3, "Investigator Rick", "https://rickandmortyapi.com/api/character/avatar/165.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 166, 3, "Invisi-trooper", "https://rickandmortyapi.com/api/character/avatar/166.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 169, 3, "Jacob", "https://rickandmortyapi.com/api/character/avatar/169.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 170, 0, "Jacqueline", "https://rickandmortyapi.com/api/character/avatar/170.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 171, 3, "Jaguar", "https://rickandmortyapi.com/api/character/avatar/171.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 127, 3, "Frank Palicky", "https://rickandmortyapi.com/api/character/avatar/127.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 80, 0, "Creepy Little Girl", "https://rickandmortyapi.com/api/character/avatar/80.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 124, 3, "Father Bob", "https://rickandmortyapi.com/api/character/avatar/124.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 120, 0, "Evil Summer Clone", "https://rickandmortyapi.com/api/character/avatar/120.jpeg", 1, 2, "Clone" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 88, 0, "Cynthia", "https://rickandmortyapi.com/api/character/avatar/88.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 91, 3, "David Letterman", "https://rickandmortyapi.com/api/character/avatar/91.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 92, 3, "Davin", "https://rickandmortyapi.com/api/character/avatar/92.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 94, 0, "Diane Sanchez", "https://rickandmortyapi.com/api/character/avatar/94.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 95, 2, "Dipper and Mabel Mortys", "https://rickandmortyapi.com/api/character/avatar/95.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 103, 3, "Doofus Rick", "https://rickandmortyapi.com/api/character/avatar/103.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 106, 3, "Dr. Schmidt", "https://rickandmortyapi.com/api/character/avatar/106.jpeg", 1, 1, "Game" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 107, 0, "Dr. Wong", "https://rickandmortyapi.com/api/character/avatar/107.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 110, 3, "Eli", "https://rickandmortyapi.com/api/character/avatar/110.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 111, 0, "Eli's Girlfriend", "https://rickandmortyapi.com/api/character/avatar/111.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 112, 3, "Eric McMan", "https://rickandmortyapi.com/api/character/avatar/112.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 113, 3, "Eric Stoltz Mask Morty", "https://rickandmortyapi.com/api/character/avatar/113.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 114, 3, "Ethan", "https://rickandmortyapi.com/api/character/avatar/114.jpeg", 1, 1, "Cronenberg" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 115, 3, "Ethan", "https://rickandmortyapi.com/api/character/avatar/115.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 116, 0, "Evil Beth Clone", "https://rickandmortyapi.com/api/character/avatar/116.jpeg", 1, 2, "Clone" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 117, 3, "Evil Jerry Clone", "https://rickandmortyapi.com/api/character/avatar/117.jpeg", 1, 2, "Clone" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 118, 3, "Evil Morty", "https://rickandmortyapi.com/api/character/avatar/118.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 123, 3, "Fat Morty", "https://rickandmortyapi.com/api/character/avatar/123.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 79, 2, "Crab Spider", "https://rickandmortyapi.com/api/character/avatar/79.jpeg", 2, 0, "Animal" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 340, 0, "Supernova", "https://rickandmortyapi.com/api/character/avatar/340.jpeg", 1, 0, "Superhuman" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 342, 3, "Taint Washer", "https://rickandmortyapi.com/api/character/avatar/342.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 597, 3, "Abradolf Lincler", "https://rickandmortyapi.com/api/character/avatar/597.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 602, 3, "Cookies Guy", "https://rickandmortyapi.com/api/character/avatar/602.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 605, 0, "Floaty Bloody Man’s Daughter", "https://rickandmortyapi.com/api/character/avatar/605.jpeg", 1, 2, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 608, 3, "Jesus Christ", "https://rickandmortyapi.com/api/character/avatar/608.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 609, 3, "Josh", "https://rickandmortyapi.com/api/character/avatar/609.jpeg", 1, 2, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 610, 0, "Josh's Sister", "https://rickandmortyapi.com/api/character/avatar/610.jpeg", 1, 2, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 612, 3, "Marcus", "https://rickandmortyapi.com/api/character/avatar/612.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 613, 3, "Mike Johnson", "https://rickandmortyapi.com/api/character/avatar/613.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 618, 3, "Private Smith", "https://rickandmortyapi.com/api/character/avatar/618.jpeg", 1, 1, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 619, 3, "Professor Sanchez", "https://rickandmortyapi.com/api/character/avatar/619.jpeg", 1, 2, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 620, 3, "Ramamama Lord", "https://rickandmortyapi.com/api/character/avatar/620.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 621, 0, "Ruth Bader Ginsburg", "https://rickandmortyapi.com/api/character/avatar/621.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 622, 3, "Sarge", "https://rickandmortyapi.com/api/character/avatar/622.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 625, 3, "Storylord", "https://rickandmortyapi.com/api/character/avatar/625.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 626, 0, "Tammy Guetermann", "https://rickandmortyapi.com/api/character/avatar/626.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 628, 0, "Beth Smith", "https://rickandmortyapi.com/api/character/avatar/628.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 629, 0, "Summer Smith", "https://rickandmortyapi.com/api/character/avatar/629.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 594, 3, "Floaty Bloody Man", "https://rickandmortyapi.com/api/character/avatar/594.jpeg", 1, 2, "Half Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 630, 3, "Morty Smith", "https://rickandmortyapi.com/api/character/avatar/630.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 593, 3, "Tickets Please Guy", "https://rickandmortyapi.com/api/character/avatar/593.jpeg", 1, 2, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 590, 3, "High Pilot", "https://rickandmortyapi.com/api/character/avatar/590.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 514, 0, "Public Opinion Judge", "https://rickandmortyapi.com/api/character/avatar/514.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 526, 3, "Danny Publitz", "https://rickandmortyapi.com/api/character/avatar/526.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 535, 3, "Jeff", "https://rickandmortyapi.com/api/character/avatar/535.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 536, 3, "Josiah", "https://rickandmortyapi.com/api/character/avatar/536.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 537, 0, "Maggie", "https://rickandmortyapi.com/api/character/avatar/537.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 538, 3, "Priest Witherspoon", "https://rickandmortyapi.com/api/character/avatar/538.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 539, 3, "Richard", "https://rickandmortyapi.com/api/character/avatar/539.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 540, 3, "Running Bird", "https://rickandmortyapi.com/api/character/avatar/540.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 542, 3, "Mountain Sweat Jerry", "https://rickandmortyapi.com/api/character/avatar/542.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 546, 0, "Angie Flint", "https://rickandmortyapi.com/api/character/avatar/546.jpeg", 1, 0, "Cyborg" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 558, 3, "Elon Tusk", "https://rickandmortyapi.com/api/character/avatar/558.jpeg", 1, 0, "Human with tusks" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 561, 3, "Netflix Executive", "https://rickandmortyapi.com/api/character/avatar/561.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 563, 3, "The Wizard", "https://rickandmortyapi.com/api/character/avatar/563.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 584, 3, "Bar Customer", "https://rickandmortyapi.com/api/character/avatar/584.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 585, 0, "Bartender", "https://rickandmortyapi.com/api/character/avatar/585.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 586, 3, "PC Basketball Player", "https://rickandmortyapi.com/api/character/avatar/586.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 588, 3, "Pet Shop Employee", "https://rickandmortyapi.com/api/character/avatar/588.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 591, 3, "High Pilot", "https://rickandmortyapi.com/api/character/avatar/591.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 513, 0, "Judge", "https://rickandmortyapi.com/api/character/avatar/513.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 631, 3, "Rick Sanchez", "https://rickandmortyapi.com/api/character/avatar/631.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 633, 0, "Train Cops", "https://rickandmortyapi.com/api/character/avatar/633.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 24, 3, "Armagheadon", "https://rickandmortyapi.com/api/character/avatar/24.jpeg", 2, 0, "Cromulon" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 26, 0, "Arthricia", "https://rickandmortyapi.com/api/character/avatar/26.jpeg", 2, 0, "Cat-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 31, 3, "Baby Wizard", "https://rickandmortyapi.com/api/character/avatar/31.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 32, 0, "Bearded Lady", "https://rickandmortyapi.com/api/character/avatar/32.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 33, 3, "Beebo", "https://rickandmortyapi.com/api/character/avatar/33.jpeg", 2, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 35, 2, "Bepisian", "https://rickandmortyapi.com/api/character/avatar/35.jpeg", 2, 0, "Bepisian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 36, 2, "Beta-Seven", "https://rickandmortyapi.com/api/character/avatar/36.jpeg", 2, 0, "Hivemind" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 47, 3, "Birdperson", "https://rickandmortyapi.com/api/character/avatar/47.jpeg", 2, 2, "Bird-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 49, 2, "Blamph", "https://rickandmortyapi.com/api/character/avatar/49.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 50, 3, "Blim Blam", "https://rickandmortyapi.com/api/character/avatar/50.jpeg", 2, 0, "Korblock" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 51, 3, "Blue Diplomat", "https://rickandmortyapi.com/api/character/avatar/51.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 55, 2, "Boobloosian", "https://rickandmortyapi.com/api/character/avatar/55.jpeg", 2, 2, "Boobloosian" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 57, 3, "Borpocian", "https://rickandmortyapi.com/api/character/avatar/57.jpeg", 2, 0, "Elephant-Person" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 62, 3, "Canklanker Thom", "https://rickandmortyapi.com/api/character/avatar/62.jpeg", 2, 2, "Gromflomite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 64, 2, "Chris", "https://rickandmortyapi.com/api/character/avatar/64.jpeg", 2, 2, "Organic gun" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 67, 3, "Collector", "https://rickandmortyapi.com/api/character/avatar/67.jpeg", 2, 0, "Light bulb-Alien" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 75, 2, "Courier Flap", "https://rickandmortyapi.com/api/character/avatar/75.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 23, 3, "Arcade Alien", "https://rickandmortyapi.com/api/character/avatar/23.jpeg", 2, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 632, 3, "Train Cop", "https://rickandmortyapi.com/api/character/avatar/632.jpeg", 1, 2, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 16, 3, "Amish Cyborg", "https://rickandmortyapi.com/api/character/avatar/16.jpeg", 2, 2, "Parasite" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 14, 3, "Alien Morty", "https://rickandmortyapi.com/api/character/avatar/14.jpeg", 2, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 634, 3, "Train Cops Instructor", "https://rickandmortyapi.com/api/character/avatar/634.jpeg", 1, 2, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 636, 3, "Evil Morty", "https://rickandmortyapi.com/api/character/avatar/636.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 637, 0, "Morty’s Disguise", "https://rickandmortyapi.com/api/character/avatar/637.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 638, 3, "Rick’s Disguise", "https://rickandmortyapi.com/api/character/avatar/638.jpeg", 1, 0, "Soulless Puppet" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 652, 3, "SWAT Officer", "https://rickandmortyapi.com/api/character/avatar/652.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 653, 0, "Plane Crash Survivor", "https://rickandmortyapi.com/api/character/avatar/653.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 654, 3, "Plane Crash Survivor", "https://rickandmortyapi.com/api/character/avatar/654.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 655, 3, "Heroine Keith", "https://rickandmortyapi.com/api/character/avatar/655.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 656, 3, "Impervious to Acid SWAT Officer", "https://rickandmortyapi.com/api/character/avatar/656.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 657, 3, "Johnny Carson", "https://rickandmortyapi.com/api/character/avatar/657.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 658, 0, "Sonia Sotomayor", "https://rickandmortyapi.com/api/character/avatar/658.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 659, 3, "Morty’s Father-in-law", "https://rickandmortyapi.com/api/character/avatar/659.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 660, 0, "Morty’s Mother-in-law", "https://rickandmortyapi.com/api/character/avatar/660.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 661, 0, "Morty’s Girlfriend", "https://rickandmortyapi.com/api/character/avatar/661.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 667, 0, "Defiance Beth", "https://rickandmortyapi.com/api/character/avatar/667.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 6, 0, "Abadango Cluster Princess", "https://rickandmortyapi.com/api/character/avatar/6.jpeg", 2, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 13, 2, "Alien Googah", "https://rickandmortyapi.com/api/character/avatar/13.jpeg", 2, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 15, 3, "Alien Rick", "https://rickandmortyapi.com/api/character/avatar/15.jpeg", 2, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 341, 3, "Taddy Mason", "https://rickandmortyapi.com/api/character/avatar/341.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 512, 3, "Morty’s Lawyer", "https://rickandmortyapi.com/api/character/avatar/512.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 510, 3, "Anchorman", "https://rickandmortyapi.com/api/character/avatar/510.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 402, 3, "Guy from The Bachelor", "https://rickandmortyapi.com/api/character/avatar/402.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 405, 3, "Trunkphobic suspenders guy", "https://rickandmortyapi.com/api/character/avatar/405.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 407, 3, "Regular Tyrion Lannister", "https://rickandmortyapi.com/api/character/avatar/407.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 408, 3, "Quick Mystery Presenter", "https://rickandmortyapi.com/api/character/avatar/408.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 409, 3, "Mr. Sneezy", "https://rickandmortyapi.com/api/character/avatar/409.jpeg", 1, 0, "Little Human" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 410, 3, "Two Brothers", "https://rickandmortyapi.com/api/character/avatar/410.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 413, 0, "Old Women", "https://rickandmortyapi.com/api/character/avatar/413.jpeg", 1, 1, "Old Amazons" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 414, 3, "Trunkphobic guy", "https://rickandmortyapi.com/api/character/avatar/414.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 415, 3, "Pro trunk people marriage guy", "https://rickandmortyapi.com/api/character/avatar/415.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 416, 3, "Muscular Mannie", "https://rickandmortyapi.com/api/character/avatar/416.jpeg", 1, 0, "Mannie" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 417, 3, "Baby Legs Chief", "https://rickandmortyapi.com/api/character/avatar/417.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 418, 3, "Mrs. Sullivan's Boyfriend", "https://rickandmortyapi.com/api/character/avatar/418.jpeg", 1, 0, "Necrophiliac" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 426, 0, "Greasy Grandma", "https://rickandmortyapi.com/api/character/avatar/426.jpeg", 1, 0, "Grandma" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 434, 3, "Super Weird Rick", "https://rickandmortyapi.com/api/character/avatar/434.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 437, 3, "Michael", "https://rickandmortyapi.com/api/character/avatar/437.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 438, 3, "Michael's Lawyer", "https://rickandmortyapi.com/api/character/avatar/438.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 439, 0, "Veterinary", "https://rickandmortyapi.com/api/character/avatar/439.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 401, 3, "Morty Jr's interviewer", "https://rickandmortyapi.com/api/character/avatar/401.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 440, 3, "Veterinary Nurse", "https://rickandmortyapi.com/api/character/avatar/440.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 393, 3, "Roy", "https://rickandmortyapi.com/api/character/avatar/393.jpeg", 1, 0, "Game" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 389, 3, "Zeta Alpha Rick", "https://rickandmortyapi.com/api/character/avatar/389.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 344, 0, "Tammy Guetermann", "https://rickandmortyapi.com/api/character/avatar/344.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 345, 3, "Teacher Rick", "https://rickandmortyapi.com/api/character/avatar/345.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 346, 3, "Terry", "https://rickandmortyapi.com/api/character/avatar/346.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 347, 3, "The President", "https://rickandmortyapi.com/api/character/avatar/347.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 349, 3, "The Scientist Formerly Known as Rick", "https://rickandmortyapi.com/api/character/avatar/349.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 350, 3, "Thomas Lipkip", "https://rickandmortyapi.com/api/character/avatar/350.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 353, 3, "Tiny Rick", "https://rickandmortyapi.com/api/character/avatar/353.jpeg", 1, 2, "Clone" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 354, 3, "Toby Matthews", "https://rickandmortyapi.com/api/character/avatar/354.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 356, 3, "Tom Randolph", "https://rickandmortyapi.com/api/character/avatar/356.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 357, 3, "Tommy's Clone", "https://rickandmortyapi.com/api/character/avatar/357.jpeg", 1, 0, "Clone" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 359, 3, "Tortured Morty", "https://rickandmortyapi.com/api/character/avatar/359.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 365, 0, "Tricia Lange", "https://rickandmortyapi.com/api/character/avatar/365.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 370, 3, "Two Guys with Handlebar Mustaches", "https://rickandmortyapi.com/api/character/avatar/370.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 373, 3, "Unmuscular Michael", "https://rickandmortyapi.com/api/character/avatar/373.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 375, 3, "Vance Maximus", "https://rickandmortyapi.com/api/character/avatar/375.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 380, 3, "Weird Rick", "https://rickandmortyapi.com/api/character/avatar/380.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 385, 3, "Yellow Shirt Rick", "https://rickandmortyapi.com/api/character/avatar/385.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 392, 3, "Bearded Morty", "https://rickandmortyapi.com/api/character/avatar/392.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 511, 0, "Anchorwoman", "https://rickandmortyapi.com/api/character/avatar/511.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 441, 3, "Bearded Jerry", "https://rickandmortyapi.com/api/character/avatar/441.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 443, 3, "Tank Top Jerry", "https://rickandmortyapi.com/api/character/avatar/443.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 481, 3, "Retired General Rick", "https://rickandmortyapi.com/api/character/avatar/481.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 482, 3, "Secret Service Rick", "https://rickandmortyapi.com/api/character/avatar/482.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 483, 3, "Steve Jobs Rick", "https://rickandmortyapi.com/api/character/avatar/483.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 484, 3, "Sheik Rick", "https://rickandmortyapi.com/api/character/avatar/484.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 485, 3, "Modern Rick", "https://rickandmortyapi.com/api/character/avatar/485.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 486, 3, "Tan Rick", "https://rickandmortyapi.com/api/character/avatar/486.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 487, 3, "Visor Rick", "https://rickandmortyapi.com/api/character/avatar/487.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 488, 3, "Colonial Rick", "https://rickandmortyapi.com/api/character/avatar/488.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 489, 3, "P-Coat Rick", "https://rickandmortyapi.com/api/character/avatar/489.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 490, 3, "Chang", "https://rickandmortyapi.com/api/character/avatar/490.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 491, 0, "Dr. Eleanor Arroway", "https://rickandmortyapi.com/api/character/avatar/491.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 493, 3, "Secretary of the Interior", "https://rickandmortyapi.com/api/character/avatar/493.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 498, 3, "Fascist Rick", "https://rickandmortyapi.com/api/character/avatar/498.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 499, 3, "Fascist Morty", "https://rickandmortyapi.com/api/character/avatar/499.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 500, 3, "Fascist Mr. President", "https://rickandmortyapi.com/api/character/avatar/500.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 501, 3, "Fascist Rick’s Clone", "https://rickandmortyapi.com/api/character/avatar/501.jpeg", 1, 2, "Clone" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 509, 3, "Bully", "https://rickandmortyapi.com/api/character/avatar/509.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 479, 3, "Private Sector Rick", "https://rickandmortyapi.com/api/character/avatar/479.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 442, 3, "Shaved Head Jerry", "https://rickandmortyapi.com/api/character/avatar/442.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 478, 3, "Journalist Rick", "https://rickandmortyapi.com/api/character/avatar/478.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 476, 3, "Flower Morty", "https://rickandmortyapi.com/api/character/avatar/476.jpeg", 1, 0, "Human with a flower in his head" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 444, 3, "Pink Polo Shirt Jerry", "https://rickandmortyapi.com/api/character/avatar/444.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 449, 0, "Roy's Mum", "https://rickandmortyapi.com/api/character/avatar/449.jpeg", 1, 0, "Game" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 450, 3, "Roy's Wife", "https://rickandmortyapi.com/api/character/avatar/450.jpeg", 1, 0, "Game" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 451, 3, "Roy's Son", "https://rickandmortyapi.com/api/character/avatar/451.jpeg", 1, 0, "Game" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 452, 3, "Simon", "https://rickandmortyapi.com/api/character/avatar/452.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 457, 3, "Funny Songs Presenter", "https://rickandmortyapi.com/api/character/avatar/457.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 458, 3, "Tax Attorney", "https://rickandmortyapi.com/api/character/avatar/458.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 461, 3, "Communication's Responsible Rick", "https://rickandmortyapi.com/api/character/avatar/461.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 462, 3, "Teleportation's Responsible Rick", "https://rickandmortyapi.com/api/character/avatar/462.jpeg", 1, 1, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 463, 3, "SEAL Team Rick", "https://rickandmortyapi.com/api/character/avatar/463.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 464, 3, "SEAL Team Rick", "https://rickandmortyapi.com/api/character/avatar/464.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 465, 3, "SEAL Team Rick", "https://rickandmortyapi.com/api/character/avatar/465.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 466, 3, "SEAL Team Rick", "https://rickandmortyapi.com/api/character/avatar/466.jpeg", 1, 2, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 472, 3, "Baby Rick", "https://rickandmortyapi.com/api/character/avatar/472.jpeg", 1, 0, "Clone" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 473, 3, "Bartender Morty", "https://rickandmortyapi.com/api/character/avatar/473.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 474, 3, "Dancer Cowboy Morty", "https://rickandmortyapi.com/api/character/avatar/474.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 475, 3, "Dancer Morty", "https://rickandmortyapi.com/api/character/avatar/475.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 477, 3, "Hairdresser Rick", "https://rickandmortyapi.com/api/character/avatar/477.jpeg", 1, 0, "" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Gender", "Name", "PictureUrl", "SpeciesId", "Status", "Type" },
                values: new object[] { 662, 0, "Gaia", "https://rickandmortyapi.com/api/character/avatar/662.jpeg", 11, 0, "" });

            migrationBuilder.CreateIndex(
                name: "IX_Character_SpeciesId",
                table: "Character",
                column: "SpeciesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropTable(
                name: "Species");
        }
    }
}
