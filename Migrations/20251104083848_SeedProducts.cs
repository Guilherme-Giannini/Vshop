using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VShop.ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products (Name, Price, Description, Stock, ImageUrl, CategoryId1) VALUES" +
                   "('Caderno Espiral', 15.90, 'Caderno espiral universitário com 100 folhas.', 50, 'https://example.com/images/caderno_espiral.jpg', 1)," +
                   "('Mochila Escolar', 89.90, 'Mochila resistente com vários compartimentos.', 30, 'https://example.com/images/mochila_escolar.jpg', 2)," +
                   "('Caneta Azul', 2.50, 'Caneta esferográfica azul de alta qualidade.', 200, 'https://example.com/images/caneta_azul.jpg', 1)," +
                   "('Estojo para Lápis', 12.00, 'Estojo compacto para lápis e canetas.', 75, 'https://example.com/images/estojo_lapis.jpg', 2);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products WHERE Name IN ('Caderno Espiral', 'Mochila Escolar', 'Caneta Azul', 'Estojo para Lápis');");
        }
    }
}
