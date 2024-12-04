﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFrameWork
{
    public class EfEntityRepistoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IDto, new()
        where TContext : DbContext,new()
    
    {
        public void Add(TEntity entity)
        {
            using (TContext context=new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> GetByAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context=new TContext())
            {
                return filter ==null 
                    ?context.Set<TEntity>().ToList()
                    :context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}