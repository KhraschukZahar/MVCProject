﻿// <auto-generated />
using MVC_SportGoods;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_SportGoods.Migrations
{
    [DbContext(typeof(DBContent))]
    partial class DBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_SportGoods.Models.SportsViewModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<string>("img");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.ToTable("SportGoods");
                });
#pragma warning restore 612, 618
        }
    }
}
