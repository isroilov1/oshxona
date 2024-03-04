using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oshhona.Migrations
{
    /// <inheritdoc />
    public partial class AddFoodTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Foods",
                newName: "FoodTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                newName: "IX_Foods_FoodTypeId");

            migrationBuilder.CreateTable(
                name: "FoodType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodType_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodType_CategoryId",
                table: "FoodType",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_FoodType_FoodTypeId",
                table: "Foods",
                column: "FoodTypeId",
                principalTable: "FoodType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_FoodType_FoodTypeId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "FoodType");

            migrationBuilder.RenameColumn(
                name: "FoodTypeId",
                table: "Foods",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Foods_FoodTypeId",
                table: "Foods",
                newName: "IX_Foods_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
