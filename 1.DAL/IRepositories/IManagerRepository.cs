using _1.DAL.IRepositoriess;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IManagerRepository<T> where T : BaseEntity
    {
        IBaseRepository<T> baseRepository { get; }
        INhanvienRepository nhanvienRepository { get; }
    }
}
