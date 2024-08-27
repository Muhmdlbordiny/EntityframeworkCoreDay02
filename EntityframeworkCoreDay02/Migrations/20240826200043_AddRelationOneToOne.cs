using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityframeworkCoreDay02.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Department_EmpId",
                table: "Department",
                column: "EmpId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employees_EmpId",
                table: "Department",
                column: "EmpId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employees_EmpId",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_EmpId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "Department");
        }
    }
}
