﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarehousingServic.Data;

#nullable disable

namespace WarehousingServic.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230808120557_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JwtFeildsLoginFieldRequest", b =>
                {
                    b.Property<string>("JwtFeildstoken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginFieldRequestsUserName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("JwtFeildstoken", "LoginFieldRequestsUserName");

                    b.HasIndex("LoginFieldRequestsUserName");

                    b.ToTable("JwtFeildsLoginFieldRequest");
                });

            modelBuilder.Entity("WarehousingServic.Entity.ProductFeature", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("ExpirationData")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("ProductGroupId")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("productFeatures");
                });

            modelBuilder.Entity("WarehousingServic.Entity.ProductGroup", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("ParentGroupe")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductGroupCode")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("ProductGroupId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.HasIndex("Price");

                    b.HasIndex("ProductGroupId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductGroups");
                });

            modelBuilder.Entity("WarehousingServic.Entity.ReceiptFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfReceipt")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<int>("InventoryIncrease")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("NumberOfProduct")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("PriceOfProduct")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ReceiptFeatures");
                });

            modelBuilder.Entity("WarehousingServic.Entity.RemittanceFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfRemittance")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<int>("InventoryReduction")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("PriceProduct")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RemittanceFeatures");
                });

            modelBuilder.Entity("WarehousingServic.Models.JwtFeilds", b =>
                {
                    b.Property<string>("token")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("expire_time")
                        .HasColumnType("int");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("token");

                    b.ToTable("jwtFeilds");
                });

            modelBuilder.Entity("WarehousingServic.Models.LoginFieldRequest", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserName");

                    b.ToTable("loginFieldRequests");
                });

            modelBuilder.Entity("JwtFeildsLoginFieldRequest", b =>
                {
                    b.HasOne("WarehousingServic.Models.JwtFeilds", null)
                        .WithMany()
                        .HasForeignKey("JwtFeildstoken")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehousingServic.Models.LoginFieldRequest", null)
                        .WithMany()
                        .HasForeignKey("LoginFieldRequestsUserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WarehousingServic.Entity.ProductGroup", b =>
                {
                    b.HasOne("WarehousingServic.Entity.ProductFeature", "ProductFeature")
                        .WithMany("ProductGroup")
                        .HasForeignKey("Price")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehousingServic.Entity.ReceiptFeature", "ReceiptFeature")
                        .WithMany("ProductGroup")
                        .HasForeignKey("ProductGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WarehousingServic.Entity.RemittanceFeature", "RemittanceFeature")
                        .WithMany("ProductGroup")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductFeature");

                    b.Navigation("ReceiptFeature");

                    b.Navigation("RemittanceFeature");
                });

            modelBuilder.Entity("WarehousingServic.Entity.ProductFeature", b =>
                {
                    b.Navigation("ProductGroup");
                });

            modelBuilder.Entity("WarehousingServic.Entity.ReceiptFeature", b =>
                {
                    b.Navigation("ProductGroup");
                });

            modelBuilder.Entity("WarehousingServic.Entity.RemittanceFeature", b =>
                {
                    b.Navigation("ProductGroup");
                });
#pragma warning restore 612, 618
        }
    }
}