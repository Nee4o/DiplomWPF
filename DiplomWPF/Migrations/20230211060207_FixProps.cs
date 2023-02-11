using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DiplomWPF.Migrations
{
    public partial class FixProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_history_worker",
                table: "history");

            migrationBuilder.DropForeignKey(
                name: "fk_request_status",
                table: "request");

            migrationBuilder.DropForeignKey(
                name: "fk_request_type",
                table: "request");

            migrationBuilder.DropForeignKey(
                name: "fk_request_worker",
                table: "request");

            migrationBuilder.DropForeignKey(
                name: "fk_systemAdministrator_jobName",
                table: "systemAdministrator");

            migrationBuilder.DropPrimaryKey(
                name: "PK_worker",
                table: "worker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_type",
                table: "type");

            migrationBuilder.DropPrimaryKey(
                name: "SystemAdministrator_pkey",
                table: "systemAdministrator");

            migrationBuilder.DropPrimaryKey(
                name: "PK_status",
                table: "status");

            migrationBuilder.DropPrimaryKey(
                name: "PK_request",
                table: "request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_report",
                table: "report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jobName",
                table: "jobName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_history",
                table: "history");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cost",
                table: "cost");

            migrationBuilder.RenameTable(
                name: "worker",
                newName: "Workers");

            migrationBuilder.RenameTable(
                name: "type",
                newName: "Types");

            migrationBuilder.RenameTable(
                name: "systemAdministrator",
                newName: "SystemAdministrators");

            migrationBuilder.RenameTable(
                name: "status",
                newName: "Statuses");

            migrationBuilder.RenameTable(
                name: "request",
                newName: "Requests");

            migrationBuilder.RenameTable(
                name: "report",
                newName: "Reports");

            migrationBuilder.RenameTable(
                name: "jobName",
                newName: "JobNames");

            migrationBuilder.RenameTable(
                name: "history",
                newName: "Histories");

            migrationBuilder.RenameTable(
                name: "cost",
                newName: "Costs");

            migrationBuilder.RenameColumn(
                name: "Id_JobName",
                table: "SystemAdministrators",
                newName: "JobNameId");

            migrationBuilder.RenameColumn(
                name: "Id_Worker",
                table: "Requests",
                newName: "WorkerId");

            migrationBuilder.RenameColumn(
                name: "Id_Type",
                table: "Requests",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "Id_Status",
                table: "Requests",
                newName: "StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_request_Id_Worker",
                table: "Requests",
                newName: "IX_Requests_WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_request_Id_Type",
                table: "Requests",
                newName: "IX_Requests_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_request_Id_Status",
                table: "Requests",
                newName: "IX_Requests_StatusId");

            migrationBuilder.RenameColumn(
                name: "Id_Worker",
                table: "Histories",
                newName: "WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_history_Id_Worker",
                table: "Histories",
                newName: "IX_Histories_WorkerId");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Workers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Workers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Patronymic",
                table: "Workers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Workers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Workers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Cabinet",
                table: "Workers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Workers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Types",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Types",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "SystemAdministrators",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "SystemAdministrators",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SystemAdministrators",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "SystemAdministrators",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SystemAdministrators",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Statuses",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Statuses",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Requests",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Post",
                table: "Requests",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Requests",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreation",
                table: "Requests",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Requests",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Period",
                table: "Reports",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying");

            migrationBuilder.AlterColumn<decimal>(
                name: "Costs",
                table: "Reports",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Reports",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobNames",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "JobNames",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Histories",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Histories",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Histories",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Costs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Costs",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Costs",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Costs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workers",
                table: "Workers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Types",
                table: "Types",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SystemAdministrators",
                table: "SystemAdministrators",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requests",
                table: "Requests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports",
                table: "Reports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobNames",
                table: "JobNames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Histories",
                table: "Histories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Costs",
                table: "Costs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAdministrators_JobNameId",
                table: "SystemAdministrators",
                column: "JobNameId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Workers_WorkerId",
                table: "Histories",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Statuses_StatusId",
                table: "Requests",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Types_TypeId",
                table: "Requests",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Workers_WorkerId",
                table: "Requests",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemAdministrators_JobNames_JobNameId",
                table: "SystemAdministrators",
                column: "JobNameId",
                principalTable: "JobNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Workers_WorkerId",
                table: "Histories");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Statuses_StatusId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Types_TypeId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Workers_WorkerId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemAdministrators_JobNames_JobNameId",
                table: "SystemAdministrators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workers",
                table: "Workers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Types",
                table: "Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SystemAdministrators",
                table: "SystemAdministrators");

            migrationBuilder.DropIndex(
                name: "IX_SystemAdministrators_JobNameId",
                table: "SystemAdministrators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requests",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobNames",
                table: "JobNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Histories",
                table: "Histories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Costs",
                table: "Costs");

            migrationBuilder.RenameTable(
                name: "Workers",
                newName: "worker");

            migrationBuilder.RenameTable(
                name: "Types",
                newName: "type");

            migrationBuilder.RenameTable(
                name: "SystemAdministrators",
                newName: "systemAdministrator");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "status");

            migrationBuilder.RenameTable(
                name: "Requests",
                newName: "request");

            migrationBuilder.RenameTable(
                name: "Reports",
                newName: "report");

            migrationBuilder.RenameTable(
                name: "JobNames",
                newName: "jobName");

            migrationBuilder.RenameTable(
                name: "Histories",
                newName: "history");

            migrationBuilder.RenameTable(
                name: "Costs",
                newName: "cost");

            migrationBuilder.RenameColumn(
                name: "JobNameId",
                table: "systemAdministrator",
                newName: "Id_JobName");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "request",
                newName: "Id_Worker");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "request",
                newName: "Id_Type");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "request",
                newName: "Id_Status");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_WorkerId",
                table: "request",
                newName: "IX_request_Id_Worker");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_TypeId",
                table: "request",
                newName: "IX_request_Id_Type");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_StatusId",
                table: "request",
                newName: "IX_request_Id_Status");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "history",
                newName: "Id_Worker");

            migrationBuilder.RenameIndex(
                name: "IX_Histories_WorkerId",
                table: "history",
                newName: "IX_history_Id_Worker");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "worker",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "worker",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Patronymic",
                table: "worker",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "worker",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "worker",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cabinet",
                table: "worker",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "worker",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "type",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "type",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "systemAdministrator",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "systemAdministrator",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "systemAdministrator",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "systemAdministrator",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "systemAdministrator",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "status",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "status",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "request",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Post",
                table: "request",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "request",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreation",
                table: "request",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "request",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Period",
                table: "report",
                type: "character varying",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Costs",
                table: "report",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "report",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "jobName",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "jobName",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "history",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "history",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "history",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "cost",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "cost",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "cost",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "cost",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_worker",
                table: "worker",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_type",
                table: "type",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "SystemAdministrator_pkey",
                table: "systemAdministrator",
                column: "Id_JobName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_status",
                table: "status",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_request",
                table: "request",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_report",
                table: "report",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jobName",
                table: "jobName",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_history",
                table: "history",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cost",
                table: "cost",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "fk_history_worker",
                table: "history",
                column: "Id_Worker",
                principalTable: "worker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_request_status",
                table: "request",
                column: "Id_Status",
                principalTable: "status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_request_type",
                table: "request",
                column: "Id_Type",
                principalTable: "type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_request_worker",
                table: "request",
                column: "Id_Worker",
                principalTable: "worker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_systemAdministrator_jobName",
                table: "systemAdministrator",
                column: "Id_JobName",
                principalTable: "jobName",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
