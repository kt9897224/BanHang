using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPham
{
    public int Idsp { get; set; }

    public string? TenSp { get; set; }

    public string? Mota { get; set; }

    public decimal? Gia { get; set; }

    public int? Soluong { get; set; }

    public int? IdnhaCungCap { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual NhaCungCap? IdnhaCungCapNavigation { get; set; }
}
