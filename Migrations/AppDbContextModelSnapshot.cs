﻿// <auto-generated />
using System;
using CordiSimpleNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CordiSimpleNet.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CordiSimpleNet.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date_end")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_end");

                    b.Property<DateTime>("Date_start")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_start");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("description");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("location");

                    b.Property<int>("Max_slots")
                        .HasColumnType("int")
                        .HasColumnName("max_slots");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<int>("Occupied_slots")
                        .HasColumnType("int")
                        .HasColumnName("occupied_slots");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date_end = new DateTime(2024, 11, 10, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Date_start = new DateTime(2024, 11, 10, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "un festival de música al aire libre con artistas nacionales e internacionales.",
                            Location = "parque simón bolívar, bogotá",
                            Max_slots = 250,
                            Name = "festival de música",
                            Occupied_slots = 0,
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Date_end = new DateTime(2024, 10, 29, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Date_start = new DateTime(2024, 10, 25, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "encuentro literario con escritores y editoriales locales.",
                            Location = "plaza mayor, medellín",
                            Max_slots = 250,
                            Name = "feria del libro",
                            Occupied_slots = 0,
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            Date_end = new DateTime(2024, 12, 1, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Date_start = new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "exposición de avances tecnológicos y nuevas innovaciones.",
                            Location = "corferias, bogotá",
                            Max_slots = 250,
                            Name = "expo tecnología",
                            Occupied_slots = 0,
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Date_end = new DateTime(2024, 11, 20, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Date_start = new DateTime(2024, 11, 20, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "exposición de obras de arte contemporáneo de artistas colombianos.",
                            Location = "museo de arte moderno, cartagena",
                            Max_slots = 250,
                            Name = "exposición de arte moderno",
                            Occupied_slots = 0,
                            Status = false
                        },
                        new
                        {
                            Id = 5,
                            Date_end = new DateTime(2024, 12, 15, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Date_start = new DateTime(2024, 12, 15, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "concierto navideño con coros y orquestas locales.",
                            Location = "teatro metropolitano, medellín",
                            Max_slots = 250,
                            Name = "concierto de navidad",
                            Occupied_slots = 0,
                            Status = true
                        },
                        new
                        {
                            Id = 6,
                            Date_end = new DateTime(2024, 11, 2, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            Date_start = new DateTime(2024, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "proyección de películas y charlas con cineastas colombianos.",
                            Location = "cine colombia, cali",
                            Max_slots = 250,
                            Name = "festival de cine",
                            Occupied_slots = 0,
                            Status = true
                        },
                        new
                        {
                            Id = 7,
                            Date_end = new DateTime(2024, 11, 7, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Date_start = new DateTime(2024, 11, 5, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "encuentro de profesionales de la salud con charlas y talleres.",
                            Location = "hotel hilton, cartagena",
                            Max_slots = 250,
                            Name = "congreso de medicina",
                            Occupied_slots = 0,
                            Status = true
                        },
                        new
                        {
                            Id = 8,
                            Date_end = new DateTime(2024, 12, 12, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Date_start = new DateTime(2024, 12, 10, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "muestra de la gastronomía colombiana con degustaciones y talleres.",
                            Location = "centro de convenciones, cali",
                            Max_slots = 250,
                            Name = "expo gastronómica",
                            Occupied_slots = 0,
                            Status = false
                        },
                        new
                        {
                            Id = 9,
                            Date_end = new DateTime(2024, 11, 18, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Date_start = new DateTime(2024, 11, 18, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "presentaciones de grupos de danza folclórica de diferentes regiones.",
                            Location = "plaza mayor, medellín",
                            Max_slots = 250,
                            Name = "festival de danza folclórica",
                            Occupied_slots = 0,
                            Status = true
                        },
                        new
                        {
                            Id = 10,
                            Date_end = new DateTime(2024, 12, 20, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Date_start = new DateTime(2024, 12, 20, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "competencia de atletismo en diferentes categorías.",
                            Location = "parque simón bolívar, bogotá",
                            Max_slots = 250,
                            Name = "carrera 10k",
                            Occupied_slots = 0,
                            Status = true
                        });
                });

            modelBuilder.Entity("CordiSimpleNet.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Event_id")
                        .HasColumnType("int")
                        .HasColumnName("event_id");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.Property<int>("User_id")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("Event_id");

                    b.HasIndex("User_id");

                    b.ToTable("reservations");
                });

            modelBuilder.Entity("CordiSimpleNet.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Permite usar endpoint con jwt",
                            Name = "Usuario Administrador"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Permite usar endpoints que NO tengan jwt",
                            Name = "Usuario General"
                        });
                });

            modelBuilder.Entity("CordiSimpleNet.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("password");

                    b.Property<int>("Role_id")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("Role_id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("CordiSimpleNet.Models.Reservation", b =>
                {
                    b.HasOne("CordiSimpleNet.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("Event_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CordiSimpleNet.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CordiSimpleNet.Models.User", b =>
                {
                    b.HasOne("CordiSimpleNet.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("Role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });
#pragma warning restore 612, 618
        }
    }
}
