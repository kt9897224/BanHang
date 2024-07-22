using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NhaCungCap
{
    public int IdnhaCungCap { get; set; }

    public string? TenNhaCungCap { get; set; }

    public string? TenNguoiLienHe { get; set; }

    public string? Sdt { get; set; }

    public string? DiaChi { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
