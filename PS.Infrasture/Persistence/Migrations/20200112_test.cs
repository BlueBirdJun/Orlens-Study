using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using PS.Domain.Entities;

namespace PS.Infrasture.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190112_tbltest")]
    public class _20200105_Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(                
                name: "tbltest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    memo = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testkey", x => x.Id);
                });

           

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbltest");

        }
    }
}
