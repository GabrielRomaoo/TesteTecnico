using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teste.Domain.Abstractions;
using Teste.Domain.Entities;
using Teste.Infraestructure.Data.Context;

namespace Teste.Infraestructure.Data.Repository
{
    public class UserRepository : IBaseRepository<User>
    {
        protected readonly TesteTecnicoDbContext _context;

        public UserRepository(TesteTecnicoDbContext dbContext)
        {
            _context = dbContext;
        }

        void IBaseRepository<User>.Delete(User entity)
        {
            _context.Set<User>().Remove(entity);
            _context.SaveChanges();
        }

        IEnumerable<User> IBaseRepository<User>.GetAll()
        {
            return _context.Set<User>().ToList();
        }

        User IBaseRepository<User>.GetById(int Id)
        {
            return _context.Set<User>().Where(user => user.Id == Id).FirstOrDefault();
        }

        void IBaseRepository<User>.Insert(User entity)
        {
            _context.Set<User>().Add(entity);
        }

        void IBaseRepository<User>.Update(User entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

        }
    }
}
