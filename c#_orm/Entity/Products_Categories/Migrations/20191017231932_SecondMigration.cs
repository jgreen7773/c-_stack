using Microsoft.EntityFrameworkCore.Migrations;

namespace Products_Categories.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Associations_CategoryId",
                table: "Associations",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Associations_ProductId",
                table: "Associations",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Categories_CategoryId",
                table: "Associations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Products_ProductId",
                table: "Associations",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Categories_CategoryId",
                table: "Associations");

            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Products_ProductId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_CategoryId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_ProductId",
                table: "Associations");
        }
    }
}
