using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDon
{
    public int Idhd { get; set; }

    public int? MaKh { get; set; }

    public DateOnly? NgayDatHang { get; set; }

    public decimal? TongTien { get; set; }

    public int? MaHinhThuc { get; set; }

    public int? Idtk { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual TaiKhoan? IdtkNavigation { get; set; }

    public virtual HinhThucTt? MaHinhThucNavigation { get; set; }

    public virtual KhachHang? MaKhNavigation { get; set; }
}
