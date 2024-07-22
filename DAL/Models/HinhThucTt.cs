using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HinhThucTt
{
    public int MaThanhToan { get; set; }

    public string? TenHt { get; set; }

    public string? Mota { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
