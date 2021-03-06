﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Snacklager.Data;
using Snacklager.Logic.Contracts;

namespace Snacklager.Logic
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SchokolagerModel _db = null;
        private readonly DbSet<T> _table = null;

        public Repository()
        {
            _db = new SchokolagerModel();
            _table = _db.Set<T>();
        }

        public Repository(SchokolagerModel db)
        {
            _db = db;
            _table = _db.Set<T>();
        }

        public T FindById(int id)
        {
            return _table.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

        public void Insert(T entity)
        {
            _table.Add(entity);
        }

        public void Remove(int id)
        {
            T entry = _table.Find(id);
            _table.Remove(entry);
        }

        public void Update(T entity)
        {
            _table.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public bool SaveAll()
        {
            return _db.SaveChanges() > 0;
        }
    }
}
