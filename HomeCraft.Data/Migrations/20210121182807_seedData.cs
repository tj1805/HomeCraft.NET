using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeCraft.Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Let us test", "Testing One" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"));
        }
    }
}
