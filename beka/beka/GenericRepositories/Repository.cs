using beka.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beka.GenericRepositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> _entity = null;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entity = _context.Set<T>();
        }
        public void Delete(object id)
        {
            T existing = _entity.Find(id);
            _context.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return _entity.ToList();
        }

        public T GetById(object id)
        {
            return _entity.Find(id);
        }

        public void Insert(T obj)
        {
            _entity.Add(obj);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            _entity.Attach(obj);
            _context.Update(obj);
        }
    }
}
