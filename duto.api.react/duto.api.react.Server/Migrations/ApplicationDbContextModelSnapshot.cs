﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using duto.api.react.Server.DatabaseContext;

#nullable disable

namespace duto.api.react.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("duto.api.react.Server.Models.ForexCandle", b =>
                {
                    b.Property<int>("ForexCandleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ForexCandleID"));

                    b.Property<string>("c")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("h")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("l")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("n")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("o")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("t")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("v")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vw")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ForexCandleID");

                    b.ToTable("ForexCandles");
                });
#pragma warning restore 612, 618
        }
    }
}
