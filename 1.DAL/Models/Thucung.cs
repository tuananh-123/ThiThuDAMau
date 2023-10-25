using System;
using System.Collections.Generic;

namespace _1.DAL.Models
{
    public partial class Thucung : BaseEntity
    {
      
        public string Ten { get; set; } = null!;
        public string Loai { get; set; } = null!;
        public string? Maulong { get; set; }
        public int? Tuoi { get; set; }
        public int? IdCn { get; set; }

        public virtual Chunhan? IdCnNavigation { get; set; }
    }
}
