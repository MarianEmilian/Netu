using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDoItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 1, new DateTime(2020, 11, 8, 21, 32, 44, 954, DateTimeKind.Local).AddTicks(6120), "Server", false });

            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 2, new DateTime(2020, 11, 9, 1, 32, 44, 957, DateTimeKind.Local).AddTicks(7924), "API", false });

            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 3, new DateTime(2020, 11, 8, 20, 32, 44, 957, DateTimeKind.Local).AddTicks(8285), "Client", false });

            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "Id", "Created", "Description", "IsDone" },
                values: new object[] { 4, new DateTime(2020, 11, 8, 14, 32, 44, 957, DateTimeKind.Local).AddTicks(8306), "Front", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoItems");
        }
    }
}
