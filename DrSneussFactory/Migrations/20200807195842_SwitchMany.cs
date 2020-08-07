using Microsoft.EntityFrameworkCore.Migrations;

namespace DrSneussFactory.Migrations
{
    public partial class SwitchMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EngineerId1",
                table: "Machines",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Machines_EngineerId1",
                table: "Machines",
                column: "EngineerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Engineers_EngineerId1",
                table: "Machines",
                column: "EngineerId1",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Engineers_EngineerId1",
                table: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_Machines_EngineerId1",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "EngineerId1",
                table: "Machines");
        }
    }
}
