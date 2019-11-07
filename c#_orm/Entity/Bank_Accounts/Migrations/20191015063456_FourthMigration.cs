using Microsoft.EntityFrameworkCore.Migrations;

namespace Bank_Accounts.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Transactions",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Transactions",
                nullable: true,
                oldClrType: typeof(decimal));
        }
    }
}
