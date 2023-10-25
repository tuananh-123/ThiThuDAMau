using _1.DAL.IRepositoriess;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    internal sealed class NhanvienRepository : INhanvienRepository
    {
        private readonly SOF205FINALNONEContext _dbcontext;

        public NhanvienRepository(SOF205FINALNONEContext dbcontext)
        {
            _dbcontext=dbcontext;
        }

        public IEnumerable<Nhanvien> GetByValue(string value)
        {
            return _dbcontext.Nhanviens.Where(nv => nv.Ten.ToLower().Contains(value.ToLower()) || nv.Diachi.ToLower().Contains(value.ToLower())).ToList();
        }
    }
}
