using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using PS.Domain.Entities;

namespace PS.Infrasture.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    
    public class _20200105_Initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(                
                name: "tblbrand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    brandname = table.Column<string>(maxLength: 200, nullable: false),
                    korname = table.Column<string>(maxLength: 200, nullable: false),
                    engname = table.Column<string>(maxLength: 200, nullable: false),
                    address1 = table.Column<string>(maxLength: 400, nullable: false),
                    addressdetail1 = table.Column<string>(maxLength: 400, nullable: false),
                    zipcode1 = table.Column<string>(maxLength: 10, nullable: false),
                    address2 = table.Column<string>(maxLength: 400, nullable: false),
                    addressdetail2 = table.Column<string>(maxLength: 400, nullable: false),
                    zipcode2 = table.Column<string>(maxLength: 10, nullable: false),
                    cellnumber1 = table.Column<string>(maxLength: 20, nullable: false),
                    cellnumber2 = table.Column<string>(maxLength: 20, nullable: false),
                    ownername = table.Column<string>(maxLength: 20, nullable: false),
                    managername = table.Column<string>(maxLength: 20, nullable: false),
                    tel1 = table.Column<string>(maxLength: 20, nullable: false),
                    tel2 = table.Column<string>(maxLength: 20, nullable: false),
                    companyname = table.Column<string>(maxLength: 200, nullable: false),
                    socnumber = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 200, nullable: false),
                    homepage = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brandkey", x => x.Id);
                });

           

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblbrand");

        }
    }
}
