﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoFinalMVC.Data;

namespace ProjetoFinalMVC.Migrations
{
    [DbContext(typeof(ProjetoFinalMVCContext))]
    partial class ProjetoFinalMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoFinalMVC.Models.Department", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ProjetoFinalMVC.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id");

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SellerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("ProjetoFinalMVC.Models.Seller", b =>
                {
                    b.Property<int>("Id");

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int?>("DeparmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DeparmentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("ProjetoFinalMVC.Models.SalesRecord", b =>
                {
                    b.HasOne("ProjetoFinalMVC.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("ProjetoFinalMVC.Models.Seller", b =>
                {
                    b.HasOne("ProjetoFinalMVC.Models.Department", "Deparment")
                        .WithMany("Sellers")
                        .HasForeignKey("DeparmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
