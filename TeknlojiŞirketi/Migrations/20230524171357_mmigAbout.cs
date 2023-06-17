using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeknlojiŞirketi.Migrations
{
    public partial class mmigAbout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Details1",
                table: "Abouts",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Details1",
                table: "Abouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 5000);
        }
    }
}
