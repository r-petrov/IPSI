using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IPSI.Data.Migrations
{
    public partial class AddPolicyStatusEnumAndChangeRelationBetweenPolicyAndInsuredProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuredProperties_InsurancePolicies_InsurancePolicyId",
                table: "InsuredProperties");

            migrationBuilder.DropIndex(
                name: "IX_InsuredProperties_InsurancePolicyId",
                table: "InsuredProperties");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "InsuredProperties",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "Broker",
                table: "Companies",
                newName: "Notes");

            migrationBuilder.AddColumn<int>(
                name: "InsuredPropertyId",
                table: "InsurancePolicies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "InsurancePolicies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Companies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Loss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    OccurenceDate = table.Column<DateTime>(nullable: false),
                    IsTotal = table.Column<bool>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    PolicyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loss_InsurancePolicies_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "InsurancePolicies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PolicyInsuredProperty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    PolicyId = table.Column<int>(nullable: false),
                    InsuredPropertyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyInsuredProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyInsuredProperty_InsuredProperties_InsuredPropertyId",
                        column: x => x.InsuredPropertyId,
                        principalTable: "InsuredProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyInsuredProperty_InsurancePolicies_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "InsurancePolicies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_InsuredPropertyId",
                table: "InsurancePolicies",
                column: "InsuredPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Loss_PolicyId",
                table: "Loss",
                column: "PolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyInsuredProperty_InsuredPropertyId",
                table: "PolicyInsuredProperty",
                column: "InsuredPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyInsuredProperty_PolicyId",
                table: "PolicyInsuredProperty",
                column: "PolicyId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_InsuredProperties_InsuredPropertyId",
                table: "InsurancePolicies",
                column: "InsuredPropertyId",
                principalTable: "InsuredProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_InsuredProperties_InsuredPropertyId",
                table: "InsurancePolicies");

            migrationBuilder.DropTable(
                name: "Loss");

            migrationBuilder.DropTable(
                name: "PolicyInsuredProperty");

            migrationBuilder.DropIndex(
                name: "IX_InsurancePolicies_InsuredPropertyId",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "InsuredPropertyId",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "InsuredProperties",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Companies",
                newName: "Broker");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InsuredProperties_InsurancePolicyId",
                table: "InsuredProperties",
                column: "InsurancePolicyId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsuredProperties_InsurancePolicies_InsurancePolicyId",
                table: "InsuredProperties",
                column: "InsurancePolicyId",
                principalTable: "InsurancePolicies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
