using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DiplomWPF.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Amount = table.Column<int>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "jobName",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "report",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Period = table.Column<string>(type: "character varying", nullable: false),
                    Costs = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_report", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "type",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "worker",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    Patronymic = table.Column<string>(maxLength: 100, nullable: true),
                    Cabinet = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_worker", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "systemAdministrator",
                columns: table => new
                {
                    Id_JobName = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Login = table.Column<string>(maxLength: 100, nullable: true),
                    Password = table.Column<string>(maxLength: 100, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Surname = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SystemAdministrator_pkey", x => x.Id_JobName);
                    table.ForeignKey(
                        name: "fk_systemAdministrator_jobName",
                        column: x => x.Id_JobName,
                        principalTable: "jobName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "history",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Id_Worker = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_history", x => x.Id);
                    table.ForeignKey(
                        name: "fk_history_worker",
                        column: x => x.Id_Worker,
                        principalTable: "worker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "request",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Post = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    Id_Type = table.Column<int>(nullable: false),
                    Id_Status = table.Column<int>(nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "date", nullable: false),
                    Id_Worker = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_request", x => x.Id);
                    table.ForeignKey(
                        name: "fk_request_status",
                        column: x => x.Id_Status,
                        principalTable: "status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_request_type",
                        column: x => x.Id_Type,
                        principalTable: "type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_request_worker",
                        column: x => x.Id_Worker,
                        principalTable: "worker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_history_Id_Worker",
                table: "history",
                column: "Id_Worker");

            migrationBuilder.CreateIndex(
                name: "IX_request_Id_Status",
                table: "request",
                column: "Id_Status");

            migrationBuilder.CreateIndex(
                name: "IX_request_Id_Type",
                table: "request",
                column: "Id_Type");

            migrationBuilder.CreateIndex(
                name: "IX_request_Id_Worker",
                table: "request",
                column: "Id_Worker");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cost");

            migrationBuilder.DropTable(
                name: "history");

            migrationBuilder.DropTable(
                name: "report");

            migrationBuilder.DropTable(
                name: "request");

            migrationBuilder.DropTable(
                name: "systemAdministrator");

            migrationBuilder.DropTable(
                name: "status");

            migrationBuilder.DropTable(
                name: "type");

            migrationBuilder.DropTable(
                name: "worker");

            migrationBuilder.DropTable(
                name: "jobName");
        }
    }
}
