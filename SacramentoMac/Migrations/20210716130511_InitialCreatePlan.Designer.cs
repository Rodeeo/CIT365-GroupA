// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Sacramento.Migrations
{
    [DbContext(typeof(SacramentoContext))]
    [Migration("20210716130511_InitialCreatePlan")]
    partial class InitialCreatePlan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Sacramento.Models.Hymn", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Hymn");
                });

            modelBuilder.Entity("Sacramento.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("Sacramento.Models.Plan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClosingPrayer")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClosingSongID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConductingLeaderID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IntermediateSongID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("MeetingDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("OpeningPrayer")
                        .HasColumnType("TEXT");

                    b.Property<int>("OpeningSongID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PresidingLeaderID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SacramentHymnID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("ClosingSongID");

                    b.HasIndex("ConductingLeaderID");

                    b.HasIndex("IntermediateSongID");

                    b.HasIndex("OpeningSongID");

                    b.HasIndex("PresidingLeaderID");

                    b.HasIndex("SacramentHymnID");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("Sacramento.Models.Leader", b =>
                {
                    b.HasBaseType("Sacramento.Models.Person");

                    b.Property<string>("CallDescription")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Leader");
                });

            modelBuilder.Entity("Sacramento.Models.Speaker", b =>
                {
                    b.HasBaseType("Sacramento.Models.Person");

                    b.Property<int?>("PlanID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasIndex("PlanID");

                    b.HasDiscriminator().HasValue("Speaker");
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
                        .HasForeignKey("IntermediateSongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
