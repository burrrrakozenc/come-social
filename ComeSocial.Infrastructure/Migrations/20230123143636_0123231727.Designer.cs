﻿// <auto-generated />
using System;
using ComeSocial.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComeSocial.Infrastructure.Migrations
{
    [DbContext(typeof(ComeSocialDbContext))]
    [Migration("20230123143636_0123231727")]
    partial class _0123231727
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ComeSocial.Domain.SocialEvent.SocialEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubHeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SocialEvents", (string)null);
                });

            modelBuilder.Entity("ComeSocial.Domain.Tag.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tags", (string)null);
                });

            modelBuilder.Entity("ComeSocial.Domain.SocialEvent.SocialEvent", b =>
                {
                    b.OwnsMany("ComeSocial.Domain.Tag.ValueObjects.TagId", "Tags", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<Guid>("SocialEventId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("Value")
                                .HasColumnType("uniqueidentifier")
                                .HasColumnName("TagId");

                            b1.HasKey("Id");

                            b1.HasIndex("SocialEventId");

                            b1.ToTable("SocialEventTagIds", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("SocialEventId");
                        });

                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
