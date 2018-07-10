using Microsoft.EntityFrameworkCore.Migrations;

namespace HWLib.Migrations
{
    public partial class messagetextlen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MessageText",
                table: "MessageLog",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MessageText",
                table: "MessageLog",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");
        }
    }
}
