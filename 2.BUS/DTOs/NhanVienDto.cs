using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.DTOs
{
    public class NhanVienDto
    {
        public int STT { get; set; }
        public string Ten { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public string SoDienThoai { get; set; } = null!;
        public DateTime NgayTuyenDung { get; set; }
    }
}
