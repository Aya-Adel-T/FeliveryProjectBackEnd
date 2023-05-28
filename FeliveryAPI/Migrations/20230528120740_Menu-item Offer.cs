using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FeliveryAPI.Migrations
{
    /// <inheritdoc />
    public partial class MenuitemOffer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56c1adcd-f7ae-45fc-8cd9-382dfd18f66b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82742b0f-54e7-4412-bda5-9dbcc84df667");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2e683a8-2afc-4bcc-a849-94eadf3fa84c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e69df621-cc66-4917-9c5a-586cc43f39e8");

            migrationBuilder.AddColumn<bool>(
                name: "IsOffer",
                table: "MenuItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72e595a7-ab61-4d19-8be4-b89aecef4566", "4", "Customer", "Customer" },
                    { "7effd054-8253-4ea8-82ad-f76d05f0d016", "1", "Admin", "Admin" },
                    { "8f0751be-2ce4-4cf4-8799-2b293d874905", "2", "ApprovedStore", "ApprovedStore" },
                    { "a1da6cbf-c914-44a0-8628-702b44515329", "3", "PendingStore", "PendingStore" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72e595a7-ab61-4d19-8be4-b89aecef4566");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7effd054-8253-4ea8-82ad-f76d05f0d016");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f0751be-2ce4-4cf4-8799-2b293d874905");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1da6cbf-c914-44a0-8628-702b44515329");

            migrationBuilder.DropColumn(
                name: "IsOffer",
                table: "MenuItems");

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfferImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfferPrice = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "56c1adcd-f7ae-45fc-8cd9-382dfd18f66b", "4", "Customer", "Customer" },
                    { "82742b0f-54e7-4412-bda5-9dbcc84df667", "1", "Admin", "Admin" },
                    { "c2e683a8-2afc-4bcc-a849-94eadf3fa84c", "3", "PendingStore", "PendingStore" },
                    { "e69df621-cc66-4917-9c5a-586cc43f39e8", "2", "ApprovedStore", "ApprovedStore" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_RestaurantId",
                table: "Offers",
                column: "RestaurantId");
        }
    }
}
