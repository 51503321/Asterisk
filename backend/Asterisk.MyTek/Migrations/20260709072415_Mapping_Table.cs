using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asterisk.MyTek.Migrations
{
    /// <inheritdoc />
    public partial class Mapping_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DevelopmentStages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevelopmentStages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MappingChallenge",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChallengeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DevelopmentStageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingChallenge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MappingChallenge_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MappingChallenge_DevelopmentStages_DevelopmentStageId",
                        column: x => x.DevelopmentStageId,
                        principalTable: "DevelopmentStages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MappingChallenge_ChallengeId",
                table: "MappingChallenge",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_MappingChallenge_DevelopmentStageId",
                table: "MappingChallenge",
                column: "DevelopmentStageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MappingChallenge");

            migrationBuilder.DropTable(
                name: "DevelopmentStages");
        }
    }
}
