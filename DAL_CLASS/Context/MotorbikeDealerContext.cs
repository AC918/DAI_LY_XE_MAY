using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL_CLASS.MainClass;

namespace DAL_CLASS.Context
{
    public partial class MotorbikeDealerContext : DbContext
    {
        public MotorbikeDealerContext()
        {
        }

        public MotorbikeDealerContext(DbContextOptions<MotorbikeDealerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BanHang> BanHangs { get; set; } = null!;
        public virtual DbSet<DichVuBaoDuong> DichVuBaoDuongs { get; set; } = null!;
        public virtual DbSet<DichVuBaoHanh> DichVuBaoHanhs { get; set; } = null!;
        public virtual DbSet<DoanhThu> DoanhThus { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public virtual DbSet<XeMay> XeMays { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-NUP1I8BE\\SQLEXPRESS;Initial Catalog=MotorbikeDealer;Integrated Security=True;Trust Server Certificate=true;");
#pragma warning restore CS1030 // #warning directive
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BanHang>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__BanHang__CA1EB690C2DC28A0");

                entity.ToTable("BanHang");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LoaiXeBan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaXmb).HasColumnName("MaXMB");

                entity.Property(e => e.MauXeBan).HasMaxLength(30);

                entity.Property(e => e.TenXeBan).HasMaxLength(50);

                entity.HasOne(d => d.MaXmbNavigation)
                    .WithMany(p => p.BanHangs)
                    .HasForeignKey(d => d.MaXmb)
                    .HasConstraintName("FK__BanHang__MaXMB__5070F446");
            });

            modelBuilder.Entity<DichVuBaoDuong>(entity =>
            {
                entity.HasKey(e => e.MaBaoDuong)
                    .HasName("PK__DichVuBa__2470867375D4129C");

                entity.ToTable("DichVuBaoDuong");

                entity.Property(e => e.MaBaoDuong).HasDefaultValueSql("(newid())");

                entity.Property(e => e.MaKhbd).HasColumnName("MaKHBD");

                entity.Property(e => e.SdtkhbaoDuong)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDTKHBaoDuong");

                entity.Property(e => e.TenKhbaoDuong)
                    .HasMaxLength(50)
                    .HasColumnName("TenKHBaoDuong");

                entity.Property(e => e.ThoiGianBaoDuong).HasColumnType("date");

                entity.HasOne(d => d.MaKhbdNavigation)
                    .WithMany(p => p.DichVuBaoDuongs)
                    .HasForeignKey(d => d.MaKhbd)
                    .HasConstraintName("FK__DichVuBao__MaKHB__60A75C0F");
            });

            modelBuilder.Entity<DichVuBaoHanh>(entity =>
            {
                entity.HasKey(e => e.MaBaoHanh)
                    .HasName("PK__DichVuBa__A8DF52E57CD46FB4");

                entity.ToTable("DichVuBaoHanh");

                entity.Property(e => e.MaBaoHanh).HasDefaultValueSql("(newid())");

                entity.Property(e => e.HanBaoHanh).HasColumnType("datetime");

                entity.Property(e => e.MaKhbh).HasColumnName("MaKHBH");

                entity.Property(e => e.MaXmbh).HasColumnName("MaXMBH");

                entity.Property(e => e.TenKhbaoHanh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKHBaoHanh");

                entity.Property(e => e.TenXeBaoHanh).HasMaxLength(50);

                entity.Property(e => e.ThoiGianBan).HasColumnType("datetime");

                entity.HasOne(d => d.MaKhbhNavigation)
                    .WithMany(p => p.DichVuBaoHanhs)
                    .HasForeignKey(d => d.MaKhbh)
                    .HasConstraintName("FK__DichVuBao__MaKHB__5535A963");

                entity.HasOne(d => d.MaXmbhNavigation)
                    .WithMany(p => p.DichVuBaoHanhs)
                    .HasForeignKey(d => d.MaXmbh)
                    .HasConstraintName("FK__DichVuBao__MaXMB__5441852A");
            });

            modelBuilder.Entity<DoanhThu>(entity =>
            {
                entity.HasKey(e => e.Stt)
                    .HasName("PK__DoanhThu__CA1EB69087807740");

                entity.ToTable("DoanhThu");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.MaXmtk).HasColumnName("MaXMTK");

                entity.Property(e => e.NgayBan).HasColumnType("date");

                entity.Property(e => e.TongDoanhThu).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TrangThaiDt).HasColumnName("TrangThaiDT");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.DoanhThus)
                    .HasForeignKey(d => d.MaHd)
                    .HasConstraintName("FK__DoanhThu__MaHD__4CA06362");

                entity.HasOne(d => d.MaXmtkNavigation)
                    .WithMany(p => p.DoanhThus)
                    .HasForeignKey(d => d.MaXmtk)
                    .HasConstraintName("FK__DoanhThu__MaXMTK__4D94879B");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13B104979E3");

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHoaDon).HasDefaultValueSql("(newid())");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK__HoaDon__MaKH__47DBAE45");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.Gia).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MaXeCt).HasColumnName("MaXeCT");

                entity.Property(e => e.MaXm).HasColumnName("MaXM");

                entity.Property(e => e.TenXeCt).HasColumnName("TenXeCT");

                entity.Property(e => e.TongGia).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MaXmNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaXm)
                    .HasConstraintName("FK__HoaDonChiT__MaXM__49C3F6B7");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KhachHan__88D2F0E5E69B6540");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKhachHang).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChiKhachHang).HasMaxLength(100);

                entity.Property(e => e.GioiTinhKh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GioiTinhKH");

                entity.Property(e => e.SdtkhachHang)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDTKhachHang");

                entity.Property(e => e.TenDichVuDung).HasMaxLength(100);

                entity.Property(e => e.TenKhachHang).HasMaxLength(50);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA476FDEF21C");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNhanVien).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DiaChiNhanVien).HasMaxLength(100);

                entity.Property(e => e.EmailNhanVien)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinhNv)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GioiTinhNV");

                entity.Property(e => e.SdtnhanVien)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDTNhanVien");

                entity.Property(e => e.Sttdn).HasColumnName("sttdn");

                entity.Property(e => e.TenNhanVien).HasMaxLength(50);

                entity.HasOne(d => d.SttdnNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.Sttdn)
                    .HasConstraintName("FK__NhanVien__sttdn__4316F928");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.ToTable("TaiKhoan");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TenTaiKhoan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VaiTro).HasMaxLength(30);
            });

            modelBuilder.Entity<XeMay>(entity =>
            {
                entity.HasKey(e => e.MaXe)
                    .HasName("PK__XeMay__272520CDC64D7E8E");

                entity.ToTable("XeMay");

                entity.Property(e => e.MaXe).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiaXe).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LoaiXe)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MauXe).HasMaxLength(20);

                entity.Property(e => e.TenXe).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
