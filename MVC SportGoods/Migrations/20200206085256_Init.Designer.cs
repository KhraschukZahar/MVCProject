﻿// <auto-generated />
using System;
using MVC_SportGoods;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_SportGoods.Migrations
{
    [DbContext(typeof(DBContent))]
    [Migration("20200206085256_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_SportGoods.Models.SportViewCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription");

                    b.Property<string>("categoryName");

                    b.HasKey("id");

                    b.ToTable("SportViewCategory");
                });

            modelBuilder.Entity("MVC_SportGoods.Models.SportsViewModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SportViewCategoryid");

                    b.Property<string>("description");

                    b.Property<string>("img");

                    b.Property<string>("name");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("SportViewCategoryid");

                    b.ToTable("SportGoods");
                });

            modelBuilder.Entity("MVC_SportGoods.Models.SportsViewModel", b =>
                {
                    b.HasOne("MVC_SportGoods.Models.SportViewCategory")
                        .WithMany("SportGoods")
                        .HasForeignKey("SportViewCategoryid");
                });
#pragma warning restore 612, 618
        }
    }
}
