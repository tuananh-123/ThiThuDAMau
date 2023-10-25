using System;
using System.Collections.Generic;

namespace _1.DAL.Models
{
    public partial class Nhanvien : BaseEntity
    {
      
        public string Ten { get; set; } = null!;
        public string Diachi { get; set; } = null!;
        public string? Sodienthoai { get; set; }
        public DateTime? Ngaytuyendung { get; set; }
        public int? IdCn { get; set; }

        public virtual Congty? IdCnNavigation { get; set; }
    }
}
