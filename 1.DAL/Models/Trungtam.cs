using System;
using System.Collections.Generic;

namespace _1.DAL.Models
{
    public partial class Trungtam : BaseEntity
    {
        public Trungtam()
        {
            Cuahangs = new HashSet<Cuahang>();
        }

     
        public string Ten { get; set; } = null!;
        public string? Diachi { get; set; }

        public virtual ICollection<Cuahang> Cuahangs { get; set; }
    }
}
