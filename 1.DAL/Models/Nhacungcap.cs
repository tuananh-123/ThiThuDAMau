using System;
using System.Collections.Generic;

namespace _1.DAL.Models
{
    public partial class Nhacungcap : BaseEntity
    {
        public Nhacungcap()
        {
            Sanphams = new HashSet<Sanpham>();
        }

      
        public string Ten { get; set; } = null!;
        public string? Diachi { get; set; }

        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
