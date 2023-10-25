using System;
using System.Collections.Generic;

namespace _1.DAL.Models
{
    public partial class Chunhan : BaseEntity
    {
        public Chunhan()
        {
            Thucungs = new HashSet<Thucung>();
        }

        public string Ten { get; set; } = null!;
        public string? Diachi { get; set; }

        public virtual ICollection<Thucung> Thucungs { get; set; }
    }
}
