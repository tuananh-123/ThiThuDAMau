using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositoriess
{
    public interface INhanvienRepository
    {
        IEnumerable<Nhanvien> GetByValue(string value);
    }
}
