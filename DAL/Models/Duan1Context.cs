using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class Duan1Context : DbContext
{
    public Duan1Context()
    {
    }

    public Duan1Context(DbContextOptions<Duan1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<HinhThucTt> HinhThucTts { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<UuDai> UuDais { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-8CVDJNS6;Database=DUAN1;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HinhThucTt>(entity =>
        {
            entity.HasKey(e => e.MaThanhToan).HasName("PK__HinhThuc__D4B258449BBFE6F3");

            entity.ToTable("HinhThucTT");

            entity.Property(e => e.MaThanhToan).ValueGeneratedNever();
            entity.Property(e => e.Mota).HasMaxLength(100);
            entity.Property(e => e.TenHt)
                .HasMaxLength(50)
                .HasColumnName("TenHT");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.Idhd).HasName("PK__HoaDon__B87C1A0753DEEF7D");

            entity.ToTable("HoaDon");

            entity.Property(e => e.Idhd)
                .ValueGeneratedNever()
                .HasColumnName("IDHD");
            entity.Property(e => e.Idtk).HasColumnName("IDTK");
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IdtkNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.Idtk)
                .HasConstraintName("FK__HoaDon__IDTK__300424B4");

            entity.HasOne(d => d.MaHinhThucNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaHinhThuc)
                .HasConstraintName("FK__HoaDon__MaHinhTh__2F10007B");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK__HoaDon__MaKH__2E1BDC42");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.Idhdct).HasName("PK__HoaDonCh__F8B336779EA7F0A0");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.Idhdct)
                .ValueGeneratedNever()
                .HasColumnName("IDHDCT");
            entity.Property(e => e.Idhd).HasColumnName("IDHD");
            entity.Property(e => e.Idsp).HasColumnName("IDSP");

            entity.HasOne(d => d.IdhdNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.Idhd)
                .HasConstraintName("FK__HoaDonChiT__IDHD__32E0915F");

            entity.HasOne(d => d.IdspNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.Idsp)
                .HasConstraintName("FK__HoaDonChiT__IDSP__33D4B598");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.Idkh).HasName("PK__KhachHan__B87DC1A764DF6EB9");

            entity.ToTable("KhachHang");

            entity.Property(e => e.Idkh)
                .ValueGeneratedNever()
                .HasColumnName("IDKH");
            entity.Property(e => e.Diachi).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .HasColumnName("SDT");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.IdnhaCungCap).HasName("PK__NhaCungC__47B484CD532DF03C");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.IdnhaCungCap)
                .ValueGeneratedNever()
                .HasColumnName("IDNhaCungCap");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .HasColumnName("SDT");
            entity.Property(e => e.TenNguoiLienHe).HasMaxLength(50);
            entity.Property(e => e.TenNhaCungCap).HasMaxLength(100);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Idsp).HasName("PK__SanPham__B87C02A519B7AE8D");

            entity.ToTable("SanPham");

            entity.Property(e => e.Idsp)
                .ValueGeneratedNever()
                .HasColumnName("IDSP");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IdnhaCungCap).HasColumnName("IDNhaCungCap");
            entity.Property(e => e.Mota).HasMaxLength(1000);
            entity.Property(e => e.TenSp)
                .HasMaxLength(100)
                .HasColumnName("TenSP");

            entity.HasOne(d => d.IdnhaCungCapNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdnhaCungCap)
                .HasConstraintName("FK__SanPham__IDNhaCu__29572725");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.Idtk).HasName("PK__TaiKhoan__B87C3A83CFF271FD");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.Idtk)
                .ValueGeneratedNever()
                .HasColumnName("IDTK");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.HovaTen).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .HasColumnName("SDT");
            entity.Property(e => e.TenChucVu).HasMaxLength(100);
            entity.Property(e => e.TrangThai).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<UuDai>(entity =>
        {
            entity.HasKey(e => e.Idud).HasName("PK__UuDai__B87C126BE6B8269F");

            entity.ToTable("UuDai");

            entity.Property(e => e.Idud)
                .ValueGeneratedNever()
                .HasColumnName("IDUD");
            entity.Property(e => e.Idtk).HasColumnName("IDTK");

            entity.HasOne(d => d.IdtkNavigation).WithMany(p => p.UuDais)
                .HasForeignKey(d => d.Idtk)
                .HasConstraintName("FK__UuDai__IDTK__36B12243");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
