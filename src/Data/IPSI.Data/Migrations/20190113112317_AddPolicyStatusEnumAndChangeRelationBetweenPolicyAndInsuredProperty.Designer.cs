﻿// <auto-generated />
using System;
using IPSI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IPSI.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190113112317_AddPolicyStatusEnumAndChangeRelationBetweenPolicyAndInsuredProperty")]
    partial class AddPolicyStatusEnumAndChangeRelationBetweenPolicyAndInsuredProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IPSI.Data.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("IPSI.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("IPSI.Data.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Logo");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Notes");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("IPSI.Data.Models.CompanyInsurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("InsuranceId");

                    b.Property<DateTime?>("ModifiedOn");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("InsuranceId");

                    b.ToTable("CompanyInsurances");
                });

            modelBuilder.Entity("IPSI.Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Email");

                    b.Property<bool>("IsIndividual");

                    b.Property<string>("Mobile")
                        .IsRequired();

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PIN")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Phone");

                    b.Property<string>("PostCode");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("IPSI.Data.Models.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Insurances");
                });

            modelBuilder.Entity("IPSI.Data.Models.InsuredProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("InsurancePolicyId");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Notes");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("InsuredProperties");
                });

            modelBuilder.Entity("IPSI.Data.Models.Loss", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsTotal");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Note");

                    b.Property<DateTime>("OccurenceDate");

                    b.Property<int?>("PolicyId");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("PolicyId");

                    b.ToTable("Loss");
                });

            modelBuilder.Entity("IPSI.Data.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Commission");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<decimal>("DiscountOnCommission");

                    b.Property<decimal>("GrossInsurancePremium");

                    b.Property<int>("InsurancePolicyId");

                    b.Property<DateTime>("MaturityDate");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<decimal>("NetInsurancePremium");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<int>("PaymentNumber");

                    b.HasKey("Id");

                    b.HasIndex("InsurancePolicyId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("IPSI.Data.Models.Policy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("EndDate");

                    b.Property<decimal>("GrossInsurancePremium");

                    b.Property<int>("InsuranceId");

                    b.Property<int>("InsuredPropertyId");

                    b.Property<bool>("InsuredPropertyIncluded");

                    b.Property<DateTime>("IssueDate");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<decimal>("PaidInsurancePremium");

                    b.Property<int>("PaymentNumber");

                    b.Property<int>("PaymentsCount");

                    b.Property<string>("PolicyNumber")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InsuranceId");

                    b.HasIndex("InsuredPropertyId");

                    b.ToTable("InsurancePolicies");
                });

            modelBuilder.Entity("IPSI.Data.Models.PolicyInsuredProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("InsuredPropertyId");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<int>("PolicyId");

                    b.HasKey("Id");

                    b.HasIndex("InsuredPropertyId");

                    b.HasIndex("PolicyId");

                    b.ToTable("PolicyInsuredProperty");
                });

            modelBuilder.Entity("IPSI.Data.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("IPSI.Data.Models.CompanyInsurance", b =>
                {
                    b.HasOne("IPSI.Data.Models.Company", "Company")
                        .WithMany("Insurances")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IPSI.Data.Models.Insurance", "Insurance")
                        .WithMany("Companies")
                        .HasForeignKey("InsuranceId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IPSI.Data.Models.Loss", b =>
                {
                    b.HasOne("IPSI.Data.Models.Policy")
                        .WithMany("Damages")
                        .HasForeignKey("PolicyId");
                });

            modelBuilder.Entity("IPSI.Data.Models.Payment", b =>
                {
                    b.HasOne("IPSI.Data.Models.Policy", "InsurancePolicy")
                        .WithMany("Payments")
                        .HasForeignKey("InsurancePolicyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IPSI.Data.Models.Policy", b =>
                {
                    b.HasOne("IPSI.Data.Models.Customer", "Customer")
                        .WithMany("InsurancePolicies")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IPSI.Data.Models.Insurance", "Insurance")
                        .WithMany("InsurancePolicies")
                        .HasForeignKey("InsuranceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IPSI.Data.Models.InsuredProperty", "InsuredProperty")
                        .WithMany()
                        .HasForeignKey("InsuredPropertyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IPSI.Data.Models.PolicyInsuredProperty", b =>
                {
                    b.HasOne("IPSI.Data.Models.InsuredProperty", "InsuredProperty")
                        .WithMany("Policies")
                        .HasForeignKey("InsuredPropertyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IPSI.Data.Models.Policy", "Policy")
                        .WithMany()
                        .HasForeignKey("PolicyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("IPSI.Data.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IPSI.Data.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IPSI.Data.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("IPSI.Data.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IPSI.Data.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IPSI.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
