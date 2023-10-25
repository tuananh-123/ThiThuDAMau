using System;
using System.Collections.Generic;

namespace _1.DAL.Models
{
    public partial class Sanpham : BaseEntity
    {
       
        public string Ten { get; set; } = null!;
        public string Mota { get; set; } = null!;
        public int? Soluongtonkho { get; set; }
        public int? Giatien { get; set; }
        public int? IdNcc { get; set; }

        public virtual Nhacungcap? IdNccNavigation { get; set; }
    }
}
