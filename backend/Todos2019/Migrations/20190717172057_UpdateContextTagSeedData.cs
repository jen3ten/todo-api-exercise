using Microsoft.EntityFrameworkCore.Migrations;

namespace Todos2019.Migrations
{
    public partial class UpdateContextTagSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_ToDos_ToDoId",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameIndex(
                name: "IX_Tag_ToDoId",
                table: "Tags",
                newName: "IX_Tags_ToDoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name", "ToDoId" },
                values: new object[,]
                {
                    { 1, "Difficult", 1 },
                    { 2, "8:00 am", 1 },
                    { 3, "Eggs", 2 },
                    { 4, "Important", 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_ToDos_ToDoId",
                table: "Tags",
                column: "ToDoId",
                principalTable: "ToDos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_ToDos_ToDoId",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_ToDoId",
                table: "Tag",
                newName: "IX_Tag_ToDoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_ToDos_ToDoId",
                table: "Tag",
                column: "ToDoId",
                principalTable: "ToDos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
