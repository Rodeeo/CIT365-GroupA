// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDeskRazor.Migrations
{
    [DbContext(typeof(MegaDeskRazorContext))]
    partial class MegaDeskRazorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("MegaDeskRazorPages.Models.Desk", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Depth")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaterialID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumDrawers")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("MaterialID");

                    b.ToTable("Desk");
                });

            modelBuilder.Entity("MegaDeskRazorPages.Models.DeskQuote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateEntry")
                        .HasColumnType("TEXT");

                    b.Property<int>("DeskID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RushID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalCost")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("DeskID");

                    b.HasIndex("RushID");

                    b.ToTable("DeskQuote");
                });

            modelBuilder.Entity("MegaDeskRazorPages.Models.DesktopMaterial", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ImageID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Material")
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("ImageID");

                    b.ToTable("DesktopMaterial");
                });

            modelBuilder.Entity("MegaDeskRazorPages.Models.MaterialImage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("MaterialImage");
                });

            modelBuilder.Entity("MegaDeskRazorPages.Models.Rush", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Days")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Rush");
                });

            modelBuilder.Entity("MegaDeskRazorPages.Models.Desk", b =>
                {
                    b.HasOne("MegaDeskRazorPages.Models.DesktopMaterial", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");
                });

            modelBuilder.Entity("MegaDeskRazorPages.Models.DeskQuote", b =>
                {
                    b.HasOne("MegaDeskRazorPages.Models.Desk", "Desk")
                        .WithMany()
                        .HasForeignKey("DeskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MegaDeskRazorPages.Models.Rush", "Rush")
                        .WithMany()
                        .HasForeignKey("RushID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Desk");

                    b.Navigation("Rush");
                });

            modelBuilder.Entity("MegaDeskRazorPages.Models.DesktopMaterial", b =>
                {
                    b.HasOne("MegaDeskRazorPages.Models.MaterialImage", "Image")
                        .WithMany()
                        .HasForeignKey("ImageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });
#pragma warning restore 612, 618
        }
    }
}
