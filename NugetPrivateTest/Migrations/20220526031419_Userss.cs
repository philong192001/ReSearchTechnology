using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NugetPrivateTest.Migrations
{
    public partial class Userss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_Address_AddressId",
                table: "users");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_users_AddressId",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "users",
                newName: "Address_MyProperty");

            migrationBuilder.AddColumn<int>(
                name: "Address_Id",
                table: "users",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_Id",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "Address_MyProperty",
                table: "users",
                newName: "AddressId");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    MyProperty = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_AddressId",
                table: "users",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_Address_AddressId",
                table: "users",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
