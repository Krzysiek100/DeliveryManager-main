﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(ContextData))]
    [Migration("20201220093045_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Password")
                        .HasColumnType("BLOB");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Entities.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateDelivered")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateSent")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnType("TEXT");

                    b.Property<int>("DeliveryManId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SenderAddress")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryManId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("API.Entities.PackageStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PackageId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StatusDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.ToTable("PackageStatuses");
                });

            modelBuilder.Entity("API.Entities.Package", b =>
                {
                    b.HasOne("API.Entities.AppUser", "DeliveryMan")
                        .WithMany("PackagesInDelivery")
                        .HasForeignKey("DeliveryManId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryMan");
                });

            modelBuilder.Entity("API.Entities.PackageStatus", b =>
                {
                    b.HasOne("API.Entities.Package", "Package")
                        .WithMany("Statuses")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Navigation("PackagesInDelivery");
                });

            modelBuilder.Entity("API.Entities.Package", b =>
                {
                    b.Navigation("Statuses");
                });
#pragma warning restore 612, 618
        }
    }
}
