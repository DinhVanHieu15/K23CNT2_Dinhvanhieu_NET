using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DinhVanHieu_lap11.Models;

public partial class DinhVanHieuLap11Context : DbContext
{
    public DinhVanHieuLap11Context()
    {
    }

    public DinhVanHieuLap11Context(DbContextOptions<DinhVanHieuLap11Context> options)
        : base(options)
    {
    }

    public virtual DbSet<DvhEmployee> DvhEmployees { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=LAPTOP-LG42FLRB\\SQLEXPRESS;Database=DinhVanHieu_lap11;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DvhEmployee>(entity =>
        {
            entity.HasKey(e => e.DvhEmpId).HasName("PK__DvhEmplo__1B54E5C79FF6A1C0");

            entity.ToTable("DvhEmployee");

            entity.Property(e => e.DvhEmpId)
                .ValueGeneratedNever()
                .HasColumnName("dvhEmpId");
            entity.Property(e => e.DvhEmpLevel)
                .HasMaxLength(50)
                .HasColumnName("dvhEmpLevel");
            entity.Property(e => e.DvhEmpName)
                .HasMaxLength(100)
                .HasColumnName("dvhEmpName");
            entity.Property(e => e.DvhEmpStartDate).HasColumnName("dvhEmpStartDate");
            entity.Property(e => e.DvhEmpStatus).HasColumnName("dvhEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
