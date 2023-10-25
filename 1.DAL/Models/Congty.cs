using System;
using System.Collections.Generic;

namespace _1.DAL.Models
{
    public partial class Congty : BaseEntity
    {
        public Congty()
        {
            Nhanviens = new HashSet<Nhanvien>();
        }

        public string Ten { get; set; } = null!;
        public string? Diachi { get; set; }

        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}
