using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrAdresýlIlce.Infrastructure.Migrations
{
    public partial class reseed_ids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("IF OBJECT_ID('Countries', 'U') IS NOT NULL DBCC CHECKIDENT ('Countries', RESEED, 0);");
            migrationBuilder.Sql("IF OBJECT_ID('Provinces', 'U') IS NOT NULL DBCC CHECKIDENT ('Provinces', RESEED, 0);");
            migrationBuilder.Sql("IF OBJECT_ID('Districts', 'U') IS NOT NULL DBCC CHECKIDENT ('Districts', RESEED, 0);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // No-op
        }
    }
}
