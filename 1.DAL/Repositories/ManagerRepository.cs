using _1.DAL.IRepositories;
using _1.DAL.IRepositoriess;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public sealed class ManagerRepository<T> : IManagerRepository<T> where T : BaseEntity
    {
        private readonly SOF205FINALNONEContext _context;
        private Lazy<IBaseRepository<T>> _lazyBaseRepository;
        private Lazy<INhanvienRepository> _lazyNhanvienRepository;

        public ManagerRepository(SOF205FINALNONEContext context)
        {
            _context = context;
            _lazyBaseRepository = new Lazy<IBaseRepository<T>>(() => new BaseRepository<T>(_context));
            _lazyNhanvienRepository = new Lazy<INhanvienRepository>(() => new NhanvienRepository(_context));
        }

        public IBaseRepository<T> baseRepository => _lazyBaseRepository.Value;

        public INhanvienRepository nhanvienRepository => _lazyNhanvienRepository.Value;

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
