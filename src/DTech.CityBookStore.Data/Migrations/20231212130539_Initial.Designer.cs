﻿// <auto-generated />
using System;
using DTech.CityBookStore.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DTech.CityBookStore.Data.Migrations
{
    [DbContext(typeof(CityBookStoreContext))]
    [Migration("20231212130539_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DTech.CityBookStore.Domain.Books.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("DimensionHeight")
                        .HasColumnType("decimal(5, 2)")
                        .HasColumnName("DimensionHeight");

                    b.Property<decimal?>("DimensionLength")
                        .HasColumnType("decimal(5, 2)")
                        .HasColumnName("DimensionLength");

                    b.Property<decimal?>("DimensionWidth")
                        .HasColumnType("decimal(5, 2)")
                        .HasColumnName("DimensionWidth");

                    b.Property<int>("Edition")
                        .HasColumnType("int")
                        .HasColumnName("Edition");

                    b.Property<string>("ISBN10")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("ISBN10");

                    b.Property<string>("ISBN13")
                        .IsRequired()
                        .HasColumnType("varchar(13)")
                        .HasColumnName("ISBN13");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Language");

                    b.Property<int>("Pages")
                        .HasColumnType("int")
                        .HasColumnName("Pages");

                    b.Property<string>("Publishing")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Publishing");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.HasIndex("ISBN10")
                        .IsUnique()
                        .HasDatabaseName("IX_Book_Unique_ISBN10");

                    b.HasIndex("ISBN13")
                        .IsUnique()
                        .HasDatabaseName("IX_Book_Unique_ISBN13");

                    b.ToTable("Books", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
