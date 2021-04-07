using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBasics.Migrations
{
    public partial class Employee_DeptAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "EmployeeModel",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "EmployeeModel");
        }
    }
}
