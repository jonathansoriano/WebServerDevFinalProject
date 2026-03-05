using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebServerDevFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationWithData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jon",
                columns: table => new
                {
                    JonId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Jon", x => x.JonId);
                });

            migrationBuilder.InsertData(
                table: "Jon",
                columns: new[] { "JonId", "Category", "Description", "Environment", "HobbyAge", "HobbyName", "SkillLevel" },
                values: new object[,]
                {
                    { 1, "Automotive", "I collect sporty Hot Wheel Cars.", "Indoor", 15, "Hot Wheel Collecting", "Beginner" },
                    { 2, "Gaming", "I like to play first shooter games like Call of Duty on the weekends", "Indoor", 5, "Playing First Shooter Games", "Intermediate" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jon");
        }
    }
}
