﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthServer.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Examples",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StringExample = table.Column<string>(type: "text", nullable: false),
                    StringExampleWithMaxLenght = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    StringNullableExample = table.Column<string>(type: "text", nullable: true),
                    TextExample = table.Column<string>(type: "text", nullable: true),
                    DateTimeOffsetExample = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DateTimeOffsetNullableExample = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DateTimeExample = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateTimeNullableExample = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IntExample = table.Column<int>(type: "integer", nullable: false),
                    IntNullExample = table.Column<int>(type: "integer", nullable: true),
                    DecimalExample = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    DecimalNullExample = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    LongExample = table.Column<long>(type: "bigint", nullable: false),
                    LongNullExample = table.Column<long>(type: "bigint", nullable: true),
                    EnumExample = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExampleItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ExampleId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExampleItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExampleItems_Examples_ExampleId",
                        column: x => x.ExampleId,
                        principalTable: "Examples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExampleItems_ExampleId",
                table: "ExampleItems",
                column: "ExampleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExampleItems");

            migrationBuilder.DropTable(
                name: "Examples");
        }
    }
}
