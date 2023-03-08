using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tactsoft.Data.Data.Migrations
{
    public partial class addTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LeaveTypeName",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AwardTypeName",
                table: "AwardTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AllowensName",
                table: "Allowenss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AdvanceTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvanceTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvanceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentHistories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    NameOfCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignationId = table.Column<long>(type: "bigint", nullable: true),
                    JobFor = table.Column<DateTime>(type: "Date", nullable: false),
                    JobTo = table.Column<DateTime>(type: "Date", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    ReasonForLeaving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmploymentHistories_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmploymentHistories_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nominees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    NomineeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    percentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelationShipId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nominees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nominees_Relationships_RelationShipId",
                        column: x => x.RelationShipId,
                        principalTable: "Relationships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nid = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Advances",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    AdvanceTypeId = table.Column<long>(type: "bigint", nullable: false),
                    AdvanceDate = table.Column<DateTime>(type: "Date", nullable: false),
                    ApproveAmount = table.Column<double>(type: "float", nullable: false),
                    MonthlyDeduction = table.Column<double>(type: "float", nullable: false),
                    DisburseYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisburseMonth = table.Column<int>(type: "int", nullable: false),
                    ApproveBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advances_AdvanceTypes_AdvanceTypeId",
                        column: x => x.AdvanceTypeId,
                        principalTable: "AdvanceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Advances_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AdvanceTypes",
                columns: new[] { "Id", "AdvanceTypeName", "CreatedBy", "CreatedDateUtc", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, "Advance Salary", 0L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), null, null });

            migrationBuilder.InsertData(
                table: "EmploymentHistories",
                columns: new[] { "Id", "CreatedBy", "CreatedDateUtc", "DesignationId", "EmployeeId", "JobFor", "JobTo", "NameOfCompany", "ReasonForLeaving", "Salary", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, 0L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), null, 1L, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Us Bangla", "abcd", 85000.0, null, null });

            migrationBuilder.InsertData(
                table: "Nominees",
                columns: new[] { "Id", "Address", "ContactNumber", "CreatedBy", "CreatedDateUtc", "EmployeeId", "NomineeName", "RelationShipId", "UpdatedBy", "UpdatedDateUtc", "percentage" },
                values: new object[] { 1L, "Mirpur", "018213256442", 0L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), 1L, "Kabir", 1L, null, null, "100%" });

            migrationBuilder.InsertData(
                table: "References",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDateUtc", "MobileNumber", "Nid", "Phone", "ReferenceName", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, "Mirpur", 0L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), "023256589522", 56588552685.0, "01213256442", "Kamal", null, null });

            migrationBuilder.InsertData(
                table: "Advances",
                columns: new[] { "Id", "AdvanceDate", "AdvanceTypeId", "ApproveAmount", "ApproveBy", "CreatedBy", "CreatedDateUtc", "DisburseMonth", "DisburseYear", "EmployeeId", "MonthlyDeduction", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[] { 1L, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 10000.0, "Arif", 0L, new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)), 0, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 2000.0, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Advances_AdvanceTypeId",
                table: "Advances",
                column: "AdvanceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Advances_EmployeeId",
                table: "Advances",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentHistories_DesignationId",
                table: "EmploymentHistories",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentHistories_EmployeeId",
                table: "EmploymentHistories",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Nominees_EmployeeId",
                table: "Nominees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Nominees_RelationShipId",
                table: "Nominees",
                column: "RelationShipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advances");

            migrationBuilder.DropTable(
                name: "EmploymentHistories");

            migrationBuilder.DropTable(
                name: "Nominees");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "AdvanceTypes");

            migrationBuilder.AlterColumn<string>(
                name: "LeaveTypeName",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AwardTypeName",
                table: "AwardTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AllowensName",
                table: "Allowenss",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
