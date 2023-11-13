using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionService.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Items_AuctionId",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Auctions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Items_AuctionId",
                table: "Items",
                column: "AuctionId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Items_AuctionId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Auctions");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AuctionId",
                table: "Items",
                column: "AuctionId");
        }
    }
}
