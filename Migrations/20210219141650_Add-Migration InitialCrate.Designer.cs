// <auto-generated />
using ApiRnc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiRnc.Migrations
{
    [DbContext(typeof(ContrubuyenteContext))]
    [Migration("20210219141650_Add-Migration InitialCrate")]
    partial class AddMigrationInitialCrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiRnc.Models.Contribuyente", b =>
                {
                    b.Property<string>("RncEmpresa")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActividadEconomica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreComercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegimenDePagos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RncEmpresa");

                    b.ToTable("Contribuyentes");
                });
#pragma warning restore 612, 618
        }
    }
}
