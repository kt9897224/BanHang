using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KhachHang
{
    public int Idkh { get; set; }

    public string? TenKh { get; set; }

    public string? Diachi { get; set; }

    public string? Sdt { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
