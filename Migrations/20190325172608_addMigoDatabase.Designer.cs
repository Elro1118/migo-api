﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using migo_api;

namespace migo_api.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190325172608_addMigoDatabase")]
    partial class addMigoDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("migo_api.Model.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("localId");

                    b.HasKey("Id");

                    b.HasIndex("localId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("migo_api.Model.Local", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<string>("Schedule");

                    b.HasKey("Id");

                    b.ToTable("Locals");
                });

            modelBuilder.Entity("migo_api.Model.Volunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Telephone");

                    b.Property<int>("localId");

                    b.HasKey("Id");

                    b.HasIndex("localId");

                    b.ToTable("Volunteers");
                });

            modelBuilder.Entity("migo_api.Model.Comment", b =>
                {
                    b.HasOne("migo_api.Model.Local", "Local")
                        .WithMany("Comments")
                        .HasForeignKey("localId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("migo_api.Model.Volunteer", b =>
                {
                    b.HasOne("migo_api.Model.Local", "Local")
                        .WithMany("Volunteers")
                        .HasForeignKey("localId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
