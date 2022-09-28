using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTasks.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductMainCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mainCategoryCode = table.Column<int>(type: "int", nullable: false),
                    mainCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMainCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryCode = table.Column<int>(type: "int", nullable: false),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategories_ProductMainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "ProductMainCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subCategoryCode = table.Column<int>(type: "int", nullable: false),
                    subCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubCategories_ProductCategories_productCategoryId",
                        column: x => x.productCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_MainCategoryId",
                table: "ProductCategories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategories_productCategoryId",
                table: "ProductSubCategories",
                column: "productCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSubCategories");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductMainCategories");
        }
    }
}
