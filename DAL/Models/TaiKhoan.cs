using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TaiKhoan
{
    public int Idtk { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? HovaTen { get; set; }

    public string? GioiTinh { get; set; }

    public string? Sdt { get; set; }

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public DateOnly? NgayTaoTaiKhoan { get; set; }

    public string? TrangThai { get; set; }

    public string? TenChucVu { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ICollection<UuDai> UuDais { get; set; } = new List<UuDai>();
}
