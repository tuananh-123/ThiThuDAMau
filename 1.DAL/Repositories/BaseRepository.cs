using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    internal sealed class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly SOF205FINALNONEContext _context;

        public BaseRepository(SOF205FINALNONEContext context)
        {
            _context=context;
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id)!;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
