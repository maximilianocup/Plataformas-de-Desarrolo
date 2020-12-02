﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("Model.Entidades.Detalle", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("detId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnName("fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("RecursoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TareaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tiempo")
                        .HasColumnName("tiempo")
                        .HasColumnType("int(5)");

                    b.HasKey("id");

                    b.HasIndex("RecursoId");

                    b.HasIndex("TareaId");

                    b.ToTable("Detalle");
                });

            modelBuilder.Entity("Model.Entidades.Recurso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nRecurso")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Recurso");
                });

            modelBuilder.Entity("Model.Entidades.Tarea", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("taskId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .HasColumnName("estado")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("Estimacion")
                        .HasColumnName("estimacion")
                        .HasColumnType("int(2)");

                    b.Property<int>("ResponsableId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("titulo")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnName("vencimiento")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("ResponsableId");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("Model.Entidades.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("userId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnName("pass")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nUsuario")
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Model.Entidades.Detalle", b =>
                {
                    b.HasOne("Model.Entidades.Recurso", "Recurso")
                        .WithMany()
                        .HasForeignKey("RecursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entidades.Tarea", "Tarea")
                        .WithMany()
                        .HasForeignKey("TareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entidades.Recurso", b =>
                {
                    b.HasOne("Model.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entidades.Tarea", b =>
                {
                    b.HasOne("Model.Entidades.Recurso", "Responsable")
                        .WithMany()
                        .HasForeignKey("ResponsableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
