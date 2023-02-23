﻿// <auto-generated />
using DogsApi.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DogsApi.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230223174829_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DogsApi.Entities.DogEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("DogsApi.Entities.DogEntity", b =>
                {
                    b.OwnsOne("DogsApi.Entities.EntityAbstracts.Color", "Color", b1 =>
                        {
                            b1.Property<int>("DogEntityId")
                                .HasColumnType("integer");

                            b1.Property<string>("Value")
                                .HasColumnType("text");

                            b1.HasKey("DogEntityId");

                            b1.ToTable("Dogs");

                            b1.WithOwner()
                                .HasForeignKey("DogEntityId");
                        });

                    b.OwnsOne("DogsApi.Entities.EntityAbstracts.Name", "Name", b1 =>
                        {
                            b1.Property<int>("DogEntityId")
                                .HasColumnType("integer");

                            b1.Property<string>("Value")
                                .HasColumnType("text");

                            b1.HasKey("DogEntityId");

                            b1.ToTable("Dogs");

                            b1.WithOwner()
                                .HasForeignKey("DogEntityId");
                        });

                    b.OwnsOne("DogsApi.Entities.EntityAbstracts.TailLenth", "TailLenth", b1 =>
                        {
                            b1.Property<int>("DogEntityId")
                                .HasColumnType("integer");

                            b1.Property<double>("Value")
                                .HasColumnType("double precision");

                            b1.HasKey("DogEntityId");

                            b1.ToTable("Dogs");

                            b1.WithOwner()
                                .HasForeignKey("DogEntityId");
                        });

                    b.OwnsOne("DogsApi.Entities.EntityAbstracts.Weight", "Weight", b1 =>
                        {
                            b1.Property<int>("DogEntityId")
                                .HasColumnType("integer");

                            b1.Property<double>("Value")
                                .HasColumnType("double precision");

                            b1.HasKey("DogEntityId");

                            b1.ToTable("Dogs");

                            b1.WithOwner()
                                .HasForeignKey("DogEntityId");
                        });

                    b.Navigation("Color");

                    b.Navigation("Name");

                    b.Navigation("TailLenth");

                    b.Navigation("Weight");
                });
#pragma warning restore 612, 618
        }
    }
}