using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tactsoft.Data.Data.Migrations
{
    public partial class insrtnewdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EmploymentHistories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DesignationId",
                value: 1L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EmploymentHistories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DesignationId",
                value: null);
        }
    }
}
