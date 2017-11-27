﻿// <auto-generated />
using DemoFornecedores.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DemoFornecedores.Infraestructure.Migrations
{
    [DbContext(typeof(DemoFornecedoresContext))]
    partial class DemoFornecedoresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoFornecedores.Domain.Entities.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Documento");

                    b.Property<string>("Nome");

                    b.Property<int>("SetorId");

                    b.HasKey("Id");

                    b.HasIndex("SetorId");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("DemoFornecedores.Domain.Entities.Setor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Setor");
                });

            modelBuilder.Entity("DemoFornecedores.Domain.Entities.Fornecedor", b =>
                {
                    b.HasOne("DemoFornecedores.Domain.Entities.Setor", "Setor")
                        .WithMany()
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
