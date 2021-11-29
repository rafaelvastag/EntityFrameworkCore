using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ModBasic.Models
{
    public partial class PessoaContext : DbContext
    {
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<PessoaTelefone> PessoaTelefone { get; set; }
        public virtual DbSet<Telefone> Telefone { get; set; }
        public virtual DbSet<TelefoneTipo> TelefoneTipo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-NKE9617\SQLEXPRESS;Initial Catalog=Pessoa; Integrated Security = True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.ToTable("ENDERECO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bairro)
                    .HasColumnName("BAIRRO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cep).HasColumnName("CEP");

                entity.Property(e => e.Cidade)
                    .HasColumnName("CIDADE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Logradouro)
                    .HasColumnName("LOGRADOURO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Numero).HasColumnName("NUMERO");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.ToTable("PESSOA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cpf).HasColumnName("CPF");

                entity.Property(e => e.Endereco).HasColumnName("ENDERECO");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.EnderecoNavigation)
                    .WithMany(p => p.Pessoa)
                    .HasForeignKey(d => d.Endereco)
                    .HasConstraintName("FK_PESSOA_ENDERECO");
            });

            modelBuilder.Entity<PessoaTelefone>(entity =>
            {
                entity.HasKey(e => new { e.IdPessoa, e.IdTelefone });

                entity.ToTable("PESSOA_TELEFONE");

                entity.Property(e => e.IdPessoa).HasColumnName("ID_PESSOA");

                entity.Property(e => e.IdTelefone).HasColumnName("ID_TELEFONE");

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.PessoaTelefone)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PESSOA");

                entity.HasOne(d => d.IdTelefoneNavigation)
                    .WithMany(p => p.PessoaTelefone)
                    .HasForeignKey(d => d.IdTelefone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TELEFONE");
            });

            modelBuilder.Entity<Telefone>(entity =>
            {
                entity.ToTable("TELEFONE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ddd).HasColumnName("DDD");

                entity.Property(e => e.Numero).HasColumnName("NUMERO");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Telefone)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("FK_TELEFONE_TIPO_TELEFONE");
            });

            modelBuilder.Entity<TelefoneTipo>(entity =>
            {
                entity.ToTable("TELEFONE_TIPO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
