using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class UuDai
{
    public int Idud { get; set; }

    public int? Idtk { get; set; }

    public DateOnly? NgayBatDau { get; set; }

    public DateOnly? NgayKetThuc { get; set; }

    public virtual TaiKhoan? IdtkNavigation { get; set; }
}
