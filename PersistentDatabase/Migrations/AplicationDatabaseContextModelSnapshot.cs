﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersistentDatabase;

namespace PersistentDatabase.Migrations
{
    [DbContext(typeof(AplicationDatabaseContext))]
    partial class AplicationDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersistentDatabase.Models.Area", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PisoId")
                        .HasColumnType("int");

                    b.Property<string>("PisoId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("PisoId1");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("PersistentDatabase.Models.Edificio", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Edificios");
                });

            modelBuilder.Entity("PersistentDatabase.Models.Piso", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EdificioId")
                        .HasColumnType("int");

                    b.Property<string>("EdificioId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EdificioId1");

                    b.ToTable("Pisos");
                });

            modelBuilder.Entity("PersistentDatabase.Models.Area", b =>
                {
                    b.HasOne("PersistentDatabase.Models.Piso", "Piso")
                        .WithMany("Areas")
                        .HasForeignKey("PisoId1");

                    b.Navigation("Piso");
                });

            modelBuilder.Entity("PersistentDatabase.Models.Piso", b =>
                {
                    b.HasOne("PersistentDatabase.Models.Edificio", "Edificio")
                        .WithMany()
                        .HasForeignKey("EdificioId1");

                    b.Navigation("Edificio");
                });

            modelBuilder.Entity("PersistentDatabase.Models.Piso", b =>
                {
                    b.Navigation("Areas");
                });
#pragma warning restore 612, 618
        }
    }
}
