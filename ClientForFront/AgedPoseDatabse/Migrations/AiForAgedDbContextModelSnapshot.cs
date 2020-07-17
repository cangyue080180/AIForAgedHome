﻿// <auto-generated />
using System;
using AgedPoseDatabse.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgedPoseDatabse.Migrations
{
    [DbContext(typeof(AiForAgedDbContext))]
    partial class AiForAgedDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AgedPoseDatabse.Models.AgesInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Address")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ContacterName")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("ContacterPhone")
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NurseName")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<long>("RoomInfoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoomInfoId");

                    b.ToTable("AgesInfo");
                });

            modelBuilder.Entity("AgedPoseDatabse.Models.CameraInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("FactoryInfo")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("IpAddress")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<long>("RoomInfoId")
                        .HasColumnType("bigint");

                    b.Property<long>("ServerInfoId")
                        .HasColumnType("bigint");

                    b.Property<string>("VideoAddress")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("RoomInfoId");

                    b.HasIndex("ServerInfoId");

                    b.ToTable("CameraInfo");
                });

            modelBuilder.Entity("AgedPoseDatabse.Models.PoseInfo", b =>
                {
                    b.Property<long>("AgesInfoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<int>("TimeDown")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TimeIn")
                        .HasColumnType("time");

                    b.Property<int>("TimeLie")
                        .HasColumnType("int");

                    b.Property<int>("TimeOther")
                        .HasColumnType("int");

                    b.Property<int>("TimeSit")
                        .HasColumnType("int");

                    b.Property<int>("TimeStand")
                        .HasColumnType("int");

                    b.HasKey("AgesInfoId", "Date");

                    b.ToTable("PoseInfo");
                });

            modelBuilder.Entity("AgedPoseDatabse.Models.RoomInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("RoomSize")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RoomInfo");
                });

            modelBuilder.Entity("AgedPoseDatabse.Models.ServerInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("FactoryInfo")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<byte>("MaxCameraCount")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("ServerInfo");
                });

            modelBuilder.Entity("AgedPoseDatabse.Models.UserInfo", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("Authority")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(16)")
                        .HasMaxLength(16);

                    b.HasKey("Name");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("AgedPoseDatabse.Models.AgesInfo", b =>
                {
                    b.HasOne("AgedPoseDatabse.Models.RoomInfo", "RoomInfo")
                        .WithMany("AgesInfos")
                        .HasForeignKey("RoomInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AgedPoseDatabse.Models.CameraInfo", b =>
                {
                    b.HasOne("AgedPoseDatabse.Models.RoomInfo", "RoomInfo")
                        .WithMany()
                        .HasForeignKey("RoomInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgedPoseDatabse.Models.ServerInfo", "ServerInfo")
                        .WithMany("CameraInfos")
                        .HasForeignKey("ServerInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
