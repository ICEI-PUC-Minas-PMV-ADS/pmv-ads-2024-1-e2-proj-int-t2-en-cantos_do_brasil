﻿// <auto-generated />
using Encantos_do_Brasil.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Encantos_do_Brasil.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240428165711_M03")]
    partial class M03
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Encantos_do_Brasil.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdEstado");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdRegiao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdRegiao");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("Custo")
                        .HasColumnType("real");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCidade");

                    b.ToTable("Hoteis");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.PontoTuristico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("Custo")
                        .HasColumnType("real");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCidade");

                    b.ToTable("PontosTuristicos");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.Preferencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdCidade")
                        .HasColumnType("int");

                    b.Property<int>("IdHotel")
                        .HasColumnType("int");

                    b.Property<int>("IdPontoTuristico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCidade");

                    b.HasIndex("IdHotel");

                    b.HasIndex("IdPontoTuristico");

                    b.ToTable("Preferencias");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.RegiaoPais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RegioesPais");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.TelefoneHotel", b =>
                {
                    b.Property<int>("IdTelefone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTelefone"), 1L, 1);

                    b.Property<int>("IdHotel")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTelefone");

                    b.HasIndex("IdHotel");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.Cidade", b =>
                {
                    b.HasOne("Encantos_do_Brasil.Models.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("IdEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.Estado", b =>
                {
                    b.HasOne("Encantos_do_Brasil.Models.RegiaoPais", "Regiao")
                        .WithMany("Estados")
                        .HasForeignKey("IdRegiao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Regiao");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.Hotel", b =>
                {
                    b.HasOne("Encantos_do_Brasil.Models.Cidade", "Cidade")
                        .WithMany("Hoteis")
                        .HasForeignKey("IdCidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.PontoTuristico", b =>
                {
                    b.HasOne("Encantos_do_Brasil.Models.Cidade", "Cidade")
                        .WithMany("PontosTuristicos")
                        .HasForeignKey("IdCidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.Preferencia", b =>
                {
                    b.HasOne("Encantos_do_Brasil.Models.Cidade", "Cidade")
                        .WithMany("Preferencias")
                        .HasForeignKey("IdCidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Encantos_do_Brasil.Models.Hotel", "Hotel")
                        .WithMany("Preferencias")
                        .HasForeignKey("IdHotel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Encantos_do_Brasil.Models.PontoTuristico", "PontoTuristico")
                        .WithMany("Preferencias")
                        .HasForeignKey("IdPontoTuristico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Hotel");

                    b.Navigation("PontoTuristico");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.TelefoneHotel", b =>
                {
                    b.HasOne("Encantos_do_Brasil.Models.Hotel", "Hotel")
                        .WithMany("Telefones")
                        .HasForeignKey("IdHotel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.Cidade", b =>
                {
                    b.Navigation("Hoteis");

                    b.Navigation("PontosTuristicos");

                    b.Navigation("Preferencias");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.Estado", b =>
                {
                    b.Navigation("Cidades");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.Hotel", b =>
                {
                    b.Navigation("Preferencias");

                    b.Navigation("Telefones");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.PontoTuristico", b =>
                {
                    b.Navigation("Preferencias");
                });

            modelBuilder.Entity("Encantos_do_Brasil.Models.RegiaoPais", b =>
                {
                    b.Navigation("Estados");
                });
#pragma warning restore 612, 618
        }
    }
}
