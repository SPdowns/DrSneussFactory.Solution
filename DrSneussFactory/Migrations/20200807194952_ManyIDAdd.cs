using Microsoft.EntityFrameworkCore.Migrations;

namespace DrSneussFactory.Migrations
{
    public partial class ManyIDAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EngineerId",
                table: "Machines",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Engineers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EngineerId",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Engineers");
        }
    }
}
