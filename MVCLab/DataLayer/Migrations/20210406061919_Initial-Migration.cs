using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBasics.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeModel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 10, nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Mobile = table.Column<string>(maxLength: 10, nullable: true),
                    City = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeModel");
        }
    }
}
