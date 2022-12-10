using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HospitalWebApi.GenericRepositoryPattern
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
     where TEntity : class, IEntity, new()
     where TContext : DbContext, new()
    {
        public IList<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate = null)
        {
            using TContext context = new TContext();
            return predicate == null ?
                context.Set<TEntity>().ToList() :
                context.Set<TEntity>().Where(predicate).ToList();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            using TContext context = new TContext();
            return context.Set<TEntity>().FirstOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            using TContext context = new TContext();
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using TContext context = new TContext();
            context.Set<TEntity>().Update(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using TContext context = new TContext();
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }
    }
}
