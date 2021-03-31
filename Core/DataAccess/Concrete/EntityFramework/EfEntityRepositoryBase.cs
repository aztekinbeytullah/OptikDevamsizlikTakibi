using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
     where TEntity : class, IEntity, new()
     where TContext : DbContext, new()
    {
        public void Ekle(TEntity TEntity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(TEntity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Guncelle(TEntity TEntity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(TEntity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Sil(TEntity TEntity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(TEntity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
