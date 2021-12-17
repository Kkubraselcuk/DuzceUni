using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUni.Migrations
{
    public partial class DirectorBoard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DirectorBoards",
                columns: table => new
                {
                    DirectorBoardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorBoardName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorBoards", x => x.DirectorBoardId);
                    table.ForeignKey(
                        name: "FK_DirectorBoards_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "WorkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DirectorBoards_WorkId",
                table: "DirectorBoards",
                column: "WorkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DirectorBoards");
        }
    }
}
