﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sacramento.Data;

namespace Sacramento.Migrations
{
    [DbContext(typeof(SacramentoContext))]
    partial class SacramentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sacramento.Models.Hymn", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Hymn");
                });

            modelBuilder.Entity("Sacramento.Models.Leader", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CallDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Leader");
                });

            modelBuilder.Entity("Sacramento.Models.Plan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClosingPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClosingSongID")
                        .HasColumnType("int");

                    b.Property<int>("ConductingLeaderID")
                        .HasColumnType("int");

                    b.Property<int?>("IntermediateSongID")
                        .HasColumnType("int");

                    b.Property<DateTime>("MeetingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OpeningPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpeningSongID")
                        .HasColumnType("int");

                    b.Property<int>("PresidingLeaderID")
                        .HasColumnType("int");

                    b.Property<int>("SacramentHymnID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClosingSongID");

                    b.HasIndex("ConductingLeaderID");

                    b.HasIndex("IntermediateSongID");

                    b.HasIndex("OpeningSongID");

                    b.HasIndex("PresidingLeaderID");

                    b.HasIndex("SacramentHymnID");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("Sacramento.Models.Speaker", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlanID")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PlanID");

                    b.ToTable("Speaker");
                });

            modelBuilder.Entity("Sacramento.Models.Plan", b =>
                {
                    b.HasOne("Sacramento.Models.Hymn", "ClosingSong")
                        .WithMany()
                        .HasForeignKey("ClosingSongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sacramento.Models.Leader", "ConductingLeader")
                        .WithMany()
                        .HasForeignKey("ConductingLeaderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sacramento.Models.Hymn", "IntermediateSong")
                        .WithMany()
                        .HasForeignKey("IntermediateSongID");

                    b.HasOne("Sacramento.Models.Hymn", "OpeningSong")
                        .WithMany()
                        .HasForeignKey("OpeningSongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sacramento.Models.Leader", "PresidingLeader")
                        .WithMany()
                        .HasForeignKey("PresidingLeaderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sacramento.Models.Hymn", "SacramentHymn")
                        .WithMany()
                        .HasForeignKey("SacramentHymnID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClosingSong");

                    b.Navigation("ConductingLeader");

                    b.Navigation("IntermediateSong");

                    b.Navigation("OpeningSong");

                    b.Navigation("PresidingLeader");

                    b.Navigation("SacramentHymn");
                });

            modelBuilder.Entity("Sacramento.Models.Speaker", b =>
                {
                    b.HasOne("Sacramento.Models.Plan", null)
                        .WithMany("Enrollments")
                        .HasForeignKey("PlanID");
                });

            modelBuilder.Entity("Sacramento.Models.Plan", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
