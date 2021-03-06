// <auto-generated />
using DatoApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatoApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatoApi.Models.Dato", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cancion")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pelicula")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nombre");

                    b.ToTable("Datos");
                });
#pragma warning restore 612, 618
        }
    }
}
