﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaWeb.Data;

#nullable disable

namespace SistemaWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220204220648_EnumDaysupdate")]
    partial class EnumDaysupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HorarioSucursal", b =>
                {
                    b.Property<int>("HorariosHorarioId")
                        .HasColumnType("int");

                    b.Property<int>("SucursalesSucursalId")
                        .HasColumnType("int");

                    b.HasKey("HorariosHorarioId", "SucursalesSucursalId");

                    b.HasIndex("SucursalesSucursalId");

                    b.ToTable("HorarioSucursal");
                });

            modelBuilder.Entity("SistemaWeb.Model.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoId"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CargoId");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("SistemaWeb.Model.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartamentoId"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SucursalId")
                        .HasColumnType("int");

                    b.HasKey("DepartamentoId");

                    b.HasIndex("SucursalId");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("SistemaWeb.Model.Direccion", b =>
                {
                    b.Property<int>("DireccionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DireccionId"), 1L, 1);

                    b.Property<string>("Bloque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int?>("NumeroDepartamento")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DireccionId");

                    b.ToTable("Direccion");
                });

            modelBuilder.Entity("SistemaWeb.Model.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpleadoId"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CargoId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<int?>("DireccionId")
                        .HasColumnType("int");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("CargoId");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("DireccionId");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("SistemaWeb.Model.Horario", b =>
                {
                    b.Property<int>("HorarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HorarioId"), 1L, 1);

                    b.Property<int>("DiaInicio")
                        .HasColumnType("int");

                    b.Property<int>("DiaTermino")
                        .HasColumnType("int");

                    b.Property<DateTime>("HoraInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraTermino")
                        .HasColumnType("datetime2");

                    b.HasKey("HorarioId");

                    b.ToTable("Horario");
                });

            modelBuilder.Entity("SistemaWeb.Model.Sucursal", b =>
                {
                    b.Property<int>("SucursalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SucursalId"), 1L, 1);

                    b.Property<int?>("DireccionId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SucursalId");

                    b.HasIndex("DireccionId")
                        .IsUnique()
                        .HasFilter("[DireccionId] IS NOT NULL");

                    b.ToTable("Sucursal");
                });

            modelBuilder.Entity("HorarioSucursal", b =>
                {
                    b.HasOne("SistemaWeb.Model.Horario", null)
                        .WithMany()
                        .HasForeignKey("HorariosHorarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaWeb.Model.Sucursal", null)
                        .WithMany()
                        .HasForeignKey("SucursalesSucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaWeb.Model.Departamento", b =>
                {
                    b.HasOne("SistemaWeb.Model.Sucursal", "Sucursal")
                        .WithMany("Departamentos")
                        .HasForeignKey("SucursalId");

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("SistemaWeb.Model.Empleado", b =>
                {
                    b.HasOne("SistemaWeb.Model.Cargo", "Cargo")
                        .WithMany("Empleados")
                        .HasForeignKey("CargoId");

                    b.HasOne("SistemaWeb.Model.Departamento", "Departamento")
                        .WithMany("Empleados")
                        .HasForeignKey("DepartamentoId");

                    b.HasOne("SistemaWeb.Model.Direccion", "Direccion")
                        .WithMany("Empleados")
                        .HasForeignKey("DireccionId");

                    b.Navigation("Cargo");

                    b.Navigation("Departamento");

                    b.Navigation("Direccion");
                });

            modelBuilder.Entity("SistemaWeb.Model.Sucursal", b =>
                {
                    b.HasOne("SistemaWeb.Model.Direccion", "Direccion")
                        .WithOne("Sucursal")
                        .HasForeignKey("SistemaWeb.Model.Sucursal", "DireccionId");

                    b.Navigation("Direccion");
                });

            modelBuilder.Entity("SistemaWeb.Model.Cargo", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("SistemaWeb.Model.Departamento", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("SistemaWeb.Model.Direccion", b =>
                {
                    b.Navigation("Empleados");

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("SistemaWeb.Model.Sucursal", b =>
                {
                    b.Navigation("Departamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
