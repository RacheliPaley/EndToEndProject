using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBContext.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChildsContext_UserContext_PareentId",
                table: "ChildsContext");

            migrationBuilder.DropIndex(
                name: "IX_ChildsContext_PareentId",
                table: "ChildsContext");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ChildsContext_PareentId",
                table: "ChildsContext",
                column: "PareentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChildsContext_UserContext_PareentId",
                table: "ChildsContext",
                column: "PareentId",
                principalTable: "UserContext",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
