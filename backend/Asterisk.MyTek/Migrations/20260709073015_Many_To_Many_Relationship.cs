using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asterisk.MyTek.Migrations
{
    /// <inheritdoc />
    public partial class Many_To_Many_Relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MappingChallenge_Challenges_ChallengeId",
                table: "MappingChallenge");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingChallenge_DevelopmentStages_DevelopmentStageId",
                table: "MappingChallenge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingChallenge",
                table: "MappingChallenge");

            migrationBuilder.RenameTable(
                name: "MappingChallenge",
                newName: "MappingChallenges");

            migrationBuilder.RenameIndex(
                name: "IX_MappingChallenge_DevelopmentStageId",
                table: "MappingChallenges",
                newName: "IX_MappingChallenges_DevelopmentStageId");

            migrationBuilder.RenameIndex(
                name: "IX_MappingChallenge_ChallengeId",
                table: "MappingChallenges",
                newName: "IX_MappingChallenges_ChallengeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingChallenges",
                table: "MappingChallenges",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Birds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnimalBird",
                columns: table => new
                {
                    AnimalsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BirdsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalBird", x => new { x.AnimalsId, x.BirdsId });
                    table.ForeignKey(
                        name: "FK_AnimalBird_Animals_AnimalsId",
                        column: x => x.AnimalsId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalBird_Birds_BirdsId",
                        column: x => x.BirdsId,
                        principalTable: "Birds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalBird_BirdsId",
                table: "AnimalBird",
                column: "BirdsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MappingChallenges_Challenges_ChallengeId",
                table: "MappingChallenges",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingChallenges_DevelopmentStages_DevelopmentStageId",
                table: "MappingChallenges",
                column: "DevelopmentStageId",
                principalTable: "DevelopmentStages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MappingChallenges_Challenges_ChallengeId",
                table: "MappingChallenges");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingChallenges_DevelopmentStages_DevelopmentStageId",
                table: "MappingChallenges");

            migrationBuilder.DropTable(
                name: "AnimalBird");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Birds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingChallenges",
                table: "MappingChallenges");

            migrationBuilder.RenameTable(
                name: "MappingChallenges",
                newName: "MappingChallenge");

            migrationBuilder.RenameIndex(
                name: "IX_MappingChallenges_DevelopmentStageId",
                table: "MappingChallenge",
                newName: "IX_MappingChallenge_DevelopmentStageId");

            migrationBuilder.RenameIndex(
                name: "IX_MappingChallenges_ChallengeId",
                table: "MappingChallenge",
                newName: "IX_MappingChallenge_ChallengeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingChallenge",
                table: "MappingChallenge",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MappingChallenge_Challenges_ChallengeId",
                table: "MappingChallenge",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingChallenge_DevelopmentStages_DevelopmentStageId",
                table: "MappingChallenge",
                column: "DevelopmentStageId",
                principalTable: "DevelopmentStages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
