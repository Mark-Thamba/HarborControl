﻿// <auto-generated />
using System;
using HarborControl.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HarborControl.Data.Migrations
{
    [DbContext(typeof(HarborControlContext))]
    [Migration("20210421223155_updatedockingtbl")]
    partial class updatedockingtbl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HarborControl.Domains.BoatStatuses", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BoatStatuses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("74fd6dd2-2166-489a-a076-94b12a9d6d38"),
                            Active = true,
                            Code = "Docke",
                            CreatedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Docked"
                        },
                        new
                        {
                            Id = new Guid("e87ef917-6010-4b4e-8ba8-0a9e99ccc8bc"),
                            Active = true,
                            Code = "Arri",
                            CreatedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Arriving"
                        },
                        new
                        {
                            Id = new Guid("be094685-5e2b-49a2-a43c-d99462bfda2a"),
                            Active = true,
                            Code = "Docki",
                            CreatedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Docking"
                        },
                        new
                        {
                            Id = new Guid("46b17989-5742-4fc4-8cb1-0cb982eefd8c"),
                            Active = true,
                            Code = "OnQu",
                            CreatedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "OnQueue"
                        });
                });

            modelBuilder.Entity("HarborControl.Domains.BoatTypes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("BoatType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MesuringUnitsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Speed")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MesuringUnitsId");

                    b.ToTable("BoatTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dd23fd5d-6c80-47cc-8f8b-1e471f23185d"),
                            Active = true,
                            BoatType = "Speedboat",
                            CreatedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            MesuringUnitsId = new Guid("bc098656-f905-4642-9ff8-0232a7ee3a32"),
                            ModifiedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Speed = 30.0
                        },
                        new
                        {
                            Id = new Guid("78063f1b-5e7d-4bce-9f23-e4f249163338"),
                            Active = true,
                            BoatType = "Sailboat",
                            CreatedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            MesuringUnitsId = new Guid("bc098656-f905-4642-9ff8-0232a7ee3a32"),
                            ModifiedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Speed = 15.0
                        },
                        new
                        {
                            Id = new Guid("54533da8-1701-41bf-a3e8-9207c71a0b50"),
                            Active = true,
                            BoatType = "Cargo Ship",
                            CreatedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            MesuringUnitsId = new Guid("bc098656-f905-4642-9ff8-0232a7ee3a32"),
                            ModifiedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Speed = 5.0
                        });
                });

            modelBuilder.Entity("HarborControl.Domains.DockedBoats", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("BoatStatusesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BoatTypesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BoatStatusesId");

                    b.HasIndex("BoatTypesId");

                    b.ToTable("DockingBoats");
                });

            modelBuilder.Entity("HarborControl.Domains.HarborQues", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("BoatStatusesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BoatTypesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DockingTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("HarborsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BoatStatusesId");

                    b.HasIndex("BoatTypesId");

                    b.HasIndex("HarborsId");

                    b.ToTable("HarborQues");
                });

            modelBuilder.Entity("HarborControl.Domains.Harbors", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MesuringUnitsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Parameter")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MesuringUnitsId");

                    b.ToTable("Harbors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("36a8fc3a-501e-4943-a950-40902850bc47"),
                            Active = true,
                            Code = "durb",
                            CreatedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            MesuringUnitsId = new Guid("698366a2-f82d-4759-97f6-101e9e8a1526"),
                            ModifiedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Durban",
                            Parameter = 10.0
                        },
                        new
                        {
                            Id = new Guid("7128ac76-34e7-46aa-83d9-32dbc0a97fcd"),
                            Active = false,
                            Code = "cape",
                            CreatedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            MesuringUnitsId = new Guid("698366a2-f82d-4759-97f6-101e9e8a1526"),
                            ModifiedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cape Town",
                            Parameter = 10.0
                        });
                });

            modelBuilder.Entity("HarborControl.Domains.MesuringUnits", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MesuringUnits");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bc098656-f905-4642-9ff8-0232a7ee3a32"),
                            Active = true,
                            Code = "kmh",
                            CreatedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "km/h"
                        },
                        new
                        {
                            Id = new Guid("698366a2-f82d-4759-97f6-101e9e8a1526"),
                            Active = true,
                            Code = "km",
                            CreatedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "km"
                        },
                        new
                        {
                            Id = new Guid("a2ad6a55-6147-4517-b370-41a04cfc555c"),
                            Active = false,
                            Code = "kmh",
                            CreatedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedDate = new DateTime(2021, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "miles"
                        });
                });

            modelBuilder.Entity("HarborControl.Domains.BoatTypes", b =>
                {
                    b.HasOne("HarborControl.Domains.MesuringUnits", "MesuringUnits")
                        .WithMany("BoatTypes")
                        .HasForeignKey("MesuringUnitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MesuringUnits");
                });

            modelBuilder.Entity("HarborControl.Domains.DockedBoats", b =>
                {
                    b.HasOne("HarborControl.Domains.BoatStatuses", "BoatStatuses")
                        .WithMany("DockedBoats")
                        .HasForeignKey("BoatStatusesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HarborControl.Domains.BoatTypes", "BoatTypes")
                        .WithMany("DockedBoats")
                        .HasForeignKey("BoatTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoatStatuses");

                    b.Navigation("BoatTypes");
                });

            modelBuilder.Entity("HarborControl.Domains.HarborQues", b =>
                {
                    b.HasOne("HarborControl.Domains.BoatStatuses", "BoatStatuses")
                        .WithMany("HarborQues")
                        .HasForeignKey("BoatStatusesId");

                    b.HasOne("HarborControl.Domains.BoatTypes", "BoatTypes")
                        .WithMany("HarborQues")
                        .HasForeignKey("BoatTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HarborControl.Domains.Harbors", "Harbors")
                        .WithMany()
                        .HasForeignKey("HarborsId");

                    b.Navigation("BoatStatuses");

                    b.Navigation("BoatTypes");

                    b.Navigation("Harbors");
                });

            modelBuilder.Entity("HarborControl.Domains.Harbors", b =>
                {
                    b.HasOne("HarborControl.Domains.MesuringUnits", "MesuringUnits")
                        .WithMany("Harbors")
                        .HasForeignKey("MesuringUnitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MesuringUnits");
                });

            modelBuilder.Entity("HarborControl.Domains.BoatStatuses", b =>
                {
                    b.Navigation("DockedBoats");

                    b.Navigation("HarborQues");
                });

            modelBuilder.Entity("HarborControl.Domains.BoatTypes", b =>
                {
                    b.Navigation("DockedBoats");

                    b.Navigation("HarborQues");
                });

            modelBuilder.Entity("HarborControl.Domains.MesuringUnits", b =>
                {
                    b.Navigation("BoatTypes");

                    b.Navigation("Harbors");
                });
#pragma warning restore 612, 618
        }
    }
}
