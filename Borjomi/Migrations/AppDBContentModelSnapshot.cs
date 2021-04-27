﻿// <auto-generated />
using System;
using Borjomi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Borjomi.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Borjomi.Data.Models.Staff", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("bdate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("birth_date")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("edate")
                        .HasColumnType("datetime");

                    b.Property<string>("first_name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<string>("last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middle_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Staff");
                });
#pragma warning restore 612, 618
        }
    }
}
