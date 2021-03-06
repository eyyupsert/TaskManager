﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManager.Models;

namespace TaskManager.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskManager.Models.Departman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("departmanAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("departmanlars");
                });

            modelBuilder.Entity("TaskManager.Models.Gorev", b =>
                {
                    b.Property<int>("gorevId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("gorevAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gorevDetay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("gorevDurum")
                        .HasColumnType("bit");

                    b.Property<DateTime>("gorevSonTeslimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("personelId")
                        .HasColumnType("int");

                    b.HasKey("gorevId");

                    b.HasIndex("personelId");

                    b.ToTable("gorevs");
                });

            modelBuilder.Entity("TaskManager.Models.Personel", b =>
                {
                    b.Property<int>("personelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("departId")
                        .HasColumnType("int");

                    b.Property<DateTime>("iseBaslamaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("mailAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personelAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personelSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("personelId");

                    b.HasIndex("departId");

                    b.ToTable("personellers");
                });

            modelBuilder.Entity("TaskManager.Models.Gorev", b =>
                {
                    b.HasOne("TaskManager.Models.Personel", "per")
                        .WithMany("gorevs")
                        .HasForeignKey("personelId");
                });

            modelBuilder.Entity("TaskManager.Models.Personel", b =>
                {
                    b.HasOne("TaskManager.Models.Departman", "depart")
                        .WithMany("personels")
                        .HasForeignKey("departId");
                });
#pragma warning restore 612, 618
        }
    }
}
