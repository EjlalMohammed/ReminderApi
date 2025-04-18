using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixPendingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateAt", "CreateById", "Name", "UpdateAt", "UpdateById" },
                values: new object[,]
                {
                    { new Guid("8a2af4cd-355d-49c3-863c-cd1017895e57"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", "User", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("8a2af4cd-355d-49c3-863c-cd1017895e59"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8a2af4cd-355d-49c3-863c-cd1017895e57"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8a2af4cd-355d-49c3-863c-cd1017895e59"));
        }
    }
}
