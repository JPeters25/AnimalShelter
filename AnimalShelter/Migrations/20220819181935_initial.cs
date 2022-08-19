using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Breed = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 2, "Mini-Daschund", "Male", "Henry", "Dog" },
                    { 2, 1, "Mini-Daschund", "Female", "Ellie", "Dog" },
                    { 3, 14, "Beagle Bassett Hound", "Male", "Cooper", "Dog" },
                    { 4, 4, "Tuxedo", "Female", "Sofie", "Cat" },
                    { 5, 3, "American Shorthair", "Male", "Maverick", "Cat" },
                    { 6, 5, "Black Lab", "Male", "George", "Dog" },
                    { 7, 7, "Pomeranian", "Female", "Feida", "Dog" },
                    { 8, 6, "Cocker Spaniel", "Female", "Lucy", "Dog" },
                    { 9, 3, "Golden Retriever", "Female", "Sally", "Dog" },
                    { 10, 8, "Bulldog", "Male", "Charlie", "Dog" },
                    { 11, 2, "Golden Doodle", "Male", "Linus", "Dog" },
                    { 12, 4, "Munchkin", "Male", "Boots", "Cat" },
                    { 13, 3, "Persian", "Female", "Maire", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
