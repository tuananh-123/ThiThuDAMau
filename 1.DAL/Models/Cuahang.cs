using System;
using System.Collections.Generic;

namespace _1.DAL.Models
{
    public partial class Cuahang : BaseEntity
    {
        
        public string Ten { get; set; } = null!;
        public string Mota { get; set; } = null!;
        public string? Loaihang { get; set; }
        public DateTime? Ngaydangky { get; set; }
        public int? IdCn { get; set; }

        public virtual Trungtam? IdCnNavigation { get; set; }
    }
}
