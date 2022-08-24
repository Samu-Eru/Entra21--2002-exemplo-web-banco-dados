using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Mapeamentos
{
    //DB First: Criar uma aplicação onde o banco de dadis existe
    //Code First: Criar um banco de dados a partir de uma aplicação existente
    //Seed: alimentar o banco de dados com os resgistros
    //Migration: representação do mapeamento que será aplicado no banco de dados
    //Mapeamento: representação de entidade e, tabelas, colunas, indices...
    internal class RacaMapeamentos : IEntityTypeConfiguration<Raca>
    {
        public void Configure(EntityTypeBuilder<Raca> builder)
        {
            builder.ToTable("racas");

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.Especie)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("especie"); // Not null

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(30)
                .IsRequired()
                .HasColumnName("nome"); // Not null

            builder.HasData(
                new Raca
            {
                    Id = 1,
                Nome = "Frajola",
                Especie = "Gato"
            },
            new Raca
            {
                Id = 2,
                Nome = "Piu-Piu",
                Especie = "Capivara"
            }
            );
        }
    }
}
