using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Vacancies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_CityId",
                table: "Vacancies",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Cities_CityId",
                table: "Vacancies",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Cities_CityId",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_Vacancies_CityId",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Vacancies");
        }
    }
}
