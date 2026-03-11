using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebServerDevFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddJaxonSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jaxon",
                columns: table => new
                {
                    JaxonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Environment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HobbyAge = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jaxon", x => x.JaxonId);
                });

            migrationBuilder.InsertData(
                table: "Jaxon",
                columns: new[] { "JaxonId", "Category", "Description", "Environment", "HobbyAge", "HobbyName", "SkillLevel" },
                values: new object[,]
                {
                    { 1, "Sports", "I like to play basketball with my friends at the park.", "Outdoor", 10, "Playing Basketball", "Beginner" },
                    { 2, "Gaming", "I like to play video games on my PlayStation with my friends.", "Indoor", 8, "Playing Video Games", "Expert" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jaxon");
        }
    }
}
