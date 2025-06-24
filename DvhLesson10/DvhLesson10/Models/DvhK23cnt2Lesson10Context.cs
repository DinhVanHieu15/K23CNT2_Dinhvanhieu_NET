using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DvhLesson10.Models;

public partial class DvhK23cnt2Lesson10Context : DbContext
{
    public DvhK23cnt2Lesson10Context()
    {
    }

    public DvhK23cnt2Lesson10Context(DbContextOptions<DvhK23cnt2Lesson10Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Categroy> Categroys { get; set; }

  //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//
 //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263. //
       // => optionsBuilder.UseSqlServer("Server=LAPTOP-LG42FLRB\\SQLEXPRESS;Database=DvhK23Cnt2Lesson10;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True"); //

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categroy>(entity =>
        {
            entity.HasKey(e => e.CateId);

            entity.ToTable("Categroy");

            entity.Property(e => e.CateId).HasColumnName("CateID");
            entity.Property(e => e.CateName)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
