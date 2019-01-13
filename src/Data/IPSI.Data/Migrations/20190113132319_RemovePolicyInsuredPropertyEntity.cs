using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IPSI.Data.Migrations
{
    public partial class RemovePolicyInsuredPropertyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_Customers_CustomerId",
                table: "InsurancePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_Insurances_InsuranceId",
                table: "InsurancePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_InsuredProperties_InsuredPropertyId",
                table: "InsurancePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_InsurancePolicies_InsurancePolicyId",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "Loss");

            migrationBuilder.DropTable(
                name: "PolicyInsuredProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InsurancePolicies",
                table: "InsurancePolicies");

            migrationBuilder.RenameTable(
                name: "InsurancePolicies",
                newName: "Policies");

            migrationBuilder.RenameIndex(
                name: "IX_InsurancePolicies_InsuredPropertyId",
                table: "Policies",
                newName: "IX_Policies_InsuredPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_InsurancePolicies_InsuranceId",
                table: "Policies",
                newName: "IX_Policies_InsuranceId");

            migrationBuilder.RenameIndex(
                name: "IX_InsurancePolicies_CustomerId",
                table: "Policies",
                newName: "IX_Policies_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Policies",
                table: "Policies",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Damages",
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
                    table.PrimaryKey("PK_Damages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Damages_Policies_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "Policies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Damages_PolicyId",
                table: "Damages",
                column: "PolicyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Policies_InsurancePolicyId",
                table: "Payments",
                column: "InsurancePolicyId",
                principalTable: "Policies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_Customers_CustomerId",
                table: "Policies",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_Insurances_InsuranceId",
                table: "Policies",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_InsuredProperties_InsuredPropertyId",
                table: "Policies",
                column: "InsuredPropertyId",
                principalTable: "InsuredProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Policies_InsurancePolicyId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Policies_Customers_CustomerId",
                table: "Policies");

            migrationBuilder.DropForeignKey(
                name: "FK_Policies_Insurances_InsuranceId",
                table: "Policies");

            migrationBuilder.DropForeignKey(
                name: "FK_Policies_InsuredProperties_InsuredPropertyId",
                table: "Policies");

            migrationBuilder.DropTable(
                name: "Damages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Policies",
                table: "Policies");

            migrationBuilder.RenameTable(
                name: "Policies",
                newName: "InsurancePolicies");

            migrationBuilder.RenameIndex(
                name: "IX_Policies_InsuredPropertyId",
                table: "InsurancePolicies",
                newName: "IX_InsurancePolicies_InsuredPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_Policies_InsuranceId",
                table: "InsurancePolicies",
                newName: "IX_InsurancePolicies_InsuranceId");

            migrationBuilder.RenameIndex(
                name: "IX_Policies_CustomerId",
                table: "InsurancePolicies",
                newName: "IX_InsurancePolicies_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InsurancePolicies",
                table: "InsurancePolicies",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Loss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    IsTotal = table.Column<bool>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OccurenceDate = table.Column<DateTime>(nullable: false),
                    PolicyId = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true)
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
                    InsuredPropertyId = table.Column<int>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    PolicyId = table.Column<int>(nullable: false)
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
                name: "FK_InsurancePolicies_Customers_CustomerId",
                table: "InsurancePolicies",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_Insurances_InsuranceId",
                table: "InsurancePolicies",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_InsuredProperties_InsuredPropertyId",
                table: "InsurancePolicies",
                column: "InsuredPropertyId",
                principalTable: "InsuredProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_InsurancePolicies_InsurancePolicyId",
                table: "Payments",
                column: "InsurancePolicyId",
                principalTable: "InsurancePolicies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
