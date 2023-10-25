using _2.BUS.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INhanVienSerivce
    {
        List<NhanVienDto> GetAll();
        List<NhanVienDto> GetByValue(string value);
    }
}
