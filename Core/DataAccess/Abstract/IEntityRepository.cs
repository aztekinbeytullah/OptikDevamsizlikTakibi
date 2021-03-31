using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        void Ekle(T TEntity);
        void Sil(T TEntity);
        void Guncelle(T TEntity);
    }
}
