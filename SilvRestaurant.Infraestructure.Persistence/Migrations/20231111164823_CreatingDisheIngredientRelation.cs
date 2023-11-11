using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SilvRestaurant.Infraestructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CreatingDisheIngredientRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisheIngredient_Dishe_DisheId",
                table: "DisheIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_DisheIngredient_Ingredient_IngredientId",
                table: "DisheIngredient");

            migrationBuilder.DropIndex(
                name: "IX_DisheIngredient_DisheId",
                table: "DisheIngredient");

            migrationBuilder.DropIndex(
                name: "IX_DisheIngredient_IngredientId",
                table: "DisheIngredient");

            migrationBuilder.DropColumn(
                name: "DisheId",
                table: "DisheIngredient");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "DisheIngredient");

            migrationBuilder.CreateIndex(
                name: "IX_DisheIngredient_IdDishe",
                table: "DisheIngredient",
                column: "IdDishe");

            migrationBuilder.CreateIndex(
                name: "IX_DisheIngredient_IdIngredient",
                table: "DisheIngredient",
                column: "IdIngredient");

            migrationBuilder.AddForeignKey(
                name: "FK_DisheIngredient_Dishe_IdDishe",
                table: "DisheIngredient",
                column: "IdDishe",
                principalTable: "Dishe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DisheIngredient_Ingredient_IdIngredient",
                table: "DisheIngredient",
                column: "IdIngredient",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisheIngredient_Dishe_IdDishe",
                table: "DisheIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_DisheIngredient_Ingredient_IdIngredient",
                table: "DisheIngredient");

            migrationBuilder.DropIndex(
                name: "IX_DisheIngredient_IdDishe",
                table: "DisheIngredient");

            migrationBuilder.DropIndex(
                name: "IX_DisheIngredient_IdIngredient",
                table: "DisheIngredient");

            migrationBuilder.AddColumn<int>(
                name: "DisheId",
                table: "DisheIngredient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "DisheIngredient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DisheIngredient_DisheId",
                table: "DisheIngredient",
                column: "DisheId");

            migrationBuilder.CreateIndex(
                name: "IX_DisheIngredient_IngredientId",
                table: "DisheIngredient",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_DisheIngredient_Dishe_DisheId",
                table: "DisheIngredient",
                column: "DisheId",
                principalTable: "Dishe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DisheIngredient_Ingredient_IngredientId",
                table: "DisheIngredient",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
