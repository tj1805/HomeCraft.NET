using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeCraft.Data.Migrations
{
    public partial class addShoppingCartFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnailUrl",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "InStock",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPieOfTheWeek",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ShopingCartId = table.Column<string>(nullable: true),
                    ShoppingCartItemid = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                columns: new[] { "ImageUrl", "LongDescription", "Price", "ShortDescription" },
                values: new object[] { "https://cdn.pixabay.com/photo/2016/04/18/13/53/room-1336497_960_720.jpg", "Donec tempus, sem a sollicitudin cursus, lectus quam vulputate risus, id hendrerit lorem eros varius ipsum. Nunc posuere ac arcu consequat suscipit. Proin turpis erat, ornare id nisl vel, rhoncus accumsan nibh. Sed fringilla odio vel interdum blandit. Proin nec mi et massa efficitur consequat non quis enim. Praesent dignissim mollis enim, sit amet pulvinar orci hendrerit vel. Aenean ac dapibus sapien, a lacinia sem. Ut maximus et nibh sit amet volutpat. In venenatis urna a neque dapibus faucibus.", 30.199999999999999, "Lorem ipsum dolor sit amet." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("d28888e9-2ba3-473a-a40f-e38cb57f9b31"), null, "https://cdn.pixabay.com/photo/2014/09/15/21/46/couch-447484_960_720.jpg", false, false, "Etiam lorem neque, ultrices vitae nibh venenatis, vehicula posuere velit. Mauris in faucibus justo. Donec nec risus in massa consequat ultricies. Nam sagittis lorem erat, in aliquet tellus egestas sed. Vestibulum in tellus id augue molestie aliquam in quis magna. Curabitur finibus eu ipsum in ullamcorper.", "Cras rhoncus", 45.859999999999999, "Molestie aliquam in quis magna" },
                    { new Guid("d28888e9-2ba9-473a-a42f-e38cb54f9b33"), null, "https://cdn.pixabay.com/photo/2017/03/28/12/13/chairs-2181968_960_720.jpg", false, false, "Duis posuere lorem lorem, non cursus sem bibendum nec. Donec pellentesque ex non augue egestas ultrices.", "Nunc semper", 74.959999999999994, "Duis posuere lorem lorem" },
                    { new Guid("d28888e9-2ba9-473a-a41f-e38cb54f9b32"), null, "https://cdn.pixabay.com/photo/2016/11/22/23/38/apartment-1851201_960_720.jpg", false, false, "nisl vel pretium vulputate, sem leo aliquet eros, fermentum imperdiet ex purus in urna. Aenean non nisi semper, rhoncus neque nec, lobortis orci. Pellentesque sit amet porta est. Mauris arcu nulla, placerat eget nulla id,", "vulputate", 85.849999999999994, "nisl vel pretium vulputate" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b34"), null, "https://cdn.pixabay.com/photo/2018/01/26/08/15/dining-room-3108037_960_720.jpg", false, false, "Aenean elementum placerat interdum. Fusce faucibus elit mauris, quis malesuada ex commodo nec. Quisque eu neque felis. Integer vulputate, diam et laoreet eleifend, dolor purus tempor ex, vitae porta enim justo ut ipsum. Etiam justo risus, varius ornare nunc vitae, hendrerit vestibulum arcu", "Aenean elementum", 85.849999999999994, "Aenean elementum placerat interdum" },
                    { new Guid("d28888e9-2ba9-473a-a42f-e38cb54f9b37"), null, "https://cdn.pixabay.com/photo/2017/09/27/02/47/throne-2790789_960_720.png", false, false, "Fusce ornare velit in egestas ultricies. Nunc ligula augue, tristique vitae viverra eget, semper ut nibh. Duis fermentum lorem risus, et viverra nisl efficitur id. Nulla vulputate, magna et venenatis bibendum, sapien erat malesuada urna, et aliquet libero mi eget quam", "Fusce ornare", 65.150000000000006, "Fusce ornare velit in egestas ultricies" },
                    { new Guid("d28888e9-2ba9-473a-a42f-e38cb54f9b38"), null, "https://cdn.pixabay.com/photo/2017/03/19/01/18/living-room-2155353_960_720.jpg", false, false, "Morbi a nibh faucibus orci gravida dapibus. Duis eu lorem quis felis ornare dapibus non a orci. Pellentesque et tincidunt lectus. Pellentesque feugiat magna sit amet ligula dignissim, eu congue eros eleifend. Mauris a turpis quis sem molestie placerat. Maecenas non nibh eu odio consequat molestie vel id ante. Lorem ipsum dolor", "Morbi a nibh", 24.75, "Morbi a nibh faucibus orci gravida dapibus" },
                    { new Guid("d28888e9-2ba9-473a-a42f-e38cb54f9b39"), null, "https://cdn.pixabay.com/photo/2017/08/02/01/01/living-room-2569325_960_720.jpg", false, false, "Maecenas non nibh eu odio consequat molestie vel id ante. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tempus lacus quis tortor scelerisque, sit amet maximus ligula suscipit. In sed tortor eros.", "Ut tempus ", 65.049999999999997, "Ut tempus lacus quis tortor scelerisque" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba3-473a-a40f-e38cb57f9b31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a41f-e38cb54f9b32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a42f-e38cb54f9b33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a42f-e38cb54f9b37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a42f-e38cb54f9b38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a42f-e38cb54f9b39"));

            migrationBuilder.DropColumn(
                name: "ImageThumbnailUrl",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsPieOfTheWeek",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                column: "Description",
                value: "Let us test");
        }
    }
}
