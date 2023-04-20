using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sales_Management_Using_blazor_syncfusion.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpJobTitleId",
                table: "Employees",
                newName: "EmployeeJobTitleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeJobTitleId",
                table: "Employees",
                newName: "EmpJobTitleId");
        }
    }
}
