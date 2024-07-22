using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDonChiTiet
{
    public int Idhdct { get; set; }

    public int? Idhd { get; set; }

    public int? Idsp { get; set; }

    public int? SoLuong { get; set; }

    public virtual HoaDon? IdhdNavigation { get; set; }

    public virtual SanPham? IdspNavigation { get; set; }
}
