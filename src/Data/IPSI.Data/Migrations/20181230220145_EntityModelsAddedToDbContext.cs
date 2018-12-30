using Microsoft.EntityFrameworkCore.Migrations;

namespace IPSI.Data.Migrations
{
    public partial class EntityModelsAddedToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicy_Customer_CustomerId",
                table: "InsurancePolicy");

            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicy_Insurances_InsuranceId",
                table: "InsurancePolicy");

            migrationBuilder.DropForeignKey(
                name: "FK_InsuredProperty_InsurancePolicy_InsurancePolicyId",
                table: "InsuredProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_InsurancePolicy_InsurancePolicyId",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InsuredProperty",
                table: "InsuredProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InsurancePolicy",
                table: "InsurancePolicy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "InsuredProperty",
                newName: "InsuredProperties");

            migrationBuilder.RenameTable(
                name: "InsurancePolicy",
                newName: "InsurancePolicies");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_InsurancePolicyId",
                table: "Payments",
                newName: "IX_Payments_InsurancePolicyId");

            migrationBuilder.RenameIndex(
                name: "IX_InsuredProperty_InsurancePolicyId",
                table: "InsuredProperties",
                newName: "IX_InsuredProperties_InsurancePolicyId");

            migrationBuilder.RenameIndex(
                name: "IX_InsurancePolicy_InsuranceId",
                table: "InsurancePolicies",
                newName: "IX_InsurancePolicies_InsuranceId");

            migrationBuilder.RenameIndex(
                name: "IX_InsurancePolicy_CustomerId",
                table: "InsurancePolicies",
                newName: "IX_InsurancePolicies_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InsuredProperties",
                table: "InsuredProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InsurancePolicies",
                table: "InsurancePolicies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

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
                name: "FK_InsuredProperties_InsurancePolicies_InsurancePolicyId",
                table: "InsuredProperties",
                column: "InsurancePolicyId",
                principalTable: "InsurancePolicies",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_Customers_CustomerId",
                table: "InsurancePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_Insurances_InsuranceId",
                table: "InsurancePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_InsuredProperties_InsurancePolicies_InsurancePolicyId",
                table: "InsuredProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_InsurancePolicies_InsurancePolicyId",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InsuredProperties",
                table: "InsuredProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InsurancePolicies",
                table: "InsurancePolicies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "InsuredProperties",
                newName: "InsuredProperty");

            migrationBuilder.RenameTable(
                name: "InsurancePolicies",
                newName: "InsurancePolicy");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_InsurancePolicyId",
                table: "Payment",
                newName: "IX_Payment_InsurancePolicyId");

            migrationBuilder.RenameIndex(
                name: "IX_InsuredProperties_InsurancePolicyId",
                table: "InsuredProperty",
                newName: "IX_InsuredProperty_InsurancePolicyId");

            migrationBuilder.RenameIndex(
                name: "IX_InsurancePolicies_InsuranceId",
                table: "InsurancePolicy",
                newName: "IX_InsurancePolicy_InsuranceId");

            migrationBuilder.RenameIndex(
                name: "IX_InsurancePolicies_CustomerId",
                table: "InsurancePolicy",
                newName: "IX_InsurancePolicy_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InsuredProperty",
                table: "InsuredProperty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InsurancePolicy",
                table: "InsurancePolicy",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicy_Customer_CustomerId",
                table: "InsurancePolicy",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicy_Insurances_InsuranceId",
                table: "InsurancePolicy",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InsuredProperty_InsurancePolicy_InsurancePolicyId",
                table: "InsuredProperty",
                column: "InsurancePolicyId",
                principalTable: "InsurancePolicy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_InsurancePolicy_InsurancePolicyId",
                table: "Payment",
                column: "InsurancePolicyId",
                principalTable: "InsurancePolicy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
