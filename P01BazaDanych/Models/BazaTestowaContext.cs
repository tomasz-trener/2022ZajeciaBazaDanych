using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace P01BazaDanych.Models;

public partial class BazaTestowaContext : DbContext
{
    public BazaTestowaContext()
    {
    }

    public BazaTestowaContext(DbContextOptions<BazaTestowaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Osoby> Osobies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=serwertl.database.windows.net;Initial Catalog=bazaTestowa;User ID=tomasz;Password=Politechnika20");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Osoby>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__osoby__3213E83FD005E70E");

            entity.ToTable("osoby");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataUr).HasColumnName("dataUr");
            entity.Property(e => e.Imie)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("imie");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nazwisko");
            entity.Property(e => e.Waga)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("waga");
            entity.Property(e => e.Wzrost).HasColumnName("wzrost");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
