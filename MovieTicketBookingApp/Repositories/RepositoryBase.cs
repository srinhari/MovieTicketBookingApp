using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MovieTicketBookingApp.Models;

namespace MovieTicketBookingApp.Repositories
{
    public abstract class RepositoryBase<T> :
        IRepository<T> where T : class
    {

        protected MovieBookingContext context;

        protected RepositoryBase(MovieBookingContext context)
        {
            this.context = context;
        }


        public virtual T Add(T entity)
        {
            return context.Add(entity).Entity;
        }

        public virtual T Update(T entity)
        {
            return context.Update(entity).Entity;
        }

        public virtual T Get(Guid id)
        {
            return context.Find<T>(id);
        }

        public virtual IQueryable<T> All()
        {
            return context.Set<T>();
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().AsQueryable().Where(predicate).ToList();
        }

        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
