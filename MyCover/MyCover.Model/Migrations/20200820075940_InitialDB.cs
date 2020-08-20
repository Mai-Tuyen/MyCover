using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCover.Model.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(maxLength: 50, nullable: true),
                    AvartarLink = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Role = table.Column<string>(maxLength: 30, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoName = table.Column<string>(nullable: true),
                    CreateBy = table.Column<int>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    LinkVideo = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    SlugUrl = table.Column<string>(nullable: true),
                    SeoDescription = table.Column<string>(nullable: true),
                    SeoKeyword = table.Column<string>(nullable: true),
                    SeoTitle = table.Column<string>(nullable: true),
                    ViewCount = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Videos");
        }
    }
}
