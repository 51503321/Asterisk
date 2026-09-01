using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asterisk.MyTek.Migrations
{
    /// <inheritdoc />
    public partial class Add_Challenge_Ref_Without_Config_DbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ChallengeConfigs_ChallengeId",
                table: "ChallengeConfigs",
                column: "ChallengeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChallengeConfigs_Challenges_ChallengeId",
                table: "ChallengeConfigs",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChallengeConfigs_Challenges_ChallengeId",
                table: "ChallengeConfigs");

            migrationBuilder.DropIndex(
                name: "IX_ChallengeConfigs_ChallengeId",
                table: "ChallengeConfigs");
        }
    }
}
