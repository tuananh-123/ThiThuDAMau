using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _1.DAL.Models
{
    public partial class SOF205FINALNONEContext : DbContext
    {
        public SOF205FINALNONEContext()
        {
        }

        public SOF205FINALNONEContext(DbContextOptions<SOF205FINALNONEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chunhan> Chunhans { get; set; } = null!;
        public virtual DbSet<Congty> Congties { get; set; } = null!;
        public virtual DbSet<Cuahang> Cuahangs { get; set; } = null!;
        public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; } = null!;
        public virtual DbSet<Nhanvien> Nhanviens { get; set; } = null!;
        public virtual DbSet<Sanpham> Sanphams { get; set; } = null!;
        public virtual DbSet<Thucung> Thucungs { get; set; } = null!;
        public virtual DbSet<Trungtam> Trungtams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-DQTVDBB\\SQLSERVERLOCAL;Database=SOF205FINALNONE;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chunhan>(entity =>
            {
                entity.ToTable("CHUNHAN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<Congty>(entity =>
            {
                entity.ToTable("CONGTY");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<Cuahang>(entity =>
            {
                entity.ToTable("CUAHANG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCn).HasColumnName("idCN");

                entity.Property(e => e.Loaihang)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("loaihang");

                entity.Property(e => e.Mota)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("mota");

                entity.Property(e => e.Ngaydangky)
                    .HasColumnType("date")
                    .HasColumnName("ngaydangky");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");

                entity.HasOne(d => d.IdCnNavigation)
                    .WithMany(p => p.Cuahangs)
                    .HasForeignKey(d => d.IdCn)
                    .HasConstraintName("FKCH_TT");
            });

            modelBuilder.Entity<Nhacungcap>(entity =>
            {
                entity.ToTable("NHACUNGCAP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.ToTable("NHANVIEN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("diachi");

                entity.Property(e => e.IdCn).HasColumnName("idCN");

                entity.Property(e => e.Ngaytuyendung)
                    .HasColumnType("date")
                    .HasColumnName("ngaytuyendung");

                entity.Property(e => e.Sodienthoai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sodienthoai");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");

                entity.HasOne(d => d.IdCnNavigation)
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => d.IdCn)
                    .HasConstraintName("FKNV_CT");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.ToTable("SANPHAM");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Giatien).HasColumnName("giatien");

                entity.Property(e => e.IdNcc).HasColumnName("idNCC");

                entity.Property(e => e.Mota)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("mota");

                entity.Property(e => e.Soluongtonkho).HasColumnName("soluongtonkho");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");

                entity.HasOne(d => d.IdNccNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.IdNcc)
                    .HasConstraintName("FK_SP_NCC");
            });

            modelBuilder.Entity<Thucung>(entity =>
            {
                entity.ToTable("THUCUNG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCn).HasColumnName("idCN");

                entity.Property(e => e.Loai)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("loai");

                entity.Property(e => e.Maulong)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maulong");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");

                entity.Property(e => e.Tuoi).HasColumnName("tuoi");

                entity.HasOne(d => d.IdCnNavigation)
                    .WithMany(p => p.Thucungs)
                    .HasForeignKey(d => d.IdCn)
                    .HasConstraintName("FK_TC_CN");
            });

            modelBuilder.Entity<Trungtam>(entity =>
            {
                entity.ToTable("TRUNGTAM");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
