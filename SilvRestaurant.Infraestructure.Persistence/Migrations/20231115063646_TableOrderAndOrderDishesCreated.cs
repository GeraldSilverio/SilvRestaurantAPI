using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SilvRestaurant.Infraestructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TableOrderAndOrderDishesCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Table_TableId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDishes_Dishe_DisheId",
                table: "OrderDishes");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDishes_Order_OrderId",
                table: "OrderDishes");

            migrationBuilder.DropIndex(
                name: "IX_Order_TableId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDishes",
                table: "OrderDishes");

            migrationBuilder.DropIndex(
                name: "IX_OrderDishes_DisheId",
                table: "OrderDishes");

            migrationBuilder.DropIndex(
                name: "IX_OrderDishes_OrderId",
                table: "OrderDishes");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DisheId",
                table: "OrderDishes");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderDishes");

            migrationBuilder.RenameTable(
                name: "OrderDishes",
                newName: "OrderDishe");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "Order",
                type: "Decimal(16,2)",
                precision: 16,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDishe",
                table: "OrderDishe",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_IdTable",
                table: "Order",
                column: "IdTable");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDishe_IdDishe",
                table: "OrderDishe",
                column: "IdDishe");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDishe_IdOrder",
                table: "OrderDishe",
                column: "IdOrder");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Table_IdTable",
                table: "Order",
                column: "IdTable",
                principalTable: "Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDishe_Dishe_IdDishe",
                table: "OrderDishe",
                column: "IdDishe",
                principalTable: "Dishe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDishe_Order_IdOrder",
                table: "OrderDishe",
                column: "IdOrder",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Table_IdTable",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDishe_Dishe_IdDishe",
                table: "OrderDishe");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDishe_Order_IdOrder",
                table: "OrderDishe");

            migrationBuilder.DropIndex(
                name: "IX_Order_IdTable",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDishe",
                table: "OrderDishe");

            migrationBuilder.DropIndex(
                name: "IX_OrderDishe_IdDishe",
                table: "OrderDishe");

            migrationBuilder.DropIndex(
                name: "IX_OrderDishe_IdOrder",
                table: "OrderDishe");

            migrationBuilder.RenameTable(
                name: "OrderDishe",
                newName: "OrderDishes");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "Order",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(16,2)",
                oldPrecision: 16,
                oldScale: 2);

            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisheId",
                table: "OrderDishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderDishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDishes",
                table: "OrderDishes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_TableId",
                table: "Order",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDishes_DisheId",
                table: "OrderDishes",
                column: "DisheId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDishes_OrderId",
                table: "OrderDishes",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Table_TableId",
                table: "Order",
                column: "TableId",
                principalTable: "Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDishes_Dishe_DisheId",
                table: "OrderDishes",
                column: "DisheId",
                principalTable: "Dishe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDishes_Order_OrderId",
                table: "OrderDishes",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
