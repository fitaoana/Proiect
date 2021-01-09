using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.Migrations
{
    public partial class AddedSpecializaton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpecializationID",
                table: "Doctor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Specialization",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialization", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_SpecializationID",
                table: "Doctor",
                column: "SpecializationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Specialization_SpecializationID",
                table: "Doctor",
                column: "SpecializationID",
                principalTable: "Specialization",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Specialization_SpecializationID",
                table: "Doctor");

            migrationBuilder.DropTable(
                name: "Specialization");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_SpecializationID",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "SpecializationID",
                table: "Doctor");
        }
    }
}
