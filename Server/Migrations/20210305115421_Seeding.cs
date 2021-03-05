using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AyacStore.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 1, "vegetables", "Vegetables", "vegetables" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 2, "fruits", "Fruits", "fruits" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 3, "cereals", "Cereals", "cereals" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 3, 5, 12, 54, 20, 69, DateTimeKind.Local).AddTicks(9135), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Tomatoes sourced directly from farmers in order to provide you with high quality at a price you love. Fun fact; pepper isn't a vegetable, botanists acknowledge tomato as a fruit because of the location of its seed", "https://media.istockphoto.com/photos/tomato-isolated-tomato-on-white-background-with-clipping-path-full-picture-id941825808?k=6&m=941825808&s=612x612&w=0&h=zMkokhq3w7fN5xYeiTX27c6TICJ53ZvZg9AY2LNgw_0=", false, false, 200m, 99.99m, "Tomatoes" },
                    { 4, 1, new DateTime(2021, 3, 5, 12, 54, 20, 72, DateTimeKind.Local).AddTicks(8240), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh pepper sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; pepper isn't a vegetable, botanists acknowledge pepper as a fruit because of the location of its seed", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYdRaqkMUhc4WxHJcT0c9JRCfmdvWpdJUCOQ&usqp=CAU", false, false, 200m, 99.99m, "Pepper" },
                    { 2, 2, new DateTime(2021, 3, 5, 12, 54, 20, 72, DateTimeKind.Local).AddTicks(8187), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Strawberry sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; strawberry isn't a berry, botanists acknowledge strawberry as a false fruit because of it's multiple fruit nature", "https://www.thermofisher.com/blog/food/wp-content/uploads/sites/5/2015/08/single_strawberry__isolated_on_a_white_background.jpg", false, false, 2000m, 999.99m, "Strawberry" },
                    { 7, 2, new DateTime(2021, 3, 5, 12, 54, 20, 72, DateTimeKind.Local).AddTicks(8259), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh plantain sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; plantain isn't a fruit, botanists acknowledge plantain as a berry. Fruits are defined by the manner and location of their seeds", "https://eatyfood.com/wp-content/uploads/2020/08/plantains.jpg", false, false, 400m, 199.99m, "Plantain" },
                    { 8, 2, new DateTime(2021, 3, 5, 12, 54, 20, 72, DateTimeKind.Local).AddTicks(8269), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh banana sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; banana isn't a fruit, botanists acknowledge banana as a berry. Fruits are defined by the manner and location of their seeds", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRi94BSgqwm6Zzv7mx3DJWxYRWNUPC0gf3pOA&usqp=CAU", false, false, 400m, 199.99m, "Banana" },
                    { 5, 3, new DateTime(2021, 3, 5, 12, 54, 20, 72, DateTimeKind.Local).AddTicks(8249), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh corn sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; corn is one of the top three most consumed crop in the world", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYYVJEFeOlfYCHaynRROL_MLI2AbF1Aa4aUw&usqp=CAU", false, false, 200m, 99.99m, "Corn" },
                    { 6, 3, new DateTime(2021, 3, 5, 12, 54, 20, 72, DateTimeKind.Local).AddTicks(8254), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh rice sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; rice is one of the top three most consumed crop in the world", "https://m.economictimes.com/thumb/msid-75184562,width-1200,height-900,resizemode-4,imgsize-414299/rice.jpg", false, false, 25000m, 19999.99m, "Rice" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
