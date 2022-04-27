using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce_App_Practices_1.Migrations
{
    public partial class Ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Movies",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Movies",
                type: "double",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
