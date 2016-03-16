using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositorioGenerico.CRUD.Repository.Base
{
    public abstract class BaseRepository<TEntity> : Interfaces.IRepository<TEntity> where TEntity : class
    {

        private readonly DbContext context = null;
        protected DbSet<TEntity> entity = null;



        //CONSTRUTORES
        public BaseRepository(DbContext context)
        {
            this.context = context;
            this.entity = context.Set<TEntity>();
        }


        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public List<TEntity> GetAll(System.Linq.Expressions.Expression<Func<TEntity, bool>> Predicate)
        {
            return context.Set<TEntity>().Where(Predicate).ToList();
        }

        public TEntity Find(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            //SOMENTE FAZ ALTERAÇÕES ENCIMA DO QUE TEVE COMO ALTERAÇÕES 
            //NO MODELO
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
