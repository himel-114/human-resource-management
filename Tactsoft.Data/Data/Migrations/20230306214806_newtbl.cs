using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tactsoft.Data.Data.Migrations
{
    public partial class newtbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvanceTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AllowanceSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AllowensDetailss",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Allowenss",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AttachmentsType",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AttachmentsType",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Attandances",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AwardTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BranchInfos",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "CompanyInfos",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Deductions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmploymentHistories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FamilyMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LeaveApplications",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "MaritialStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "MaritialStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "MaritialStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Nominees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Relationships",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Religions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Religions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Religions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Religions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SalarySetups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SalaryType",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceInfos",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -8, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvanceTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Advances",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AllowanceSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AllowensDetailss",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Allowenss",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AttachmentsType",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AttachmentsType",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Attandances",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AwardTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BloodGroups",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "BranchInfos",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "CompanyInfos",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Deductions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmploymentHistories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "FamilyMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LeaveApplications",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "MaritialStatuses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "MaritialStatuses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "MaritialStatuses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Nominees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Relationships",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Religions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Religions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Religions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Religions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SalarySetups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SalaryType",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ServiceInfos",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ZipCodes",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDateUtc",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 0, 0, 0)));
        }
    }
}
