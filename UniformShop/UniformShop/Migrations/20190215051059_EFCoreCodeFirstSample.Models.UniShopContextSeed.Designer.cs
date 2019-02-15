﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniformShop.Models;

namespace UniformShop.Migrations
{
    [DbContext(typeof(UniformShopContext))]
    [Migration("20190215051059_EFCoreCodeFirstSample.Models.UniShopContextSeed")]
    partial class EFCoreCodeFirstSampleModelsUniShopContextSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UniformShop.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName");

                    b.HasKey("categoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("UniformShop.Models.color", b =>
                {
                    b.Property<long>("colorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("colorName");

                    b.HasKey("colorId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("UniformShop.Models.Customer", b =>
                {
                    b.Property<long>("custId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address");

                    b.Property<long?>("cardNumber");

                    b.Property<string>("custName");

                    b.Property<string>("email");

                    b.Property<bool?>("notifications");

                    b.Property<string>("password");

                    b.Property<string>("phone");

                    b.Property<string>("userName");

                    b.HasKey("custId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("UniformShop.Models.Image", b =>
                {
                    b.Property<long>("imgId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("imgUrl");

                    b.HasKey("imgId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("UniformShop.Models.Item", b =>
                {
                    b.Property<long>("itemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("categoryId");

                    b.Property<long?>("colorId");

                    b.Property<string>("description");

                    b.Property<string>("itemName");

                    b.Property<long?>("sizeId");

                    b.HasKey("itemId");

                    b.HasIndex("colorId");

                    b.HasIndex("sizeId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("UniformShop.Models.Order", b =>
                {
                    b.Property<long>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("createdBy");

                    b.Property<string>("createdDate");

                    b.Property<long?>("custId");

                    b.Property<string>("date");

                    b.Property<long>("itemId");

                    b.Property<string>("modifiedBy");

                    b.Property<string>("modifiedDate");

                    b.HasKey("orderId");

                    b.HasIndex("custId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("UniformShop.Models.OrderDetail", b =>
                {
                    b.Property<long>("ordDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("orderId");

                    b.Property<bool>("orderStatus");

                    b.Property<int>("quantity");

                    b.HasKey("ordDetailId");

                    b.HasIndex("orderId");

                    b.ToTable("orderDetails");
                });

            modelBuilder.Entity("UniformShop.Models.size", b =>
                {
                    b.Property<long>("sizeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("sizeDescription");

                    b.Property<string>("sizeName");

                    b.HasKey("sizeId");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("UniformShop.Models.SubCategory", b =>
                {
                    b.Property<int>("subCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("categoryId");

                    b.Property<string>("subCategoryName");

                    b.HasKey("subCategoryId");

                    b.HasIndex("categoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("UniformShop.Models.Transaction", b =>
                {
                    b.Property<long>("tranId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("orderId");

                    b.Property<string>("paymentMethod");

                    b.Property<int>("profit");

                    b.Property<bool>("status");

                    b.Property<int>("totalAmt");

                    b.Property<string>("tranDate");

                    b.HasKey("tranId");

                    b.HasIndex("orderId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("UniformShop.Models.variation", b =>
                {
                    b.Property<long>("varId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("varId");

                    b.ToTable("Variations");
                });

            modelBuilder.Entity("UniformShop.Models.color", b =>
                {
                    b.HasOne("UniformShop.Models.variation")
                        .WithMany("Color")
                        .HasForeignKey("colorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UniformShop.Models.Image", b =>
                {
                    b.HasOne("UniformShop.Models.Item")
                        .WithMany("Images")
                        .HasForeignKey("imgId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniformShop.Models.variation")
                        .WithMany("Image")
                        .HasForeignKey("imgId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UniformShop.Models.Item", b =>
                {
                    b.HasOne("UniformShop.Models.color", "Color")
                        .WithMany()
                        .HasForeignKey("colorId");

                    b.HasOne("UniformShop.Models.size", "Size")
                        .WithMany()
                        .HasForeignKey("sizeId");
                });

            modelBuilder.Entity("UniformShop.Models.Order", b =>
                {
                    b.HasOne("UniformShop.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("custId");
                });

            modelBuilder.Entity("UniformShop.Models.OrderDetail", b =>
                {
                    b.HasOne("UniformShop.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("orderId");
                });

            modelBuilder.Entity("UniformShop.Models.SubCategory", b =>
                {
                    b.HasOne("UniformShop.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("categoryId");
                });

            modelBuilder.Entity("UniformShop.Models.Transaction", b =>
                {
                    b.HasOne("UniformShop.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("orderId");
                });

            modelBuilder.Entity("UniformShop.Models.variation", b =>
                {
                    b.HasOne("UniformShop.Models.Item")
                        .WithMany("variations")
                        .HasForeignKey("varId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
